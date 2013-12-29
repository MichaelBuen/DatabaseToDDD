namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class ProductCategory
		{
			public virtual int ProductCategoryID { get; set; } 
			public virtual string Name { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // ProductCategory
	}// Production Schema
}	

