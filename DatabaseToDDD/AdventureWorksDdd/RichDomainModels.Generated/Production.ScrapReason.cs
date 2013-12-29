namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class ScrapReason
		{
			public virtual short ScrapReasonID { get; set; } 
			public virtual string Name { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // ScrapReason
	}// Production Schema
}	

