using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIntroWPF.Helpers
{
   public class DateHelper
    {
        public static string DateNow { get; }
        static DateHelper()
        {
            DateNow = DateTime.Now.ToLongDateString();
        }
    }
}
