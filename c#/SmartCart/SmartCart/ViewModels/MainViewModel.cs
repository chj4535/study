using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCart.Models;

namespace SmartCart.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        MainModel mainModel = new MainModel();
        public string clientName { get; set; } 
        public MainViewModel()
        {
            clientName = mainModel.clientName;
        }
    }
}
