using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ICommandTest.ViewModels
{
    public class ViewModel
    {
        public ICommand Mycommand { get; set; }
        public ViewModel()
        {
            Mycommand = new Command.Command(executeMethod, canexecuteMethod);
        }

        private bool canexecuteMethod(object arg)
        {
            return true;
        }

        private void executeMethod(object obj)
        {
            MessageBox.Show("check");
        }
    }
}
