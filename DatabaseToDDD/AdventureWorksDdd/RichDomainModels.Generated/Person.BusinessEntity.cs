namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PersonSchema
	{
		public partial class BusinessEntity
		{
			public virtual int BusinessEntityID { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // BusinessEntity
	}// Person Schema
}	

