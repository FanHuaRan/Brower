using EntityWebBrowser.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWebBrowser.Services
{
    /// <summary>
    /// 历史记录服务
    /// 2016/12/30 fhr
    /// </summary>
    interface IRecordService
    {
        IList<Record> FindRecords();
        void ClearRecords();
        void DeleteRecordByTitle(string title);
        void DeleteRecordById(Int64 id);
        Record InsertRecord(Record record);
    }
}
