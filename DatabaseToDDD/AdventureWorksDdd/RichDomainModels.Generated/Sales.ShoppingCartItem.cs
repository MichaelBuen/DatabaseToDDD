namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class SalesSchema
	{
		public partial class ShoppingCartItem
		{
			public virtual int ShoppingCartItemID { get; set; } 
			public virtual string ShoppingCartID { get; set; } 
			public virtual int Quantity { get; set; } 
			public virtual ProductionSchema.Product Product { get; set; } 
			public virtual System.DateTime DateCreated { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		}
	} 
} 
