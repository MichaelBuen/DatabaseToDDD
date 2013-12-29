namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PersonSchema
	{
		public partial class ContactType
		{
			public virtual int ContactTypeID { get; set; } 
			public virtual string Name { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // ContactType
	}// Person Schema
}	

