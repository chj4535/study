﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ICommandTest2.ViewModels.Command
{
    public class MessageCommand : ICommand
    {
        private Action<string> _execute;

        public MessageCommand(Action<string> execute)
        {
            _execute = execute;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter as string);
        }
    }
}
