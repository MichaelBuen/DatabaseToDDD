namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class ProductCostHistory
		{
			public virtual ProductionSchema.Product Product { get; set; } 
			public virtual System.DateTime StartDate { get; set; } 
			public virtual System.DateTime? EndDate { get; set; } // Optional
			public virtual decimal StandardCost { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
