using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleMvvmToolkit;
namespace MvvmDemo
{
    public class Catalog:ModelBase<Catalog>
    {
        private int _catalogId;

        public int CatalogID
        {
            get { return _catalogId; }
            set
            {
                this._catalogId = value;
                NotifyPropertyChanged(p=>p.CatalogID);
            }
        }

        private string _catalogName;

        public string CatalogName
        {
            get { return _catalogName; }
            set
            {
                this._catalogName = value;
                NotifyPropertyChanged(p=>p.CatalogName);
            }
        }

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
