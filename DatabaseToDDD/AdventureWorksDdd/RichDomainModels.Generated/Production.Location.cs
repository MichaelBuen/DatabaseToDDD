namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class Location
		{
			public virtual short LocationID { get; set; } 
			public virtual string Name { get; set; } 
			public virtual decimal CostRate { get; set; } 
			public virtual decimal Availability { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
