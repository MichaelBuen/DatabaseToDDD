namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PurchasingSchema
	{
		public partial class PurchaseOrderHeader
		{
			public virtual int PurchaseOrderID { get; set; } 
			public virtual byte RevisionNumber { get; set; } 
			public virtual byte Status { get; set; } 
			public virtual HumanResourcesSchema.Employee Employee { get; set; } 
			public virtual PurchasingSchema.Vendor Vendor { get; set; } 
			public virtual PurchasingSchema.ShipMethod ShipMethod { get; set; } 
			public virtual System.DateTime OrderDate { get; set; } 
			public virtual System.DateTime? ShipDate { get; set; } // Optional
			public virtual decimal SubTotal { get; set; } 
			public virtual decimal TaxAmt { get; set; } 
			public virtual decimal Freight { get; set; } 
			public virtual decimal TotalDue { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // PurchaseOrderHeader
	}// Purchasing Schema
}	

