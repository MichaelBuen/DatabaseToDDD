namespace AdventureWorksDdd.RichDomainModels
{	
	public static partial class HumanResourcesSchema
	{
		public partial class Employee
		{
			public virtual PersonSchema.Person BusinessEntity { get; set; } 
			public virtual string NationalIDNumber { get; set; } 
			public virtual string LoginID { get; set; } 
			public virtual Microsoft.SqlServer.Types.SqlHierarchyId? OrganizationNode { get; set; } // Optional
			public virtual short? OrganizationLevel { get; set; } // Optional
			public virtual string JobTitle { get; set; } 
			public virtual System.DateTime BirthDate { get; set; } 
			public virtual string MaritalStatus { get; set; } 
			public virtual string Gender { get; set; } 
			public virtual System.DateTime HireDate { get; set; } 
			public virtual bool SalariedFlag { get; set; } 
			public virtual short VacationHours { get; set; } 
			public virtual short SickLeaveHours { get; set; } 
			public virtual bool CurrentFlag { get; set; } 
			public virtual System.Guid rowguid { get; set; } 
			public virtual System.DateTime ModifiedDate { get; set; } 
		} // Employee
	}// HumanResources Schema
}	

