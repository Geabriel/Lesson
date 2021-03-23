using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Thread _thread;
        private string _str;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText("2222222");
            Thread thread = new Thread(GetTextTo);
            thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
            thread.Start();
            thread.Join();
        }

        private void GetTextTo()
        {
			    Thread.Sleep(2000);
	        var dddd = Clipboard.GetText();
	        Dispatcher.BeginInvoke((Action<string>)(arg => this.Title = arg), dddd);

        }

		  

    }
}
