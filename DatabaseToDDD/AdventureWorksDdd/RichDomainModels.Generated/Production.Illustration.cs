namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class Illustration
		{
			public virtual int IllustrationID { get; set; } 
			public virtual System.Xml.Linq.XElement Diagram { get; set; } // Optional
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
