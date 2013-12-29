namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class ProductionSchema
	{
		public partial class ProductPhoto
		{
			public virtual int ProductPhotoID { get; set; } 
			public virtual byte[] ThumbNailPhoto { get; set; } // Optional
			public virtual string ThumbnailPhotoFileName { get; set; } // Optional
			public virtual byte[] LargePhoto { get; set; } // Optional
			public virtual string LargePhotoFileName { get; set; } // Optional
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // ProductPhoto
	}// Production Schema
}	

