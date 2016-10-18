using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvvmDemo
{
    public class Record
    {
        public int RecordID { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }

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
