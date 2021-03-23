using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace DemoCommands
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
        
        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var param = e.Parameter;
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog().Value)
            {
                tbMainText.Text = File.ReadAllText(openFileDialog.FileName, Encoding.Default);
            }
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog().Value)
            {
                File.WriteAllText(saveFileDialog.FileName, tbMainText.Text);
            }
        }

        private void CanSave_Executed(object sender, CanExecuteRoutedEventArgs e)
        {
            if(tbMainText!=null)
            e.CanExecute = !String.IsNullOrWhiteSpace(tbMainText.Text);
        }

        private void PrintReport_Executed(object sender, ExecutedRoutedEventArgs e)
        {
           MessageBox.Show("Test");
        }

        private void PrintReport_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            if (tbMainText != null)
                e.CanExecute = !String.IsNullOrWhiteSpace(tbMainText.Text);
        }
    }
}
