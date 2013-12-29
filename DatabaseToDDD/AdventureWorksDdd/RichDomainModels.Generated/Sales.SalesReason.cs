namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class SalesReason
		{
			public virtual int SalesReasonID { get; set; } 
			public virtual string Name { get; set; } 
			public virtual string ReasonType { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
