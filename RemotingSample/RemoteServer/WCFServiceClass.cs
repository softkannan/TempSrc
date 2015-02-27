using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using TSQL2015;

namespace RemoteServer
{
    public class ServiceImpl : MarshalByRefObject, IWCFService
    {
        IWCFCallBack wcfCallBack;
        CancellationTokenSource cancelSrc = new CancellationTokenSource();
        static public AutoResetEvent FinishEvent { get; set; }

        public ServiceImpl()
        {
        }
        public override object InitializeLifetimeService()
        {
            return null;
        }

        public void InitUpsync(IWCFCallBack upsyncSrv)
        {
            this.wcfCallBack = upsyncSrv;
        }

        public void Trigger()
        {
            Task.Factory.StartNew(() =>
            {

                var rndRID = new Random();
                var rndSite = new Random();
                var rndValue = new Random();

                while(true)
                {
                    if (cancelSrc.IsCancellationRequested)
                    {
                        break;
                    }
                    wcfCallBack.AddResult(new DoubleResult() { RID = rndRID.Next(1, 1000), Site = rndSite.Next(1, 255), Value = rndValue.Next(1, 2000) });
                    Thread.Sleep(100);
                }
            
            }, cancelSrc.Token);
        }

        public void Cancel()
        {
            cancelSrc.Cancel();
            FinishEvent.Set();
        }
    }
}
