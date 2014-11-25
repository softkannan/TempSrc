using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.Transactions;
using OrdersClient.OrdersService;

namespace OrdersClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Customer customer = null;
        private List<Customer> customers = null;
        private Product product = null;
        private List<Product> products = null;
        private OrdersServiceClient proxy = null;
        private Order order = null;
        private string result = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {
            proxy = new OrdersServiceClient();
            GetCustomersAndProducts();
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            customer = (Customer)this.customerBindingSource.Current;
            product = (Product)this.productBindingSource.Current;
            Int32 quantity = Convert.ToInt32(quantityTextBox.Text);

            order = new Order();
            order.CustomerId = customer.CustomerId;
            order.ProductId = product.ProductId;
            order.Price = product.Price;
            order.Quantity = quantity;
            order.Amount = order.Price * Convert.ToDecimal(order.Quantity);

            using (var tranScope = new TransactionScope())
            {
                proxy = new OrdersServiceClient();
                {
                    try
                    {
                        result = proxy.PlaceOrder(order);
                        MessageBox.Show(result);

                        result = proxy.AdjustInventory(product.ProductId, quantity);
                        MessageBox.Show(result);

                        result = proxy.AdjustBalance(customer.CustomerId,
                          Convert.ToDecimal(quantity) * order.Price);
                        MessageBox.Show(result);
                        proxy.Close();
                        tranScope.Complete();
                    }
                    catch (FaultException faultEx)
                    {
                        MessageBox.Show(faultEx.Message +
                          "\n\nThe order was not placed");
                    }
                    catch (ProtocolException protocolEx)
                    {
                        MessageBox.Show(protocolEx.Message +
                          "\n\nThe order was not placed");
                    }
                }
            }
            quantityTextBox.Clear();
            try
            {
                proxy = new OrdersServiceClient();
                GetCustomersAndProducts();
            }
            catch (FaultException faultEx)
            {
                MessageBox.Show(faultEx.Message);
            }
        }

        private void GetCustomersAndProducts()
        {
            customers = new List<Customer>(proxy.GetCustomers());
            customerBindingSource.DataSource = customers;

            products = new List<Product>(proxy.GetProducts());
            productBindingSource.DataSource = products;
        }
    }
}
