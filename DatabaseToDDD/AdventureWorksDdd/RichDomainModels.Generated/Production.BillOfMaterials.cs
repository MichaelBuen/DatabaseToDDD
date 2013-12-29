namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class BillOfMaterials
		{
			public virtual int BillOfMaterialsID { get; set; } 
			public virtual ProductionSchema.Product ProductAssembly { get; set; } // Optional
			public virtual ProductionSchema.Product Component { get; set; } 
			public virtual System.DateTime StartDate { get; set; } 
			public virtual System.DateTime? EndDate { get; set; } // Optional
			public virtual ProductionSchema.UnitMeasure UnitMeasure { get; set; } 
			public virtual short BOMLevel { get; set; } 
			public virtual decimal PerAssemblyQty { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
