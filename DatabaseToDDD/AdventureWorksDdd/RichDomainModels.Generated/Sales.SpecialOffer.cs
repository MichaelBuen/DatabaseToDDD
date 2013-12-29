namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class SpecialOffer
		{
			public virtual int SpecialOfferID { get; set; } 
			public virtual string Description { get; set; } 
			public virtual decimal DiscountPct { get; set; } 
			public virtual string Type { get; set; } 
			public virtual string Category { get; set; } 
			public virtual System.DateTime StartDate { get; set; } 
			public virtual System.DateTime EndDate { get; set; } 
			public virtual int MinQty { get; set; } 
			public virtual int? MaxQty { get; set; } // Optional
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // SpecialOffer
	}// Sales Schema
}	

