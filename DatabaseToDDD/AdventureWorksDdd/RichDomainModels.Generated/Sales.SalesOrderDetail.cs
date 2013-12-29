namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class SalesOrderDetail
		{
			public virtual SalesSchema.SalesOrderHeader SalesOrder { get; set; } 
			public virtual int SalesOrderDetailID { get; set; } 
			public virtual string CarrierTrackingNumber { get; set; } // Optional
			public virtual short OrderQty { get; set; } 
			public virtual int ProductID { get; set; } 
			public virtual int SpecialOfferID { get; set; } 
			public virtual decimal UnitPrice { get; set; } 
			public virtual decimal UnitPriceDiscount { get; set; } 
			public virtual decimal LineTotal { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // SalesOrderDetail
	}// Sales Schema
}	

