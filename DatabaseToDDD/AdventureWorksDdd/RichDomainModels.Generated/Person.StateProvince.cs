namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PersonSchema
	{
		public partial class StateProvince
		{
			public virtual int StateProvinceID { get; set; } 
			public virtual string StateProvinceCode { get; set; } 
			public virtual PersonSchema.CountryRegion CountryRegion { get; set; } 
			public virtual bool IsOnlyStateProvinceFlag { get; set; } 
			public virtual string Name { get; set; } 
			public virtual SalesSchema.SalesTerritory Territory { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
