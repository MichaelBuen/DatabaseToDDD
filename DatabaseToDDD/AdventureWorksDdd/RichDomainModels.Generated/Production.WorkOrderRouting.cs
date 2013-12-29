namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class WorkOrderRouting
		{
			public virtual ProductionSchema.WorkOrder WorkOrder { get; set; } 
			public virtual int ProductID { get; set; } 
			public virtual short OperationSequence { get; set; } 
			public virtual ProductionSchema.Location Location { get; set; } 
			public virtual System.DateTime ScheduledStartDate { get; set; } 
			public virtual System.DateTime ScheduledEndDate { get; set; } 
			public virtual System.DateTime? ActualStartDate { get; set; } // Optional
			public virtual System.DateTime? ActualEndDate { get; set; } // Optional
			public virtual decimal? ActualResourceHrs { get; set; } // Optional
			public virtual decimal PlannedCost { get; set; } 
			public virtual decimal? ActualCost { get; set; } // Optional
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
