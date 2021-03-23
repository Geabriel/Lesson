using DemoDataBinding.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataBinding.Model.Repositories
{
    public class PhoneRepository : BaseEntity
    {
        private ObservableCollection<PhoneInfo> _phones;

        public int CountPhones => _phones.Count;

        public PhoneRepository()
        {
            _phones = new ObservableCollection<PhoneInfo>()
            {
                new PhoneInfo() {Model="Samsung", Price=1500, Date = new DateTime(2018,10,10) },
                new PhoneInfo() {Model="Sony", Price=500, Date = new DateTime(2017,01,02) },
                new PhoneInfo() {Model="Nokia", Price=850, Date = new DateTime(2016,02,15) }
            };
            _phones.CollectionChanged += (os, ea) => { OnPropertyChanged(nameof(CountPhones)); };
        }

        public IEnumerable<PhoneInfo> Phones
        {
            get { return _phones; }
        }

        /// <summary>
        /// Add PhoneInfo
        /// </summary>
        /// <param name="phoneInfo"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddItem(PhoneInfo phoneInfo)
        {
            if (phoneInfo == null)
                throw new ArgumentNullException();

            _phones.Add(phoneInfo);
        }
    }
}
