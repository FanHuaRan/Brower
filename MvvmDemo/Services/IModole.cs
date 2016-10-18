using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDemo.Services
{
    interface IModole<T>
    {
        List<T> GetList();
        List<T> GetSqlList(string strSql);
        Dictionary<string, string> GetDictionary(List<T> list);
        bool InsertoDb(T obj);
        void DeleteAll();
        void DeleteSql(string strSql);
    }
}
