using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEF.EntityManager;

namespace TestEF.Services
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
        public IList<Record> GetRecords()
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
    }
}
