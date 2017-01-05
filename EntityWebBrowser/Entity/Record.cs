using EntityWebBrowser.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityWebBrowser.Entity
{
    public class Record
    {
         [PrimaryKeyAttribute]
        public Int64 RecordID { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }

        public Record(Int64 recordId, string url, string title)
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
