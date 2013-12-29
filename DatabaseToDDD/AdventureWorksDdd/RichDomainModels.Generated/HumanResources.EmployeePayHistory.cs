namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class HumanResourcesSchema
	{
		public partial class EmployeePayHistory
		{
			public virtual HumanResourcesSchema.Employee BusinessEntity { get; set; } 
			public virtual System.DateTime RateChangeDate { get; set; } 
			public virtual decimal Rate { get; set; } 
			public virtual byte PayFrequency { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
