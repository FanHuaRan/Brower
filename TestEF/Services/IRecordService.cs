using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF.Services
{
    /// <summary>
    /// 历史记录服务
    /// 2016/12/30 fhr
    /// </summary>
    interface IRecordService
    {
        IList<Record> GetRecords();
        void ClearRecords();
    }
}
