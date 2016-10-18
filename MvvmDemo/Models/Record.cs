using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleMvvmToolkit;
namespace MvvmDemo
{
    public class Record:ModelBase<Record>
    {
        private int _recordId;
        private string _url;
        private string _title;
        public int RecordID
        {
            get
            {
                return _recordId;
            }
            set
            {
                this._recordId = value;
                NotifyPropertyChanged(p=>p.RecordID);
            }
        }

        public string Url
        {
            get { return _url; }
            set
            {
                this._url = value;
                NotifyPropertyChanged(p => p.Url);
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                this._title = value;
                NotifyPropertyChanged(p=>p.Title);
            }
        }

        public Record(int recordId, string url, string title)
        {
            this.RecordID = recordId;
            this.Url = url;
            this.Title = title;
        }
        public Record()
        {
            
        }
    }
}
