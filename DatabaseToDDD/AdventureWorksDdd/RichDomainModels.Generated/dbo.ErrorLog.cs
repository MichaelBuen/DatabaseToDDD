namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class dboSchema
	{
		public partial class ErrorLog
		{
			public virtual int ErrorLogID { get; set; } 
			public virtual System.DateTime ErrorTime { get; set; } 
			public virtual string UserName { get; set; } 
			public virtual int ErrorNumber { get; set; } 
			public virtual int? ErrorSeverity { get; set; } // Optional
			public virtual int? ErrorState { get; set; } // Optional
			public virtual string ErrorProcedure { get; set; } // Optional
			public virtual int? ErrorLine { get; set; } // Optional
			public virtual string ErrorMessage { get; set; } 
		} // ErrorLog
	}// dbo Schema
}	

