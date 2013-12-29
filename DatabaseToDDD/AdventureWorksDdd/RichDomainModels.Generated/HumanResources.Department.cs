namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class HumanResourcesSchema
	{
		public partial class Department
		{
			public virtual short DepartmentID { get; set; } 
			public virtual string Name { get; set; } 
			public virtual string GroupName { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
