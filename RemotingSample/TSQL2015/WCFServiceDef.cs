using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TSQL2015
{
    public interface IWCFCallBack
    {
        bool AddResult(DoubleResult result);
        bool AddError(string error);
    }

    public interface IWCFService
    {
        void InitUpsync(IWCFCallBack upsyncSrv);
        void Trigger();
        void Cancel();
    }

    [Serializable]
    public class DoubleResult
    {
        public long RID { get; set; }
        public long Site { get; set; }
        public double Value { get; set; }
    }
}
