using DemoMVVM.Infrastructure;
using DemoMVVM.Model.Entities;
using DemoMVVM.Model.Repositorues;
using System;
using System.Collections.ObjectModel;


namespace DemoMVVM.ViewModels
{
   public class OrderViewModel: ViewModelBase
    {
        private OrderRepository _orderRepository;
        public OrderViewModel()
        {
            _orderRepository = new OrderRepository();

            AddOrderCommand = new RelayCommand(OnAddOrderCommandExecuted, OnAddOrderCommandCanExecuted);
            DeleteOrderCommand = new RelayCommand(OnDeleteOrderCommandExecuted, OnDeleteOrderCommandCanExecuted);
        }

        private bool OnDeleteOrderCommandCanExecuted(object obj)
        {
            return DeleteOrder != null;
        }

        private void OnDeleteOrderCommandExecuted(object obj)
        {
            Orders.Remove(DeleteOrder);
        }

        private bool OnAddOrderCommandCanExecuted(object obj)
        {
            return !String.IsNullOrWhiteSpace(NewOrder.Name) && NewOrder.Cost > 0;
        }

        private void OnAddOrderCommandExecuted(object obj)
        {
            Orders.Add(NewOrder);
            NewOrder = null;
        }

        private ObservableCollection<OrderInfo> _orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get
            {
                if (_orders == null)
                {
                    _orders = new ObservableCollection<OrderInfo>(_orderRepository.GetAll());
                }
                return _orders;
            }
        }


        private OrderInfo _newOrder;
        public OrderInfo NewOrder
        {
            get {
                if (_newOrder == null)
                {
                    _newOrder = new OrderInfo() { Date = DateTime.Now };
                }
                return _newOrder;
            }
            set
            {
                _newOrder = value;
                OnPropertyChanged();
            }
        }


        private OrderInfo _deleteOrder;

        public OrderInfo DeleteOrder
        {
            get { return _deleteOrder; }
            set { _deleteOrder = value; OnPropertyChanged(); }
        }


        public RelayCommand AddOrderCommand { get;  }
        public RelayCommand DeleteOrderCommand { get; }

    }
}
