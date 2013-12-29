namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PersonSchema
	{
		public partial class PhoneNumberType
		{
			public virtual int PhoneNumberTypeID { get; set; } 
			public virtual string Name { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // PhoneNumberType
	}// Person Schema
}	

