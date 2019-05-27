using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SmartCart.Models
{
    public class MainModel
    {
        public string clientName { get; set; }
        CardInfo cardInfo = CardInfo.Instance;
        public MainModel()
        {
            clientName = cardInfo.GetClientName();
        }
    }
}
