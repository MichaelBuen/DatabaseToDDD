namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class SpecialOfferProduct
		{
			public virtual SalesSchema.SpecialOffer SpecialOffer { get; set; } 
			public virtual ProductionSchema.Product Product { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // SpecialOfferProduct
	}// Sales Schema
}	

