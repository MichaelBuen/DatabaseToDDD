namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class ProductSubcategory
		{
			public virtual int ProductSubcategoryID { get; set; } 
			public virtual ProductionSchema.ProductCategory ProductCategory { get; set; } 
			public virtual string Name { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
