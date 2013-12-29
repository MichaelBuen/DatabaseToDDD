namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PersonSchema
	{
		public partial class EmailAddress
		{
			public virtual PersonSchema.Person BusinessEntity { get; set; } 
			public virtual int EmailAddressID { get; set; } 
			public virtual string TheEmailAddress { get; set; } // Optional
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
