namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PurchasingSchema
	{
		public partial class ShipMethod
		{
			public virtual int ShipMethodID { get; set; } 
			public virtual string Name { get; set; } 
			public virtual decimal ShipBase { get; set; } 
			public virtual decimal ShipRate { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // ShipMethod
	}// Purchasing Schema
}	

