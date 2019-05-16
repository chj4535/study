using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICommandTest3.ViewModels.Command;
using System.Collections.ObjectModel;
using System.Windows;

namespace ICommandTest3.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<string> MyMessage { get; private set; }

        public DelegateCommand MessageBoxCommand { get; private set; }

        public DelegateCommand ConsoleLogCommand { get; private set; }

        public MainViewModel()
        {
            MyMessage = new ObservableCollection<string>()
            {
                "안녕하세요",
                "Hello",
                "메시지 박스",
                "콘솔"
            };

            MessageBoxCommand = new DelegateCommand(DisplayMessageBox, MessageBoxCanUse);
            ConsoleLogCommand = new DelegateCommand(DisplayConsoleLog, ConsoleLogCanUse);
        }

        public void DisplayMessageBox(object Message)
        {
            MessageBox.Show((string)Message);
        }

        public void DisplayConsoleLog(object Message)
        {
            Console.WriteLine((string)Message);
        }

        public bool MessageBoxCanUse(object Message)
        {
            if((string)Message == "콘솔")
            {
                return false;
            }
            return true;
        }

        public bool ConsoleLogCanUse(object Message)
        {
            if ((string)Message == "메시지 박스")
            {
                return false;
            }
            return true;
        }
    }
}
