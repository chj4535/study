﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ICommandTest3.ViewModels.Command
{
    public class DelegateCommand : ICommand
    {

        public Action<object> _execute;
        public Predicate<object> _canExecute;


        public DelegateCommand(Action<object> execute,Predicate<object> canExecute)
        {
            if (execute == null)
                throw new NullReferenceException("execute null");

            _execute = execute;
            _canExecute = canExecute;
        }

        public DelegateCommand(Action<object> execute) : this(execute,null)
        {

        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

    public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
