namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class ProductInventory
		{
			public virtual ProductionSchema.Product Product { get; set; } 
			public virtual ProductionSchema.Location Location { get; set; } 
			public virtual string Shelf { get; set; } 
			public virtual byte Bin { get; set; } 
			public virtual short Quantity { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
