using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public class History
    {
        public DateTime time;
        public string Title;
        public string Url;

        public History(string time1, string Title1, string Url1)
        {
            // TODO: Complete member initialization
            this.time = DateTime.Parse(time1);
            this.Title = Title1;
            this.Url = Url1;
        }
    }
}
