using DemoCommands.Infrastructure;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoCommands.Model
{
    public class StringRepository
    {
        ObservableCollection<string> _collection;
        public StringRepository()
        {
            Collection = new ObservableCollection<string>();
            Collection.Add(Guid.NewGuid().ToString());
            Collection.Add(Guid.NewGuid().ToString());
            Collection.Add(Guid.NewGuid().ToString());

            AddCommand = new RelayCommand<int>(Add);
        }

        public ObservableCollection<string> Collection
        {
            get
            {
                return _collection;
            }

            protected set
            {
                _collection = value;
            }
        }

        public void Add_old(object param)
        {
            int count = param!=null ? Int32.Parse(param.ToString()) : 1;
            for (int i = 0; i < count; i++)
            {
                Collection.Add(Guid.NewGuid().ToString());
            }
        }

        public void Add(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Collection.Add(Guid.NewGuid().ToString());
            }

        }

        public bool CanAdd(object param)
        {
            return this.Collection.Count < 10;
        }




        public ICommand AddCommand { get;}


    }
}
