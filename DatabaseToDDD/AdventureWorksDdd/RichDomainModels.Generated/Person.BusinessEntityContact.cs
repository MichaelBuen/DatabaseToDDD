namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PersonSchema
	{
		public partial class BusinessEntityContact
		{
			public virtual PersonSchema.BusinessEntity BusinessEntity { get; set; } 
			public virtual PersonSchema.Person Person { get; set; } 
			public virtual PersonSchema.ContactType ContactType { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
