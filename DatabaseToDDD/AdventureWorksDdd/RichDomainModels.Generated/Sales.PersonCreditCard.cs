namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class PersonCreditCard
		{
			public virtual PersonSchema.Person BusinessEntity { get; set; } 
			public virtual SalesSchema.CreditCard CreditCard { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
