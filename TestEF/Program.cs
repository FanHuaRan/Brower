using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEF.Services;
using TestEF.Test;
namespace TestEF
{
    class Program
    {
        static void Main(string[] args)
        {

            IRecordService recordService = ServicesFactory.RecordService;
            List<Record> records = recordService.GetRecords() as List<Record>;
            records.ForEach(p => { Console.WriteLine("{0} {1} {2}", p.RecordID, p.Url, p.Title); });
            //try
            //{
            //    List<Catalog> catalogs = ContextFactory.Context.Catalogs.Select(p => p).ToList<Catalog>();
            //    foreach (var value in catalogs)
            //    {
            //        Console.WriteLine(value.CatalogName);
            //    }
            //    List<Record> records= ContextFactory.Context.Records.Select(p => p).ToList<Record>();
            //    foreach (var value in records)
            //    {
            //        Console.WriteLine(value.Title);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            BookMarkTestClass.TestGeCatalogs();
            BookMarkTestClass.TestGetBookMarks();
            BookMarkTestClass.TestGetCatalogsGroupe();
            BookMarkTestClass.TestUpdateCatalog();
            BookMarkTestClass.TestUpdateBookMark();
            BookMarkTestClass.TestInsertCatalog();
            BookMarkTestClass.TestInsertBookmark();
                     BookMarkTestClass.TestDeleteBookmark();
                     BookMarkTestClass.TestDeleteCatalog();
            Console.ReadKey();
        }
    }
}
