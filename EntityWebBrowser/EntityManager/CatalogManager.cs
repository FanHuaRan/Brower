using EntityWebBrowser.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWebBrowser.EntityManager
{
    /// <summary>
    /// 书签目录访问管理类
    /// 2016/12/26 fhr
    /// </summary>
    class CatalogManager : EntityBaseService<Catalog>, IEntityService<Catalog>
    {
        public IList<Catalog> FindByName(string name)
        {
            return this.context.Catalogs.Where(p => p.CatalogName == name).ToList<Catalog>();
        }
    }
}
