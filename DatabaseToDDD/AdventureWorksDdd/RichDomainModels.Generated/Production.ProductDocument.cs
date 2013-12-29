namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class ProductDocument
		{
			public virtual ProductionSchema.Product Product { get; set; } 
			public virtual ProductionSchema.Document DocumentNode { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // ProductDocument
	}// Production Schema
}	

