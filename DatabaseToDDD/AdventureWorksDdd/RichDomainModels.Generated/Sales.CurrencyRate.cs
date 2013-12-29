namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class CurrencyRate
		{
			public virtual int CurrencyRateID { get; set; } 
			public virtual System.DateTime CurrencyRateDate { get; set; } 
			public virtual SalesSchema.Currency FromCurrency { get; set; } 
			public virtual SalesSchema.Currency ToCurrency { get; set; } 
			public virtual decimal AverageRate { get; set; } 
			public virtual decimal EndOfDayRate { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
