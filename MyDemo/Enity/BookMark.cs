using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDemo.Enity
{
    public  class BookMark
    {
        public int BookMarkID { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public int CatalogID { get; set; }

        public BookMark()
        {
            
        }
        public BookMark(int id,string url,string title,int catalogId)
        {
            this.BookMarkID = id;
            this.Url = url;
            this.Title = title;
            this.CatalogID = catalogId;
        }
    }
}
