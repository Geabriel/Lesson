using Microsoft.Win32;
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

namespace PanalControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        //1
        public static readonly DependencyProperty FilePathProperty;


        //2
        static UserControl1()
        {
            PropertyMetadata propertyMetadata = new PropertyMetadata();
            propertyMetadata.DefaultValue = @"d:\";
            propertyMetadata.PropertyChangedCallback = FilePathChanged;


            FilePathProperty = DependencyProperty.Register
                (
                "FilePath",
                typeof(String),
                typeof(UserControl1),
                propertyMetadata,
                ValidateValueCallback
            );
        }

        //3
        public string FilePath
        {
            get { return (String)GetValue(FilePathProperty); }
            set { SetValue(FilePathProperty, value); }
        }


        private static void FilePathChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var obj = (UserControl1)d;
            obj.tbFilePath.Text = obj.FilePath;
        }

        private static bool ValidateValueCallback(object value)
        {
            return !String.IsNullOrWhiteSpace(value.ToString());
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog().Value)
            {
                FilePath = ofd.FileName;
            }
        }
    }
}
