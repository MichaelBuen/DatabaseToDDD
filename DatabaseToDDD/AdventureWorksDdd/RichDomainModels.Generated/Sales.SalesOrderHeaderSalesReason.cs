namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class SalesOrderHeaderSalesReason
		{
			public virtual SalesSchema.SalesOrderHeader SalesOrder { get; set; } 
			public virtual SalesSchema.SalesReason SalesReason { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // SalesOrderHeaderSalesReason
	}// Sales Schema
}	

