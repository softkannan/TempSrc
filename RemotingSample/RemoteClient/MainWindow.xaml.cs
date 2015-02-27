using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TSQL2015;

namespace RemoteClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        CancellationTokenSource cancelSrc = new CancellationTokenSource();

        ViewModel fullViewModel;

        IWCFService wcfSrv;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fullViewModel = new ViewModel(cancelSrc);

            DataContext = fullViewModel;


            IDictionary props = new Hashtable();
            props["port"] = 0;
            props["typeFilterLevel"] = TypeFilterLevel.Full;

            var tcpChan = new System.Runtime.Remoting.Channels.Tcp.TcpChannel(props, new BinaryClientFormatterSinkProvider(),new BinaryServerFormatterSinkProvider() { TypeFilterLevel = TypeFilterLevel.Full});


            ChannelServices.RegisterChannel(tcpChan, false);

            wcfSrv = Activator.GetObject(typeof(IWCFService), "tcp://localhost:6999/wcfservice") as IWCFService;

            //var endPoint = new EndpointAddress("net.tcp://localhost:8734/jojoserv");

            //var binding = new NetTcpBinding();

            //var chanFact = new ChannelFactory<IWCFService>(binding, endPoint);

            //wcfSrv = chanFact.CreateChannel();

            wcfSrv.InitUpsync(fullViewModel as IWCFCallBack);

            wcfSrv.Trigger();
            //List<Task<int>> listOfTasks = new List<Task<int>>();

            //for (int index = 0; index < 10; index++)
            //{
            //    listOfTasks.Add(Task.Factory.StartNew<int>(a => { 
            //        Thread.Sleep(500);
            //        return (int)a;
            //    }, index));
            //}

            //foreach (var item in listOfTasks)
            //{
            //    item.ContinueWith((f) => listOut.Items.Add(string.Format("Test {0}", f.Result)), TaskScheduler.FromCurrentSynchronizationContext());
            //}
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            cancelSrc.Cancel();

            wcfSrv.Cancel();
        }



    }

    public class ViewModel : MarshalByRefObject, IWCFCallBack
    {
        private object synObject = new object();

        public ViewModel(CancellationTokenSource cancelSrc)
        {
            Values = new ObservableCollection<string>();
            Values.Add(string.Format("Begin"));

            BindingOperations.EnableCollectionSynchronization(Values, synObject);

            //Task.Factory.StartNew(() =>
            //{

            //    var rnd = new Random();

            //    while(true)
            //    {
            //        if(cancelSrc.IsCancellationRequested)
            //        {
            //            break;
            //        }
            //        Values.Add(string.Format("{0}", rnd.Next(1, 100)));
            //        Thread.Sleep(100);
            //    }

            //}, cancelSrc.Token);
        }
        public bool AddResult(DoubleResult result)
        {
            Values.Add(string.Format("RID : {0} Site : {1} Value  : {2}", result.RID, result.Site, result.Value));

            return true;
        }
        public bool AddError(string error)
        {
            Values.Add(string.Format("Error  : {0}", error));

            return true;
        }

        public ObservableCollection<string> Values { get; set; }
    }
}
