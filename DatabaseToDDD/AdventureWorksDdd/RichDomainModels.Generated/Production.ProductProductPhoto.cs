namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class ProductProductPhoto
		{
			public virtual ProductionSchema.Product Product { get; set; } 
			public virtual ProductionSchema.ProductPhoto ProductPhoto { get; set; } 
			public virtual bool Primary { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
