using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestEF.Util;

namespace TestEF.EntityManager
{
    /// <summary>
    /// 实体访问泛型基类
    /// 2016/12/26 fhr
    /// </summary>
    class EntityBaseService<T>:IEntityService<T>  where T:class
    {
        protected MyContext context = ContextFactory.Context;
        public void Delete(T obj)
        {
            context.Set<T>().Remove(obj);
            context.SaveChanges(); 
        }

        public T Insert(T obj)
        {
            try
            {
                context.Set<T>().Add(obj);
                context.SaveChanges();
                return obj;
            }
            catch
            {
                return null;
            }
        }

        public T Update(T obj)
        {
           object key= ObjectRefletUtil.GetMainKeyValue(obj);
           T oldObj = context.Set<T>().Find(key);
            if (oldObj == null)
            {
                return null;
            }
            ObjectRefletUtil.SetValue<T>(oldObj, obj);
            context.Entry<T>(oldObj).State = EntityState.Modified;
            context.SaveChanges();
            return oldObj;
        }

        public  IList<T> FindAll()
        {
            return context.Set<T>().Select(p => p).ToList<T>();
        }

        public void DeleteById(long id)
        {
            T model = FindById(id);
            if (model != null)
            {
                context.Set<T>().Remove(model);
                context.SaveChanges();
            }  
        }
        public T FindById(long id)
        {
            return context.Set<T>().Find(id);
        }
    }
}
