using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestEF.Util;
namespace TestEF
{
    public  class BookMark
    {
        [PrimaryKeyAttribute]
        public Int64 BookMarkID { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public Nullable<Int64> CatalogID { get; set; }

        public BookMark()
        {
            
        }
        public BookMark(Int64 id, string url, string title, Nullable<Int64> catalogId)
        {
            this.BookMarkID = id;
            this.Url = url;
            this.Title = title;
            this.CatalogID = catalogId;
        }
        public BookMark(string url, string title, Nullable<Int64> catalogId)
        {
            this.Url = url;
            this.Title = title;
            this.CatalogID = catalogId;
        }
    }
}
