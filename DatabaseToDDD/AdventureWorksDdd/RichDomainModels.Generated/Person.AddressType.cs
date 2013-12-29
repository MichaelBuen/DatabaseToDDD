namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PersonSchema
	{
		public partial class AddressType
		{
			public virtual int AddressTypeID { get; set; } 
			public virtual string Name { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
