namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class Document
		{
			public virtual Microsoft.SqlServer.Types.SqlHierarchyId DocumentNode { get; set; } 
			public virtual short? DocumentLevel { get; set; } // Optional
			public virtual string Title { get; set; } 
			public virtual HumanResourcesSchema.Employee Owner { get; set; } 
			public virtual bool FolderFlag { get; set; } 
			public virtual string FileName { get; set; } 
			public virtual string FileExtension { get; set; } 
			public virtual string Revision { get; set; } 
			public virtual int ChangeNumber { get; set; } 
			public virtual byte Status { get; set; } 
			public virtual string DocumentSummary { get; set; } // Optional
			public virtual byte[] TheDocument { get; set; } // Optional
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // Document
	}// Production Schema
}	

