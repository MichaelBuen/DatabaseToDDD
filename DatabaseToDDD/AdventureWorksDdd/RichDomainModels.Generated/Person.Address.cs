namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PersonSchema
	{
		public partial class Address
		{
			public virtual int AddressID { get; set; } 
			public virtual string AddressLine1 { get; set; } 
			public virtual string AddressLine2 { get; set; } // Optional
			public virtual string City { get; set; } 
			public virtual PersonSchema.StateProvince StateProvince { get; set; } 
			public virtual string PostalCode { get; set; } 
			public virtual Microsoft.SqlServer.Types.SqlGeography SpatialLocation { get; set; } // Optional
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
