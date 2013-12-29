namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PurchasingSchema
	{
		public partial class Vendor
		{
			public virtual PersonSchema.BusinessEntity BusinessEntity { get; set; } 
			public virtual string AccountNumber { get; set; } 
			public virtual string Name { get; set; } 
			public virtual byte CreditRating { get; set; } 
			public virtual bool PreferredVendorStatus { get; set; } 
			public virtual bool ActiveFlag { get; set; } 
			public virtual string PurchasingWebServiceURL { get; set; } // Optional
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // Vendor
	}// Purchasing Schema
}	

