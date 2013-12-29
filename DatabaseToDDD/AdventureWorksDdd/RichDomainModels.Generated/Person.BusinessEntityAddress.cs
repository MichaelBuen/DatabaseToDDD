namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PersonSchema
	{
		public partial class BusinessEntityAddress
		{
			public virtual PersonSchema.BusinessEntity BusinessEntity { get; set; } 
			public virtual PersonSchema.Address Address { get; set; } 
			public virtual PersonSchema.AddressType AddressType { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
