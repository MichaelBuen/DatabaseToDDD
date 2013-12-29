namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class ProductModelProductDescriptionCulture
		{
			public virtual ProductionSchema.ProductModel ProductModel { get; set; } 
			public virtual ProductionSchema.ProductDescription ProductDescription { get; set; } 
			public virtual ProductionSchema.Culture Culture { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
