using EntityWebBrowser.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityWebBrowser.Entity
{
    public class Catalog
    {
         [PrimaryKeyAttribute]
        public Int64  CatalogID { get; set; }
        public string CatalogName { get; set; }
        public Catalog()
        {
            
        }

        public Catalog(Int64 catalogId, string catalogName)
        {
            this.CatalogID = catalogId;
            this.CatalogName = catalogName;
        }
    }
}
