using System;
using System.Windows.Input;

namespace DemoCommands.Infrastructure
{
	public class RelayCommand : ICommand
	{
		private readonly Action<object> _execute;
		private readonly Predicate<object> _canExecuted;
		public RelayCommand(Action<object> execute) : this(execute, p => true)
		{
		}

		public RelayCommand(Action<object> execute, Predicate<object> canExecuted)
		{
			_execute = execute ?? throw new ArgumentNullException(nameof(execute));
			_canExecuted = canExecuted;
		}

		public event EventHandler CanExecuteChanged
		{
			add => CommandManager.RequerySuggested += value;
			remove => CommandManager.RequerySuggested -= value;
		}

		public bool CanExecute(object parameter)
		{
			return _canExecuted?.Invoke(parameter) ?? true;
		}

		public void Execute(object parameter)
		{
			_execute.Invoke(parameter);
		}
	}
	}
