namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PersonSchema
	{
		public partial class CountryRegion
		{
			public virtual string CountryRegionCode { get; set; } 
			public virtual string Name { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // CountryRegion
	}// Person Schema
}	

