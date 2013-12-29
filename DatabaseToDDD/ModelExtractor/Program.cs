

using ServiceStack.OrmLite;


namespace ModelExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbFactory = new OrmLiteConnectionFactory(Constants.ConnectionString, SqlServerDialect.Provider);

            using (var db = dbFactory.OpenDbConnection())
            {
                //var list = db.SqlList<EntityAssociation>(Constants.AssociationQuery);

                //foreach (var item in list)
                //{
                //    Console.WriteLine("{0} {1}", item.ForeignSchemaName, item.ForeignTableName);
                //}

                //var list = db.SqlList<Table>(Constants.TableQuery);

                //foreach (var item in list)
                //{
                //    Console.WriteLine("{0} {1}", item.TableSchema, item.TableName);
                //}


                var list = db.SqlList<Column>(Constants.ColumnQuery);

                foreach (var item in list)
                {
                    System.Console.WriteLine("{0} {1} {2} {3} {4}", item.TableSchema, item.TableName, item.ColumnName, item.CSharpFullTypeAsString, item.IsNullable);
                }


            }


            System.Console.ReadKey();
        }
    }


    public static class TheModelExtractor
    {

    }

    public class Table
    {
        // public System.Nullable<System.Int32> Hey { get; set; }
        public string TableSchema { get; set; }
        public string TableName { get; set; }
    }

    public class Column
    {
        public string TableSchema { get; set; }
        public string TableName { get; set; }
        
        public string ColumnName { get; set; }        
        public string DataType { get; set; }

        public bool IsNullable { get; set; }

        public System.Type DotNetType
        {
            get
            {
                switch (DataType)
                {
                    case "bit":
                        return typeof(bool);
                    
                    case "decimal":
                    case "numeric":
                    case "money":
                    case "smallmoney":
                        return typeof(decimal);

                    case "bigint":
                        return typeof(long);
                    case "int":
                        return typeof(int);
                    case "smallint":
                        return typeof(short);
                    case "tinyint":
                        return typeof(byte); // http://msdn.microsoft.com/en-us/library/cc716729(v=vs.110).aspx

                    case "float":
                        return typeof(double);
                    case "real":
                        return typeof(float);

                    case "nvarchar":
                    case "varchar": 
                    case "nchar":
                    case "char":
                    case "ntext":
                        return typeof(string);

                    case "date":
                    case "datetime":
                    case "datetime2":
                    case "smalldatetime":
                    case "time":
                        return typeof(System.DateTime);

                    case "datetimeoffset":
                        return typeof(System.DateTimeOffset);
                    
                    case "varbinary":
                    case "binary":
                    case "image":
                    case "rowversion":
                    case "timestamp":
                        return typeof(byte[]);

                    case "uniqueidentifier":
                        return typeof(System.Guid);

                    case "xml":
                        return typeof(System.Xml.Linq.XElement);

                    case "hierarchyid": // struct
                        // http://stackoverflow.com/questions/12094408/what-native-dotnet-data-type-is-most-appropriate-for-conveying-sql-server-hierar
                        // http://stackoverflow.com/questions/1204520/why-is-there-no-equivalent-for-hierarchyid-sql-data-type"
                        
                        return typeof(Microsoft.SqlServer.Types.SqlHierarchyId);

                    case "geography": // class

                        return typeof(Microsoft.SqlServer.Types.SqlGeography);


                    default:
                        throw new System.Exception(string.Format("Type not recognized: {0}", DataType));
                }
            }            
        }// .NET type


        public string DotNetFullTypeAsString
        {
            get
            {
                string type = DotNetType.ToString();

                if (IsNullable && DotNetType.IsValueType)
                    type = "System.Nullable<" + type + ">";

                return type;
            }
        }

        public System.Type DotNetFullType
        {
            get
            {
                // http://stackoverflow.com/questions/108104/how-do-i-convert-a-system-type-to-its-nullable-version

                if (IsNullable && DotNetType.IsValueType)
                    return typeof(System.Nullable<>).MakeGenericType(DotNetType);
                else
                    return DotNetType;

            }
        }

        public string CSharpTypeAsString
        {
            get
            {
                string type = DotNetType.ToString();

                if (DotNetType == typeof(bool))
                    type = "bool";

                else if (DotNetType == typeof(decimal))
                    type = "decimal";

                else if (DotNetType == typeof(long))
                    type = "long";
                else if (DotNetType == typeof(int))
                    type = "int";
                else if (DotNetType == typeof(short))
                    type = "short";
                else if (DotNetType == typeof(byte))
                    type = "byte";

                else if (DotNetType == typeof(double))
                    type = "double";
                else if (DotNetType == typeof(float))
                    type = "float";

                else if (DotNetType == typeof(string))
                    type = "string";

                else if (DotNetType == typeof(System.DateTime))
                    type = DotNetType.ToString();

                else if (DotNetType == typeof(System.DateTimeOffset))
                    type = DotNetType.ToString();

                else if (DotNetType == typeof(byte[]))
                    type = "byte[]";

                else if (DotNetType == typeof(System.Guid))
                    type = DotNetType.ToString();

                else if (DotNetType == typeof(System.Xml.Linq.XElement))
                    type = DotNetType.ToString();

                else if (DotNetType == typeof(Microsoft.SqlServer.Types.SqlHierarchyId))
                    type = DotNetType.ToString();

                else if (DotNetType == typeof(Microsoft.SqlServer.Types.SqlGeography))
                    type = DotNetType.ToString();

                else
                    throw new System.Exception(string.Format("Unknown type: {0}", DotNetType));


                return type;
            }
        }


        public string CSharpFullTypeAsString
        {
            get
            {
                return CSharpTypeAsString + (IsNullable && DotNetType.IsValueType ? "?" : "");
            }
        }
        
    }

    public class EntityAssociation
    {

        public string ForeignSchemaName { get; set; }
        public string ForeignConstraintName { get; set; }
        public string ForeignTableName { get; set; }
        public string ForeignColumnName { get; set; }
        public int ForeignOrdinalPosition { get; set; }

        public string ReferencedSchemaName { get; set; }
        public string ReferencedConstraintName { get; set; }
        public string ReferencedTableName { get; set; }
        public string ReferencedColumnName { get; set; }
        public int ReferencedOrdinalPosition { get; set; }
    }


    static class Constants
    {
        public const string ConnectionString = "Application Name=DEV-ITMS;Data Source=.;Initial Catalog=AdventureWorks2012;Connect Timeout=360;Integrated Security=SSPI;";

        public const string TableQuery = "select TableSchema = TABLE_SCHEMA, TableName = TABLE_NAME from INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";

        public const string ColumnQuery =
@"

select 
	TableSchema = c.TABLE_SCHEMA, 
	TableName = c.TABLE_NAME, 
	ColumnName = c.COLUMN_NAME ,
	DataType = c.DATA_TYPE,
	IsNullable = CASE WHEN IS_NULLABLE = 'NO' THEN CONVERT(BIT, 0) ELSE CONVERT(BIT, 1) END
from INFORMATION_SCHEMA.COLUMNS c
where exists
	(
		select null 
		from INFORMATION_SCHEMA.TABLES t
		WHERE t.TABLE_TYPE = 'BASE TABLE'
			and c.TABLE_SCHEMA = t.TABLE_SCHEMA
			and c.TABLE_NAME = t.TABLE_NAME
	)

";

        public const string AssociationQuery =
@"with a as
(
    -- http://stackoverflow.com/questions/3907879/sql-server-howto-get-foreign-key-reference-from-information-schema
	SELECT  
		ForeignTableSchema = KCU1.TABLE_SCHEMA
		,ForeignConstraintName = KCU1.CONSTRAINT_NAME
		,ForeignTableName = KCU1.TABLE_NAME 
		,ForeignColumnName = KCU1.COLUMN_NAME
		,ForeignOrdinalPosition = KCU1.ORDINAL_POSITION

		,ReferenchedSchema = KCU2.TABLE_SCHEMA
		,ReferencedConstraintName = KCU2.CONSTRAINT_NAME
		,ReferencedTableName = KCU2.TABLE_NAME 
		,ReferencedColumnName = KCU2.COLUMN_NAME
		,ReferencedOrdinalPosition = KCU2.ORDINAL_POSITION

		,cn = count(*) over(partition by KCU1.CONSTRAINT_NAME)

		,GetFirstOnly = ROW_NUMBER() OVER(PARTITION BY KCU1.TABLE_NAME, KCU1.COLUMN_NAME ORDER BY KCU1.TABLE_NAME, KCU1.COLUMN_NAME)

	FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS AS RC 

	INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS KCU1 
		ON KCU1.CONSTRAINT_CATALOG = RC.CONSTRAINT_CATALOG  
		AND KCU1.CONSTRAINT_SCHEMA = RC.CONSTRAINT_SCHEMA 
		AND KCU1.CONSTRAINT_NAME = RC.CONSTRAINT_NAME 

	INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS KCU2 
		ON KCU2.CONSTRAINT_CATALOG = RC.UNIQUE_CONSTRAINT_CATALOG  
		AND KCU2.CONSTRAINT_SCHEMA = RC.UNIQUE_CONSTRAINT_SCHEMA 
		AND KCU2.CONSTRAINT_NAME = RC.UNIQUE_CONSTRAINT_NAME 
		AND KCU2.ORDINAL_POSITION = KCU1.ORDINAL_POSITION 


)
select *  from a 
where cn = 1 -- and fk_table_name <> referenced_table_name
order by ForeignTableName, ForeignConstraintName, ForeignOrdinalPosition
";


    }

}
