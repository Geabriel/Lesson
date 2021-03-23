using DemoIntroWPF.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace DemoIntroWPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btnSecond.Content = "My Button";
            btnSecond.Background = gradient;

            Layout.Children.Add(new TextBox() { Text="Demo"});
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbOsVersion.Content = Environment.OSVersion;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow();
            addUserWindow.ShowDialog();
        }
    }
}
