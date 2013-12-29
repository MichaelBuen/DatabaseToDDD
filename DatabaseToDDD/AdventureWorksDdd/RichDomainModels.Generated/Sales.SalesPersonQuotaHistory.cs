namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class SalesPersonQuotaHistory
		{
			public virtual SalesSchema.SalesPerson BusinessEntity { get; set; } 
			public virtual System.DateTime QuotaDate { get; set; } 
			public virtual decimal SalesQuota { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // SalesPersonQuotaHistory
	}// Sales Schema
}	

