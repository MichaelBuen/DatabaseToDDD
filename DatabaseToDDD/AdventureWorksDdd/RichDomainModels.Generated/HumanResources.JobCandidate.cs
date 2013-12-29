namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class HumanResourcesSchema
	{
		public partial class JobCandidate
		{
			public virtual int JobCandidateID { get; set; } 
			public virtual HumanResourcesSchema.Employee BusinessEntity { get; set; } // Optional
			public virtual System.Xml.Linq.XElement Resume { get; set; } // Optional
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
