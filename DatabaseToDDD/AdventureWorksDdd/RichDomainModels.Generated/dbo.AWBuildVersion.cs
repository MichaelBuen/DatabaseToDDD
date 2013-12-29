namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class dboSchema
	{
		public partial class AWBuildVersion
		{
			public virtual byte SystemInformationID { get; set; } 
			public virtual string DatabaseVersion { get; set; } 
			public virtual System.DateTime VersionDate { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // AWBuildVersion
	}// dbo Schema
}	

