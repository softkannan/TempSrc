using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WCFSampleLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWCFSampleJson
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            ResponseFormat = WebMessageFormat.Json, UriTemplate = "person/{name}")]
        Person GetDataJson(string name);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "full", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        Person GetDataUsingDataContractJson(Person person,Person person1);

    }

    [ServiceContract]
    public interface IWCFSampleSoap
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            ResponseFormat = WebMessageFormat.Xml, UriTemplate = "person/{name}")]
        Person GetDataSoap(string name);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "full", ResponseFormat = WebMessageFormat.Xml,
            RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        Person GetDataUsingDataContractSoap(Person person, Person person1);

    }

    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface ISchoolService
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.NotAllowed)]
        List<Person> GetStudents();
    }

    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IOrdersService
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.NotAllowed)]
        List<Customer> GetCustomers();

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.NotAllowed)]
        List<Product> GetProducts();

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        string PlaceOrder(Order order);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        string AdjustInventory(int productID, int quantity);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        string AdjustBalance(int customerID, decimal amount);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WCFSampleLib.ContractType".
    [DataContract(Namespace="WCFSampleLib.Person")]
    public class Person
    {
        public Person()
        {
            Name = "Unknown";
            Age = -1;
        }

        [DataMember]
        public int Age {get;set;}

        [DataMember]
        public string Name {get;set;}
    }

    [DataContract(Namespace = "WCFSampleLib.Customer")]
    public class Customer
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public string CompanyName { get; set; }

        [DataMember]
        public decimal Balance { get; set; }
    }

    [DataContract(Namespace = "WCFSampleLib.Product")]
    public class Product
    {
        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public string ProductName { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public int OnHand { get; set; }
    }

    [DataContract(Namespace = "WCFSampleLib.Order")]
    public class Order
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public decimal Amount { get; set; }
    }
}
