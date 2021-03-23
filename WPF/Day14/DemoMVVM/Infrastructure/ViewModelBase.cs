using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace DemoMVVM.Infrastructure
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
