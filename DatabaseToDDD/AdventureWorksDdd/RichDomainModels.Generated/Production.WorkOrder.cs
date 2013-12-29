namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class WorkOrder
		{
			public virtual int WorkOrderID { get; set; } 
			public virtual ProductionSchema.Product Product { get; set; } 
			public virtual int OrderQty { get; set; } 
			public virtual int StockedQty { get; set; } 
			public virtual short ScrappedQty { get; set; } 
			public virtual System.DateTime StartDate { get; set; } 
			public virtual System.DateTime? EndDate { get; set; } // Optional
			public virtual System.DateTime DueDate { get; set; } 
			public virtual ProductionSchema.ScrapReason ScrapReason { get; set; } // Optional
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // WorkOrder
	}// Production Schema
}	

