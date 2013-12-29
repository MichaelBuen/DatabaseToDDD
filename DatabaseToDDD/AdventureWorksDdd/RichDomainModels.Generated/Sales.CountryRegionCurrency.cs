namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class CountryRegionCurrency
		{
			public virtual PersonSchema.CountryRegion CountryRegion { get; set; } 
			public virtual SalesSchema.Currency Currency { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
