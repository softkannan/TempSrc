using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using System.Web;
using WCFSampleLib;

namespace WCFServer
{
    [ServiceBehavior(
        AutomaticSessionShutdown = true,
        ConcurrencyMode = ConcurrencyMode.Multiple,
        TransactionIsolationLevel = System.Transactions.IsolationLevel.Serializable,
        TransactionTimeout = "00:00:30", 
        InstanceContextMode = InstanceContextMode.PerSession,
        ReleaseServiceInstanceOnTransactionComplete = false
        )]
    public class WCFSample : IWCFSampleJson, IWCFSampleSoap, IOrdersService
    {
        public WCFSample()
        {
            LogSQL("Session Created.");

            OperationContext.Current.InstanceContext.Closing += InstanceContext_Closing;
            
        }

        void InstanceContext_Closing(object sender, EventArgs e)
        {
            LogSQL("Session Completd.");
        }
        private void LogSQL(string sqlData)
        {
            MainWindow.LogMsg(sqlData);
        }

        public WCFSampleLib.Person GetDataJson(string name)
        {
            var retVal = new WCFSampleLib.Person();
            retVal.Name = name;
            return retVal;
        }

        public WCFSampleLib.Person GetDataUsingDataContractJson(WCFSampleLib.Person person, WCFSampleLib.Person person1)
        {
            var tempVal = HttpContext.Current.Session.SessionID;

            if (person == null)
            {
                throw new ArgumentNullException("composite");
            }

            return person;
        }

        public WCFSampleLib.Person GetDataSoap(string name)
        {
            var retVal = new WCFSampleLib.Person();
            retVal.Name = name;
            return retVal;
        }

        public WCFSampleLib.Person GetDataUsingDataContractSoap(WCFSampleLib.Person person, WCFSampleLib.Person person1)
        {
            if (person == null)
            {
                throw new ArgumentNullException("composite");
            }

            return person;
        }


        private List<WCFSampleLib.Customer> Customers { get; set; }
        private List<WCFSampleLib.Product> Products { get; set; }
        private int OrderID { get; set; }

        public List<WCFSampleLib.Customer> GetCustomers()
        {
            var retVal = new List<WCFSampleLib.Customer>();

            using (TransactionsDBEntities db = new TransactionsDBEntities())
            {
                db.Database.Log = LogSQL;

                retVal = (from t in db.Customers
                          select new WCFSampleLib.Customer()
                          {
                              CustomerId = t.CustomerId,
                              Balance = t.Balance,
                              CompanyName = t.Name
                          }).ToList();
            }

            return retVal;
        }

        public List<WCFSampleLib.Product> GetProducts()
        {
            var retVal = new List<WCFSampleLib.Product>();

            using (TransactionsDBEntities db = new TransactionsDBEntities())
            {
                db.Database.Log = LogSQL;

                retVal = (from t in db.Products
                          select new WCFSampleLib.Product()
                          {
                              OnHand = t.OnHand,
                              Price = t.Price,
                              ProductId = t.ProductId,
                              ProductName = t.Name
                          }).ToList();
            }
            return retVal;
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public string PlaceOrder(WCFSampleLib.Order order)
        {
            string retVal = "The order was not placed";
            try
            {

                

                using (TransactionsDBEntities db = new TransactionsDBEntities())
                {
                    db.Database.Log = LogSQL;

                    var orderNew = db.Orders.Create();

                    orderNew.Amount = order.Amount;
                    orderNew.CustomerId = order.CustomerId;
                    orderNew.Price = order.Price;
                    orderNew.ProductId = order.ProductId;
                    orderNew.Quantity = (short)order.Quantity;

                    db.Orders.Add(orderNew);

                    var modified = db.SaveChanges();

                    if (modified > 0)
                    {
                        retVal = string.Format("Order {0} was placed", orderNew.OrderId);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }

            return retVal;
        }
        [OperationBehavior(TransactionScopeRequired = true)]
        public string AdjustInventory(int productID, int quantity)
        {
            string retVal = "The inventory was not updated";
            try
            {
                using (TransactionsDBEntities db = new TransactionsDBEntities())
                {
                    db.Database.Log = LogSQL;

                    var product = (from t in db.Products where t.ProductId == productID select t).First();

                    product.OnHand -= (short)quantity;

                    if (product.OnHand < 0)
                    {
                        throw new ArgumentException("Not Enough Item in stock, try order lesser quantiy");
                    }

                    var modified = db.SaveChanges();

                    if (modified > 0)
                    {
                        retVal = "The inventory was updated";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }

            return retVal;
        }
        [OperationBehavior(TransactionScopeRequired = true)]
        public string AdjustBalance(int customerID, decimal amount)
        {
            string retVal = "The balance was not updated";

            try
            {
                using (TransactionsDBEntities db = new TransactionsDBEntities())
                {
                    db.Database.Log = LogSQL;

                    var customer = (from t in db.Customers where t.CustomerId == customerID select t).First();

                    customer.Balance -= amount;

                    if (customer.Balance < 0)
                    {
                        throw new ArgumentException("Customer doesn't have enought money, try order cheaper items / lesser quandity");
                    }

                    try
                    {
                        var modified = db.SaveChanges();

                        if (modified > 0)
                        {
                            retVal = "The balance was updated";
                        }
                    }
                    catch(DbUpdateException ex)
                    {
                        
                    }

                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }

            return retVal;
        }

    }
}
