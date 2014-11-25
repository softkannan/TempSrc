using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
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

namespace WCFClient
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var endAddress = new EndpointAddress("http://localhost:8733/WCFSample/");


            var binding = new WebHttpBinding();

            var clientFactory = new ChannelFactory<WCFSampleLib.IWCFSampleJson>(binding, endAddress);

            clientFactory.Endpoint.EndpointBehaviors.Add(new WebHttpBehavior());

            var client = clientFactory.CreateChannel();

            var tempData = client.GetDataJson("Kannan");

            var tempData1 = client.GetDataUsingDataContractJson(new WCFSampleLib.Person(), new WCFSampleLib.Person());

        }
    }
}
