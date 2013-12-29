namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class SalesOrderHeader
		{
			public virtual int SalesOrderID { get; set; } 
			public virtual byte RevisionNumber { get; set; } 
			public virtual System.DateTime OrderDate { get; set; } 
			public virtual System.DateTime DueDate { get; set; } 
			public virtual System.DateTime? ShipDate { get; set; } // Optional
			public virtual byte Status { get; set; } 
			public virtual bool OnlineOrderFlag { get; set; } 
			public virtual string SalesOrderNumber { get; set; } 
			public virtual string PurchaseOrderNumber { get; set; } // Optional
			public virtual string AccountNumber { get; set; } // Optional
			public virtual SalesSchema.Customer Customer { get; set; } 
			public virtual SalesSchema.SalesPerson SalesPerson { get; set; } // Optional
			public virtual SalesSchema.SalesTerritory Territory { get; set; } // Optional
			public virtual PersonSchema.Address BillToAddress { get; set; } 
			public virtual PersonSchema.Address ShipToAddress { get; set; } 
			public virtual PurchasingSchema.ShipMethod ShipMethod { get; set; } 
			public virtual SalesSchema.CreditCard CreditCard { get; set; } // Optional
			public virtual string CreditCardApprovalCode { get; set; } // Optional
			public virtual SalesSchema.CurrencyRate CurrencyRate { get; set; } // Optional
			public virtual decimal SubTotal { get; set; } 
			public virtual decimal TaxAmt { get; set; } 
			public virtual decimal Freight { get; set; } 
			public virtual decimal TotalDue { get; set; } 
			public virtual string Comment { get; set; } // Optional
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // SalesOrderHeader
	}// Sales Schema
}	

