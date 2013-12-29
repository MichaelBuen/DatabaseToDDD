namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class dboSchema
	{
		public partial class DatabaseLog
		{
			public virtual int DatabaseLogID { get; set; } 
			public virtual System.DateTime PostTime { get; set; } 
			public virtual string DatabaseUser { get; set; } 
			public virtual string Event { get; set; } 
			public virtual string Schema { get; set; } // Optional
			public virtual string Object { get; set; } // Optional
			public virtual string TSQL { get; set; } 
			public virtual System.Xml.Linq.XElement XmlEvent { get; set; } 
		}
	} 
} 
