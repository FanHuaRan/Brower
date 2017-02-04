using EntityWebBrowser.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWebBrowser.EntityManager
{
    /// <summary>
    /// 浏览记录访问管理类
    /// 2016/12/26 fhr
    /// </summary>
    class RecordManager : EntityBaseService<Record>, IEntityService<Record>
    {
        public IList<Record> FindByTitle(string title)
        {
            return this.context.Records.Where(p => p.Title == title).ToList<Record>();
        }
        private RecordManager()
            : base()
        {

        }
        private static RecordManager instance = null;
        public static RecordManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RecordManager();
                }
                return instance;
            }
        }
    }
}
