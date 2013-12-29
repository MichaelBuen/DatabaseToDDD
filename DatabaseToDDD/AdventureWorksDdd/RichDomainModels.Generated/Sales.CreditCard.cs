namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class CreditCard
		{
			public virtual int CreditCardID { get; set; } 
			public virtual string CardType { get; set; } 
			public virtual string CardNumber { get; set; } 
			public virtual byte ExpMonth { get; set; } 
			public virtual short ExpYear { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
