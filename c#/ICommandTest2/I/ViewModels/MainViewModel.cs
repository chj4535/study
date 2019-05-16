using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ICommandTest2.ViewModels.Command;


namespace ICommandTest2.ViewModels
{
    public class MainViewModel
    {
        public MessageCommand DisplayMessageCommand { get; private set; }

        // public string MessageText { get;set;}
        public MainViewModel()
        {
            DisplayMessageCommand = new MessageCommand(DisplayMessage);
        }

        public void DisplayMessage(string Message)
        {
            MessageBox.Show(Message);
        }
    }
}
