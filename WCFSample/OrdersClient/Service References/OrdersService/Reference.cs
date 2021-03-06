﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrdersClient.OrdersService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="WCFSampleLib.Customer")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal BalanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Balance {
            get {
                return this.BalanceField;
            }
            set {
                if ((this.BalanceField.Equals(value) != true)) {
                    this.BalanceField = value;
                    this.RaisePropertyChanged("Balance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="WCFSampleLib.Product")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OnHandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OnHand {
            get {
                return this.OnHandField;
            }
            set {
                if ((this.OnHandField.Equals(value) != true)) {
                    this.OnHandField = value;
                    this.RaisePropertyChanged("OnHand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="WCFSampleLib.Order")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="WCFSampleLib.Person")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrdersService.IWCFSampleJson")]
    public interface IWCFSampleJson {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSampleJson/GetDataJson", ReplyAction="http://tempuri.org/IWCFSampleJson/GetDataJsonResponse")]
        OrdersClient.OrdersService.Person GetDataJson(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSampleJson/GetDataJson", ReplyAction="http://tempuri.org/IWCFSampleJson/GetDataJsonResponse")]
        System.Threading.Tasks.Task<OrdersClient.OrdersService.Person> GetDataJsonAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSampleJson/GetDataUsingDataContractJson", ReplyAction="http://tempuri.org/IWCFSampleJson/GetDataUsingDataContractJsonResponse")]
        OrdersClient.OrdersService.Person GetDataUsingDataContractJson(OrdersClient.OrdersService.Person person, OrdersClient.OrdersService.Person person1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSampleJson/GetDataUsingDataContractJson", ReplyAction="http://tempuri.org/IWCFSampleJson/GetDataUsingDataContractJsonResponse")]
        System.Threading.Tasks.Task<OrdersClient.OrdersService.Person> GetDataUsingDataContractJsonAsync(OrdersClient.OrdersService.Person person, OrdersClient.OrdersService.Person person1);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCFSampleJsonChannel : OrdersClient.OrdersService.IWCFSampleJson, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFSampleJsonClient : System.ServiceModel.ClientBase<OrdersClient.OrdersService.IWCFSampleJson>, OrdersClient.OrdersService.IWCFSampleJson {
        
        public WCFSampleJsonClient() {
        }
        
        public WCFSampleJsonClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFSampleJsonClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFSampleJsonClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFSampleJsonClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public OrdersClient.OrdersService.Person GetDataJson(string name) {
            return base.Channel.GetDataJson(name);
        }
        
        public System.Threading.Tasks.Task<OrdersClient.OrdersService.Person> GetDataJsonAsync(string name) {
            return base.Channel.GetDataJsonAsync(name);
        }
        
        public OrdersClient.OrdersService.Person GetDataUsingDataContractJson(OrdersClient.OrdersService.Person person, OrdersClient.OrdersService.Person person1) {
            return base.Channel.GetDataUsingDataContractJson(person, person1);
        }
        
        public System.Threading.Tasks.Task<OrdersClient.OrdersService.Person> GetDataUsingDataContractJsonAsync(OrdersClient.OrdersService.Person person, OrdersClient.OrdersService.Person person1) {
            return base.Channel.GetDataUsingDataContractJsonAsync(person, person1);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrdersService.IWCFSampleSoap")]
    public interface IWCFSampleSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSampleSoap/GetDataSoap", ReplyAction="http://tempuri.org/IWCFSampleSoap/GetDataSoapResponse")]
        OrdersClient.OrdersService.Person GetDataSoap(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSampleSoap/GetDataSoap", ReplyAction="http://tempuri.org/IWCFSampleSoap/GetDataSoapResponse")]
        System.Threading.Tasks.Task<OrdersClient.OrdersService.Person> GetDataSoapAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSampleSoap/GetDataUsingDataContractSoap", ReplyAction="http://tempuri.org/IWCFSampleSoap/GetDataUsingDataContractSoapResponse")]
        OrdersClient.OrdersService.Person GetDataUsingDataContractSoap(OrdersClient.OrdersService.Person person, OrdersClient.OrdersService.Person person1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFSampleSoap/GetDataUsingDataContractSoap", ReplyAction="http://tempuri.org/IWCFSampleSoap/GetDataUsingDataContractSoapResponse")]
        System.Threading.Tasks.Task<OrdersClient.OrdersService.Person> GetDataUsingDataContractSoapAsync(OrdersClient.OrdersService.Person person, OrdersClient.OrdersService.Person person1);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCFSampleSoapChannel : OrdersClient.OrdersService.IWCFSampleSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFSampleSoapClient : System.ServiceModel.ClientBase<OrdersClient.OrdersService.IWCFSampleSoap>, OrdersClient.OrdersService.IWCFSampleSoap {
        
        public WCFSampleSoapClient() {
        }
        
        public WCFSampleSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFSampleSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFSampleSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFSampleSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public OrdersClient.OrdersService.Person GetDataSoap(string name) {
            return base.Channel.GetDataSoap(name);
        }
        
        public System.Threading.Tasks.Task<OrdersClient.OrdersService.Person> GetDataSoapAsync(string name) {
            return base.Channel.GetDataSoapAsync(name);
        }
        
        public OrdersClient.OrdersService.Person GetDataUsingDataContractSoap(OrdersClient.OrdersService.Person person, OrdersClient.OrdersService.Person person1) {
            return base.Channel.GetDataUsingDataContractSoap(person, person1);
        }
        
        public System.Threading.Tasks.Task<OrdersClient.OrdersService.Person> GetDataUsingDataContractSoapAsync(OrdersClient.OrdersService.Person person, OrdersClient.OrdersService.Person person1) {
            return base.Channel.GetDataUsingDataContractSoapAsync(person, person1);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrdersService.IOrdersService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IOrdersService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdersService/GetCustomers", ReplyAction="http://tempuri.org/IOrdersService/GetCustomersResponse")]
        OrdersClient.OrdersService.Customer[] GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdersService/GetCustomers", ReplyAction="http://tempuri.org/IOrdersService/GetCustomersResponse")]
        System.Threading.Tasks.Task<OrdersClient.OrdersService.Customer[]> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdersService/GetProducts", ReplyAction="http://tempuri.org/IOrdersService/GetProductsResponse")]
        OrdersClient.OrdersService.Product[] GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdersService/GetProducts", ReplyAction="http://tempuri.org/IOrdersService/GetProductsResponse")]
        System.Threading.Tasks.Task<OrdersClient.OrdersService.Product[]> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdersService/PlaceOrder", ReplyAction="http://tempuri.org/IOrdersService/PlaceOrderResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Mandatory)]
        string PlaceOrder(OrdersClient.OrdersService.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdersService/PlaceOrder", ReplyAction="http://tempuri.org/IOrdersService/PlaceOrderResponse")]
        System.Threading.Tasks.Task<string> PlaceOrderAsync(OrdersClient.OrdersService.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdersService/AdjustInventory", ReplyAction="http://tempuri.org/IOrdersService/AdjustInventoryResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Mandatory)]
        string AdjustInventory(int productID, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdersService/AdjustInventory", ReplyAction="http://tempuri.org/IOrdersService/AdjustInventoryResponse")]
        System.Threading.Tasks.Task<string> AdjustInventoryAsync(int productID, int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdersService/AdjustBalance", ReplyAction="http://tempuri.org/IOrdersService/AdjustBalanceResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Mandatory)]
        string AdjustBalance(int customerID, decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdersService/AdjustBalance", ReplyAction="http://tempuri.org/IOrdersService/AdjustBalanceResponse")]
        System.Threading.Tasks.Task<string> AdjustBalanceAsync(int customerID, decimal amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrdersServiceChannel : OrdersClient.OrdersService.IOrdersService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrdersServiceClient : System.ServiceModel.ClientBase<OrdersClient.OrdersService.IOrdersService>, OrdersClient.OrdersService.IOrdersService {
        
        public OrdersServiceClient() {
        }
        
        public OrdersServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrdersServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrdersServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrdersServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public OrdersClient.OrdersService.Customer[] GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<OrdersClient.OrdersService.Customer[]> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public OrdersClient.OrdersService.Product[] GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<OrdersClient.OrdersService.Product[]> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public string PlaceOrder(OrdersClient.OrdersService.Order order) {
            return base.Channel.PlaceOrder(order);
        }
        
        public System.Threading.Tasks.Task<string> PlaceOrderAsync(OrdersClient.OrdersService.Order order) {
            return base.Channel.PlaceOrderAsync(order);
        }
        
        public string AdjustInventory(int productID, int quantity) {
            return base.Channel.AdjustInventory(productID, quantity);
        }
        
        public System.Threading.Tasks.Task<string> AdjustInventoryAsync(int productID, int quantity) {
            return base.Channel.AdjustInventoryAsync(productID, quantity);
        }
        
        public string AdjustBalance(int customerID, decimal amount) {
            return base.Channel.AdjustBalance(customerID, amount);
        }
        
        public System.Threading.Tasks.Task<string> AdjustBalanceAsync(int customerID, decimal amount) {
            return base.Channel.AdjustBalanceAsync(customerID, amount);
        }
    }
}
