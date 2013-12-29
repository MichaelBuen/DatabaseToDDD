namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class SalesTerritory
		{
			public virtual int TerritoryID { get; set; } 
			public virtual string Name { get; set; } 
			public virtual PersonSchema.CountryRegion CountryRegion { get; set; } 
			public virtual string Group { get; set; } 
			public virtual decimal SalesYTD { get; set; } 
			public virtual decimal SalesLastYear { get; set; } 
			public virtual decimal CostYTD { get; set; } 
			public virtual decimal CostLastYear { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
