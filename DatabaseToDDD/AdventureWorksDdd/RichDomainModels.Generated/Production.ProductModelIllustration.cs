namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class ProductModelIllustration
		{
			public virtual ProductionSchema.ProductModel ProductModel { get; set; } 
			public virtual ProductionSchema.Illustration Illustration { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
