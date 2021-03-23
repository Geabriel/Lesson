using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.Model.Entities
{
    public class OrderInfo
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private decimal _cost;

        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public override string ToString()
        {
            return $"{Name} {Cost:N2} {Date:dd.MM.yyyy}";
        }

    }
}
