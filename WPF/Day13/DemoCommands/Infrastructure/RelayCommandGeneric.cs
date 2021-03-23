using System;
using System.Windows.Input;

namespace DemoCommands.Infrastructure
{
	public class RelayCommand<T> : ICommand
	{

		public event EventHandler CanExecuteChanged
		{
			add => CommandManager.RequerySuggested += value;
			remove => CommandManager.RequerySuggested -= value;
		}

		private readonly Action<T> _execute;

		private readonly Predicate<T> _canExecuted;
		public RelayCommand(Action<T> execute) : this(execute, p => true)
		{
		}

		public RelayCommand(Action<T> execute, Predicate<T> canExecuted)
		{
			_execute = execute ?? throw new ArgumentNullException(nameof(execute));
			_canExecuted = canExecuted;
		}


		public bool CanExecute(T parameter)
		{
			return _canExecuted?.Invoke(parameter) ?? true;
		}

		public void Execute(T parameter)
		{
			_execute.Invoke(parameter);
		}

		bool ICommand.CanExecute(object parameter)
		{
			if (parameter == null)
			{
				return CanExecute(default(T));
			}

			var value = (T)Convert.ChangeType(parameter, typeof(T));
			return CanExecute(value);
		}

		void ICommand.Execute(object parameter)
		{
			if (parameter == null)
			{
				Execute(default(T));
				return;
			}

			var value = (T)Convert.ChangeType(parameter, typeof(T));
			Execute(value);
		}

	}
}
