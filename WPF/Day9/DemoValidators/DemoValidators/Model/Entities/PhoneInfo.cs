using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DemoValidators.Model.Entities
{

    public class PhoneInfo : IDataErrorInfo
    {
        private string _model;
        public string Model
        {
            get { return _model; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Model is empty");

                _model = value;
            }
        }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _imei;
        public string IMEI
        {
            get { return _imei; }
            set { _imei = value; }
        }

        public string Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string this[string columnName]
        {
            get
            {
                string message = String.Empty;
                if (IMEI!=null &&  columnName.Equals(nameof(IMEI)))
                {
                    string pattern = @"^(\d{2}-\d{5,6}-\d{5,6}-\d{1,2})$";
                    if (!Regex.IsMatch(IMEI, pattern))
                    {
                        return "Error in IMEI";
                    }
                }
                return message;
            }
        }
    }
}
