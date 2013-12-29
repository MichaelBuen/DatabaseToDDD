namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class Customer
		{
			public virtual int CustomerID { get; set; } 
			public virtual PersonSchema.Person Person { get; set; } // Optional
			public virtual SalesSchema.Store Store { get; set; } // Optional
			public virtual SalesSchema.SalesTerritory Territory { get; set; } // Optional
			public virtual string AccountNumber { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // Customer
	}// Sales Schema
}	

