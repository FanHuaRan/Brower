using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleMvvmToolkit;
namespace MvvmDemo
{
    public  class BookMark:ModelBase<BookMark>
    {
        private int _bookMarkId;
        private string _url;
        private string _title;
        private int _catalogId;

        public int BookMarkID
        {
            get
            {
                return _bookMarkId;
            }
            set
            {
                this._bookMarkId = value;
                NotifyPropertyChanged(p=>p.BookMarkID);
            }
        }

        public string Url
        {
            get
            {
                return _url;
            }
            set
            {
                this._url = value;
                NotifyPropertyChanged(p=>p.Url);
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                this._title = value;
                NotifyPropertyChanged(p=>p._title);
            }
        }

        public int CatalogID
        {
            get
            {
                return _catalogId;
            }
            set
            {
                this._catalogId = value;
                NotifyPropertyChanged(p=>p.CatalogID);
            }
        }

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
