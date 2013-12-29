namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class TransactionHistory
		{
			public virtual int TransactionID { get; set; } 
			public virtual ProductionSchema.Product Product { get; set; } 
			public virtual int ReferenceOrderID { get; set; } 
			public virtual int ReferenceOrderLineID { get; set; } 
			public virtual System.DateTime TransactionDate { get; set; } 
			public virtual string TransactionType { get; set; } 
			public virtual int Quantity { get; set; } 
			public virtual decimal ActualCost { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // TransactionHistory
	}// Production Schema
}	

