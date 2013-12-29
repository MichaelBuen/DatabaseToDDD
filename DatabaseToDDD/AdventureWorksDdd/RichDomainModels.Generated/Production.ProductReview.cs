namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class ProductReview
		{
			public virtual int ProductReviewID { get; set; } 
			public virtual ProductionSchema.Product Product { get; set; } 
			public virtual string ReviewerName { get; set; } 
			public virtual System.DateTime ReviewDate { get; set; } 
			public virtual string EmailAddress { get; set; } 
			public virtual int Rating { get; set; } 
			public virtual string Comments { get; set; } // Optional
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // ProductReview
	}// Production Schema
}	

