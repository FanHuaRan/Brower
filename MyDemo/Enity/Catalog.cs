using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDemo.Enity
{
    public class Catalog
    {
        public int  CatalogID { get; set; }
        public string CatalogName { get; set; }
        public Catalog()
        {
            
        }

        public Catalog(int catalogId, string catalogName)
        {
            this.CatalogID = catalogId;
            this.CatalogName = catalogName;
        }
    }
}
