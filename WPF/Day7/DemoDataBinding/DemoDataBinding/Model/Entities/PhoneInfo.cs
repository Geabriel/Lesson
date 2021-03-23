using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataBinding.Model.Entities
{
   
    public class PhoneInfo :BaseEntity
    {
        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; OnPropertyChanged("Model"); }
        }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set { _price = value; OnPropertyChanged(nameof(Price)); }
        }

        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; OnPropertyChanged(); }
        }

       

      

        public override string ToString()
        {
            return $"{Model} {Price:N2} {Date:dd.MM.yyyy}";
        }
    }
}
