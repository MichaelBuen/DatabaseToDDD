namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class SalesPerson
		{
			public virtual HumanResourcesSchema.Employee BusinessEntity { get; set; } 
			public virtual SalesSchema.SalesTerritory Territory { get; set; } // Optional
			public virtual decimal? SalesQuota { get; set; } // Optional
			public virtual decimal Bonus { get; set; } 
			public virtual decimal CommissionPct { get; set; } 
			public virtual decimal SalesYTD { get; set; } 
			public virtual decimal SalesLastYear { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // SalesPerson
	}// Sales Schema
}	

