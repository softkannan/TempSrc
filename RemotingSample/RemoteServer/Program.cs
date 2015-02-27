using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization.Formatters;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TSQL2015;

namespace RemoteServer
{
    class OrderData
    {
        public string shipcountry { get; set; }
        public decimal avgfright { get; set; }
    }

    class ThreadInfo
    {
        public int ThreadId;
        public int JobId;
    }

    class Pipe
    {
        public volatile bool IsUsed;

        public List<ThreadInfo> Buffer = new List<ThreadInfo>();
    }

    class Pipes
    {
        Semaphore Controller = new Semaphore(3, 3);
        public List<Pipe> PipesL = new List<Pipe>() { new Pipe() { IsUsed = false }, new Pipe() { IsUsed = false }, new Pipe() { IsUsed = false } };

        public Pipe GetPipe()
        {
            Controller.WaitOne();

            lock (this)
            {
                foreach (var item in PipesL)
                {
                    if (item.IsUsed == false)
                    {
                        item.IsUsed = true;
                        return item;
                    }
                }

                throw new IndexOutOfRangeException();
            }
        }

        public void Release(Pipe pipe)
        {
            lock (this)
            {
                pipe.IsUsed = false;
            }
            Controller.Release();
        }
    }

    class ExprimentsTask
    {
        private BigInteger Factorial(BigInteger num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }

        private string DownloadPage(string url)
        {
            WebRequest request = WebRequest.Create(url);

            WebResponse response = request.GetResponse();

            var reader = new StreamReader(response.GetResponseStream());
            {
                return reader.ReadToEnd();
            }

        }

        private async Task<string> DownloadPageAsync(string url)
        {
            WebRequest request = WebRequest.Create(url);

            WebResponse response = request.GetResponse();

            var reader = new StreamReader(response.GetResponseStream());
            {
                return await reader.ReadToEndAsync();
            }
        }

        Barrier barrier = new Barrier(4, a => {

            Console.WriteLine("Barrier Reached : {0}", a.CurrentPhaseNumber);
        
        });

        private void IncrementValue(ref int value, int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                value++;
            }

            barrier.SignalAndWait();

            Console.WriteLine("Post Barrier");
        }

        
        public void Run()
        {
            
            try
            {
                AutoResetEvent autoEvent = new AutoResetEvent(false);

                ServiceImpl.FinishEvent = autoEvent;

                IDictionary props = new Hashtable();
                props["port"] = 6999;
                props["typeFilterLevel"] = TypeFilterLevel.Full;
                var tcpChan = new System.Runtime.Remoting.Channels.Tcp.TcpChannel(props,null,new BinaryServerFormatterSinkProvider() { TypeFilterLevel = TypeFilterLevel.Full});

                ChannelServices.RegisterChannel(tcpChan, false);

                RemotingConfiguration.RegisterWellKnownServiceType(typeof(ServiceImpl), "wcfservice", WellKnownObjectMode.Singleton);

                //ServiceHost srvHost = new ServiceHost(new ServiceImpl(autoEvent), new Uri("net.tcp://localhost:8734/jojoserv"));

                //srvHost.AddServiceEndpoint(typeof(IWCFService), new NetTcpBinding(), "");

                //srvHost.Open();

                Console.WriteLine("WCF Service Started");

                autoEvent.WaitOne();

                Console.WriteLine("WCF Service Stopped");
            }
            catch(Exception ex)
            {
                Console.WriteLine("WCF Service Failed : {0}", ex.Message);
            }
            //var queue = new BlockingCollection<int>(new ConcurrentQueue<int>());

            //var producer = Task.Factory.StartNew(() => {
            
            //    while(true)
            //    {
            //        queue.Add(10);
            //        Thread.Sleep(100);
            //    }
            
            //});


            //List<Task> consumers = new List<Task>();

            //for (int index = 0; index < 4; index++)
            //{
            //    consumers.Add(Task.Factory.StartNew(() =>
            //    {
            //        while (true)
            //        {
            //            var item = queue.Take();

            //            Console.WriteLine("Thread ID :{0} Value:{1}", Thread.CurrentThread.ManagedThreadId, item);
            //        }

            //    }));
            //}


            //producer.Wait();


            //const int iterations = 100000000;
            //const int numTasks = 4;
            //List<Task> tasks = new List<Task>();
            //int value = 0;
            //for (int nTask = 0; nTask < numTasks; nTask++)
            //{
            //    Task t = Task.Factory.StartNew(() =>
            //    {
            //        IncrementValue(ref value, iterations);
            //    });
            //    tasks.Add(t);
            //}
            //Task.WaitAll(tasks.ToArray());
            //Console.WriteLine("Expected value: {0}, Actual value: {1}", numTasks * iterations, value);


            //var task = Task.Factory.StartNew<string>(() => DownloadPage("http://www.rocksolidknowledge.com/5SecondPage.aspx"));

            ////var task = await DownloadPageAsync("http://www.rocksolidknowledge.com/5SecondPage.aspx");


            //while (!task.IsCompleted)
            //{
            //    Console.Write(".");
            //    Thread.Sleep(500);
            //}

            //Console.WriteLine(task.Result);


            //BigInteger n = 4900;
            //BigInteger r = 600;

            //var part1 = Task.Factory.StartNew<BigInteger>(() => Factorial(n));
            //var part2 = Task.Factory.StartNew<BigInteger>(() => Factorial(n - r));
            //var part3 = Task.Factory.StartNew<BigInteger>(() => Factorial(r));

            //var chances = part1.Result / (part2.Result * part3.Result);

            //Console.WriteLine(chances);

            //foreach(var item in new[]{1,2,3,4,5,6,7,8,9,10})
            //{
            //    Task.Factory.StartNew(() => Console.WriteLine(item));
            //}

            //Console.ReadLine();


            //var task = Task.Factory.StartNew(() =>
            //    {
            //        Console.WriteLine("ThreadPool Thread : {0}", Thread.CurrentThread.IsThreadPoolThread ? "Yes" : "No");
            //    });

            //task.Wait();
        }
    }
    class ExprimentsP
    {
        public void Run()
        {
            object synObj = new object();

            Pipes pipes = new Pipes();

            List<Task> taskList = new List<Task>();


            for (int index = 0; index < 10; index++)
            {
                taskList.Add(Task.Factory.StartNew((idx) =>
                {

                    for (int indexl = 0; indexl < 10; indexl++)
                    {
                        var pipe = pipes.GetPipe();

                        pipe.Buffer.Add(new ThreadInfo() { ThreadId = (int)idx, JobId = indexl });

                        Thread.Sleep(100);
                        pipes.Release(pipe);


                    }

                }, index));
            }

            Task.WaitAll(taskList.ToArray());
            int index1 = 0;
            foreach (var item in pipes.PipesL)
            {
                Console.WriteLine("****Pipe{0}****", index1);
                foreach (var item1 in (from t in item.Buffer orderby t.ThreadId select t))
                {
                    Console.WriteLine("Thread ID:{0} JobID:{1}", item1.ThreadId, item1.JobId);
                }
                index1++;
            }
        }

    }
    class Expriments
    {
        public void Run()
        {

            Test1();

        }

        void Test1()
        {
            using (var db = new TSQL2012Entities())
            {
                var data = db.Database.SqlQuery<OrderData>("SELECT TOP(3) O.shipcountry, AVG(O.freight) as avgfright  FROM Sales.Orders AS O where YEAR(o.shippeddate) = 2007 group by o.shipcountry order by  AVG(O.freight) desc").ToList();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExprimentsTask prg = new ExprimentsTask();

            prg.Run();
            //ExprimentsP prg = new ExprimentsP();

            //prg.Run();
        }
    }
}
