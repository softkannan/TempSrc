using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
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

namespace WCFServer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static MainWindow LogList {  get;  set; }

        Action<string> logMsg;
       
        public MainWindow()
        {
            InitializeComponent();

            logMsg = (msg) => { this.logList.Items.Add(msg); };
        }

        public static void LogMsg(string msg)
        {
            LogList.LogMsgInnner(msg);
        }

        ServiceHost srvHost;
        ServiceHost srvCallbackHost;

        private async void LogMsgInnner(string msg)
        {
            await this.Dispatcher.BeginInvoke(logMsg, msg);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            srvHost.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            LogList = this;

            srvHost = new ServiceHost(typeof(WCFSample));
            srvCallbackHost = new ServiceHost(typeof(WCFCallBackServiceImpl));

            try
            {
                srvCallbackHost.Open();
            }
            catch (Exception ex)
            {

            }

            try
            {
                srvHost.Open();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
