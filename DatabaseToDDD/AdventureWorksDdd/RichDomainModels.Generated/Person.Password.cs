namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PersonSchema
	{
		public partial class Password
		{
			public virtual PersonSchema.Person BusinessEntity { get; set; } 
			public virtual string PasswordHash { get; set; } 
			public virtual string PasswordSalt { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
