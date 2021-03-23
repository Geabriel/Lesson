using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoCommands.Commands
{
   public static class ReportCommands
    {
        private static RoutedUICommand _createReport;

        public static RoutedUICommand CreateReport
        {
            get { return _createReport; }
        }

        private static RoutedUICommand _printReport;

        public static RoutedUICommand PrintReport
        {
            get { return _printReport; }
        }


        static ReportCommands()
        {
            _createReport = new RoutedUICommand("Создать отчет", "CreateReport", typeof(ReportCommands));

            InputGestureCollection collections = new InputGestureCollection();
            collections.Add(new KeyGesture(Key.P, ModifierKeys.Control, "Ctrl+P"));

            _printReport = new RoutedUICommand( "Печать отчета", 
                                                "PrintReport", 
                                                typeof(ReportCommands), 
                                                collections);
        }

    }
}
