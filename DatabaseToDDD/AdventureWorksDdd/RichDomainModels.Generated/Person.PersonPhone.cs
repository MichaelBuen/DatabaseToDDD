namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PersonSchema
	{
		public partial class PersonPhone
		{
			public virtual PersonSchema.Person BusinessEntity { get; set; } 
			public virtual string PhoneNumber { get; set; } 
			public virtual PersonSchema.PhoneNumberType PhoneNumberType { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // PersonPhone
	}// Person Schema
}	

