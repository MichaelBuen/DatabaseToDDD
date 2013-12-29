namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class PurchasingSchema
	{
		public partial class ProductVendor
		{
			public virtual ProductionSchema.Product Product { get; set; } 
			public virtual PurchasingSchema.Vendor BusinessEntity { get; set; } 
			public virtual int AverageLeadTime { get; set; } 
			public virtual decimal StandardPrice { get; set; } 
			public virtual decimal? LastReceiptCost { get; set; } // Optional
			public virtual System.DateTime? LastReceiptDate { get; set; } // Optional
			public virtual int MinOrderQty { get; set; } 
			public virtual int MaxOrderQty { get; set; } 
			public virtual int? OnOrderQty { get; set; } // Optional
			public virtual ProductionSchema.UnitMeasure UnitMeasure { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
