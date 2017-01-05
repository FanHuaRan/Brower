using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityWebBrowser.EntityManager;
using EntityWebBrowser.Entity;

namespace EntityWebBrowser.Services.Impl
{
    /// <summary>
    /// 历史记录服务实现
    /// 2016/12/30 fhr
    /// </summary>
    class RecordServiceClass:IRecordService
    {
        private RecordManager recordManager;
        public RecordServiceClass(RecordManager recordManager)
        {
            this.recordManager = recordManager;
        }
        public IList<Record> FindRecords()
        {
            return this.recordManager.FindAll();
        }

        public void ClearRecords()
        {
            List<Record> records = this.recordManager.FindAll() as List<Record>;
            records.ForEach(p =>
            {
                this.recordManager.DeleteById(p.RecordID);
            });
        }


        public void DeleteRecordByTitle(string title)
        {
            var records = recordManager.FindByTitle(title);
            foreach (var record in records)
            {
                DeleteRecordById(record.RecordID);
            }
        }


        public void DeleteRecordById(long id)
        {
            recordManager.DeleteById(id);
        }


        public Record InsertRecord(Record record)
        {
            return recordManager.Insert(record);
        }
    }
}
