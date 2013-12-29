namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class UnitMeasure
		{
			public virtual string UnitMeasureCode { get; set; } 
			public virtual string Name { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // UnitMeasure
	}// Production Schema
}	

