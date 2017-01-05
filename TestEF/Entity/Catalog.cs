using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestEF.Util;

namespace TestEF
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
