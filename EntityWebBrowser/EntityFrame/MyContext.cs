using EntityWebBrowser.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWebBrowser.EntityFrame
{
    /// <summary>
    /// 实体框架上下文
    /// 2016/12/26 fhr
    /// </summary>
    class MyContext :DbContext
    {
        public DbSet<BookMark> BookMarks { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Record> Records { get; set; }
        public MyContext()
            : base("pageConnect")
        {

        }
    }
}
