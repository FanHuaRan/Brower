using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDemo.Services
{
    class RecordService:IModole<Record>
    {
        public List<Record> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Record> GetSqlList(string strSql)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> GetDictionary(List<Record> list)
        {
            throw new NotImplementedException();
        }

        public bool InsertoDb(Record obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteSql(string strSql)
        {
            throw new NotImplementedException();
        }
    }
}
