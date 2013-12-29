namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class HumanResourcesSchema
	{
		public partial class EmployeeDepartmentHistory
		{
			public virtual HumanResourcesSchema.Employee BusinessEntity { get; set; } 
			public virtual HumanResourcesSchema.Department Department { get; set; } 
			public virtual HumanResourcesSchema.Shift Shift { get; set; } 
			public virtual System.DateTime StartDate { get; set; } 
			public virtual System.DateTime? EndDate { get; set; } // Optional
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
