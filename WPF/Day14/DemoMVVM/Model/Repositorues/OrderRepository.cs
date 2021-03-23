using DemoMVVM.Model.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.Model.Repositorues
{
   public  class OrderRepository
    {
        private ObservableCollection<OrderInfo> _orders;
        public OrderRepository()
        {
            _orders = new ObservableCollection<OrderInfo>();

            Ini();
        }

        private void Ini()
        {
            _orders.Add(new OrderInfo() {Name="Pepperoni",Cost=18.90m, Date = new DateTime(2018,12,20) });
            _orders.Add(new OrderInfo() { Name = "BBQ", Cost = 22.90m, Date = new DateTime(2018, 12, 20) });
            _orders.Add(new OrderInfo() { Name = "Super Ivan", Cost = 28.90m, Date = new DateTime(2018, 12, 20) });
        }

        public IEnumerable<OrderInfo> GetAll()
        {
            return _orders;
        }

    }
}
