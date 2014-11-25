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
        public static ListBox LogList { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        ServiceHost srvHost;

        private void Window_Closed(object sender, EventArgs e)
        {
            srvHost.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            LogList = logList;

            srvHost = new ServiceHost(typeof(WCFSample));

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
