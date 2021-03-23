using DemoDataBinding.Model;
using DemoDataBinding.Model.Entities;
using DemoDataBinding.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DemoDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PhoneRepository _phoneRepository;

        public MainWindow()
        {
            InitializeComponent();
            _phoneRepository = new PhoneRepository();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //PhoneInfo phoneInfo = new PhoneInfo()
            //{   Model = "Sony",
            //    Price = 5000,
            //    Date = new DateTime(2018,01,10)
            //};
            //Layout.DataContext = phoneInfo;

            // dgPhones.ItemsSource = _phoneRepository.Phones;
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            var obj = Layout.DataContext as PhoneInfo;
            MessageBox.Show(obj.ToString());
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var obj = Layout.DataContext as PhoneInfo;
            obj.Model = "Xiaomi Ivan";
            obj.Price = 999;
            obj.Date = DateTime.Now;
        }

        private void GetCount_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(_phoneRepository.Phones.Count().ToString());
            var repository = this.FindResource("PhoneRepository") as PhoneRepository;
            MessageBox.Show(repository.CountPhones.ToString());
        }

        private void GetSelect_Click(object sender, RoutedEventArgs e)
        {
            var selected = dgPhones.SelectedItem as PhoneInfo;
            if (selected != null)
            {
                MessageBox.Show(selected.ToString());
            }
        }

        private void AddPhone_Click(object sender, RoutedEventArgs e)
        {
            // _phoneRepository.AddItem(new PhoneInfo() {Model="Siemens" });
            var repository = this.FindResource("PhoneRepository") as PhoneRepository;
            repository.AddItem(new PhoneInfo() { Model = "Siemens" });
        }
    }
}
