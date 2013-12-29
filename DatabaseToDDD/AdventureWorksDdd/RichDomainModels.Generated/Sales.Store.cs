namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class Store
		{
			public virtual PersonSchema.BusinessEntity BusinessEntity { get; set; } 
			public virtual string Name { get; set; } 
			public virtual SalesSchema.SalesPerson SalesPerson { get; set; } // Optional
			public virtual System.Xml.Linq.XElement Demographics { get; set; } // Optional
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
