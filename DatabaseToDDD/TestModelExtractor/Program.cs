using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModelExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dbFactory = new OrmLiteConnectionFactory(Constants.ConnectionString, SqlServerDialect.Provider);

            //using (var db = dbFactory.OpenDbConnection())
            //{
            //    //var list = db.SqlList<EntityAssociation>(Constants.AssociationQuery);

            //    //foreach (var item in list)
            //    //{
            //    //    Console.WriteLine("{0} {1}", item.ForeignSchemaName, item.ForeignTableName);
            //    //}

            //    //var list = db.SqlList<Table>(Constants.TableQuery);

            //    //foreach (var item in list)
            //    //{
            //    //    Console.WriteLine("{0} {1}", item.TableSchema, item.TableName);
            //    //}


            //    //var list = db.SqlList<Column>(Constants.ColumnQuery);

            //    //foreach (var item in list)
            //    //{
            //    //    System.Console.WriteLine("{0} {1} {2} {3} {4}", item.TableSchema, item.TableName, item.ColumnName, item.CSharpFullTypeAsString, item.IsNullable);
            //    //}


            //}

            foreach (var item in ModelExtractor.TheModelExtractor.GetTables())
            {
                Console.WriteLine("{0}", item.TableName);
            }


            System.Console.ReadKey();
        }
    }

}
