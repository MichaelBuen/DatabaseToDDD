namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class ProductModel
		{
			public virtual int ProductModelID { get; set; } 
			public virtual string Name { get; set; } 
			public virtual System.Xml.Linq.XElement CatalogDescription { get; set; } // Optional
			public virtual System.Xml.Linq.XElement Instructions { get; set; } // Optional
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // ProductModel
	}// Production Schema
}	

