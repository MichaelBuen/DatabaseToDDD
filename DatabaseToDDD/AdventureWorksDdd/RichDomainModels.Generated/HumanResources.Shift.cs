namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class HumanResourcesSchema
	{
		public partial class Shift
		{
			public virtual byte ShiftID { get; set; } 
			public virtual string Name { get; set; } 
			public virtual System.DateTime StartTime { get; set; } 
			public virtual System.DateTime EndTime { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // Shift
	}// HumanResources Schema
}	

