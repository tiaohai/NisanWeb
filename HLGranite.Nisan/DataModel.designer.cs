// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>HLGranite.Nisan</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace HLGranite.Nisan
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;


    public partial class Customer : User
    {
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Admin))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Carrier))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Designer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Agent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Customer))]
    public partial class User : DatabaseObject
    {
        protected Address addressField;

        protected string codeField;

        protected string nameField;

        protected string passwordField;

        protected string emailField;

        protected string phoneField;

        protected Role typeField;

        public Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }
    }

    public partial class Address : DatabaseObject
    {

        private string streetField;

        private string postalField;

        private string stateField;

        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        public string Postal
        {
            get
            {
                return this.postalField;
            }
            set
            {
                this.postalField = value;
            }
        }

        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Delivery))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Commission))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Payment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Order))]
    public partial class TransactionItem : DatabaseObject
    {

        private Stock stockField;

        private Transaction parentField;

        private decimal amountField;

        public Stock Stock
        {
            get
            {
                return this.stockField;
            }
            set
            {
                this.stockField = value;
            }
        }

        public Transaction Parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
            }
        }

        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Nisan))]
    public partial class Stock : DatabaseObject
    {

        private string typeField;

        private decimal priceField;

        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
    }

    public partial class Nisan : Stock
    {

        private string nameField;

        private string jawiField;

        private System.DateTime bornField;

        private System.DateTime deathField;

        private System.DateTime deathmField;

        private int ageField;

        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        public string Jawi
        {
            get
            {
                return this.jawiField;
            }
            set
            {
                this.jawiField = value;
            }
        }

        public System.DateTime Born
        {
            get
            {
                return this.bornField;
            }
            set
            {
                this.bornField = value;
            }
        }

        public System.DateTime Death
        {
            get
            {
                return this.deathField;
            }
            set
            {
                this.deathField = value;
            }
        }

        public System.DateTime Deathm
        {
            get
            {
                return this.deathmField;
            }
            set
            {
                this.deathmField = value;
            }
        }

        public int Age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }
    }

    public partial class Delivery : TransactionItem
    {
    }

    public partial class Commission : TransactionItem
    {
    }

    public partial class Payment : TransactionItem
    {
    }

    public partial class Order : TransactionItem
    {

        private Address shipToField;

        private Agent agentField;

        private Customer customerField;

        private List<TransactionItem> relatedItemsField;

        private int quantityField;

        private TransactionStage statusField;

        public Address ShipTo
        {
            get
            {
                return this.shipToField;
            }
            set
            {
                this.shipToField = value;
            }
        }

        public Agent Agent
        {
            get
            {
                return this.agentField;
            }
            set
            {
                this.agentField = value;
            }
        }

        public Customer Customer
        {
            get { return this.customerField; }
            set { this.customerField = value; }
        }

        public List<TransactionItem> RelatedItems
        {
            get
            {
                return this.relatedItemsField;
            }
            set
            {
                this.relatedItemsField = value;
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        public TransactionStage Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    public partial class Agent : User
    {

        private Agent parentField;

        private List<Agent> membersField;

        public Agent Parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
            }
        }

        public List<Agent> Members
        {
            get
            {
                return this.membersField;
            }
            set
            {
                this.membersField = value;
            }
        }
    }

    public enum TransactionStage
    {

        /// <remarks/>
        Order,

        /// <remarks/>
        Submit,

        /// <remarks/>
        Pay,

        /// <remarks/>
        Working,

        /// <remarks/>
        Deliver,

        /// <remarks/>
        Receive,
    }

    public partial class Transaction : DatabaseObject
    {

        private List<TransactionItem> itemsField;

        private User createdByField;

        private TransactionType typeField;

        private System.DateTime createdAtField;

        private string noField;

        private string referenceField;

        private decimal amountField;

        public List<TransactionItem> Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        public User CreatedBy
        {
            get
            {
                return this.createdByField;
            }
            set
            {
                this.createdByField = value;
            }
        }

        public TransactionType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        public System.DateTime CreatedAt
        {
            get
            {
                return this.createdAtField;
            }
            set
            {
                this.createdAtField = value;
            }
        }

        public string No
        {
            get
            {
                return this.noField;
            }
            set
            {
                this.noField = value;
            }
        }

        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    public enum TransactionType
    {

        /// <remarks/>
        Order,

        /// <remarks/>
        Payment,

        /// <remarks/>
        Commission,

        /// <remarks/>
        Delivery,
    }

    public enum Role
    {

        /// <remarks/>
        Admin,

        /// <remarks/>
        Designer,

        /// <remarks/>
        Agent,

        /// <remarks/>
        Carrier,

        /// <remarks/>
        Customer,
    }

    public partial class Admin : User
    {
    }

    public partial class Carrier : User
    {
    }

    public partial class Designer : User
    {
    }
}