namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PersonSchema
	{
		public partial class Person
		{
			public virtual PersonSchema.BusinessEntity BusinessEntity { get; set; } 
			public virtual string PersonType { get; set; } 
			public virtual bool NameStyle { get; set; } 
			public virtual string Title { get; set; } // Optional
			public virtual string FirstName { get; set; } 
			public virtual string MiddleName { get; set; } // Optional
			public virtual string LastName { get; set; } 
			public virtual string Suffix { get; set; } // Optional
			public virtual int EmailPromotion { get; set; } 
			public virtual System.Xml.Linq.XElement AdditionalContactInfo { get; set; } // Optional
			public virtual System.Xml.Linq.XElement Demographics { get; set; } // Optional
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // Person
	}// Person Schema
}	

