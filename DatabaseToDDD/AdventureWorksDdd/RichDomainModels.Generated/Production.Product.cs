namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class Product
		{
			public virtual int ProductID { get; set; } 
			public virtual string Name { get; set; } 
			public virtual string ProductNumber { get; set; } 
			public virtual bool MakeFlag { get; set; } 
			public virtual bool FinishedGoodsFlag { get; set; } 
			public virtual string Color { get; set; } // Optional
			public virtual short SafetyStockLevel { get; set; } 
			public virtual short ReorderPoint { get; set; } 
			public virtual decimal StandardCost { get; set; } 
			public virtual decimal ListPrice { get; set; } 
			public virtual string Size { get; set; } // Optional
			public virtual ProductionSchema.UnitMeasure SizeUnitMeasure { get; set; } // Optional
			public virtual ProductionSchema.UnitMeasure WeightUnitMeasure { get; set; } // Optional
			public virtual decimal? Weight { get; set; } // Optional
			public virtual int DaysToManufacture { get; set; } 
			public virtual string ProductLine { get; set; } // Optional
			public virtual string Class { get; set; } // Optional
			public virtual string Style { get; set; } // Optional
			public virtual ProductionSchema.ProductSubcategory ProductSubcategory { get; set; } // Optional
			public virtual ProductionSchema.ProductModel ProductModel { get; set; } // Optional
			public virtual System.DateTime SellStartDate { get; set; } 
			public virtual System.DateTime? SellEndDate { get; set; } // Optional
			public virtual System.DateTime? DiscontinuedDate { get; set; } // Optional
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
