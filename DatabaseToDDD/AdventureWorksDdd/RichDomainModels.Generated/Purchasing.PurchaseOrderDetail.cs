namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PurchasingSchema
	{
		public partial class PurchaseOrderDetail
		{
			public virtual PurchasingSchema.PurchaseOrderHeader PurchaseOrder { get; set; } 
			public virtual int PurchaseOrderDetailID { get; set; } 
			public virtual System.DateTime DueDate { get; set; } 
			public virtual short OrderQty { get; set; } 
			public virtual ProductionSchema.Product Product { get; set; } 
			public virtual decimal UnitPrice { get; set; } 
			public virtual decimal LineTotal { get; set; } 
			public virtual decimal ReceivedQty { get; set; } 
			public virtual decimal RejectedQty { get; set; } 
			public virtual decimal StockedQty { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // PurchaseOrderDetail
	}// Purchasing Schema
}	

