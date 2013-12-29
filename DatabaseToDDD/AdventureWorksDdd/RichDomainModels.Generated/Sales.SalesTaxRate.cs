namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class SalesTaxRate
		{
			public virtual int SalesTaxRateID { get; set; } 
			public virtual PersonSchema.StateProvince StateProvince { get; set; } 
			public virtual byte TaxType { get; set; } 
			public virtual decimal TaxRate { get; set; } 
			public virtual string Name { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // SalesTaxRate
	}// Sales Schema
}	

