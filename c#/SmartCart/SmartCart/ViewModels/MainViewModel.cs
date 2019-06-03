using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCart.Models;
using SmartCart.ViewModels.command;

namespace SmartCart.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        MainModel mainModel = new MainModel();

        public string clientName { get; set; }
        public List<Item> items { get; set; }
        private int selectedTabindex;
        public int SelectedTabindex
        {
            get
            {
                return selectedTabindex;
            }
            set
            {
                ClickTab(value);
                selectedTabindex = value;
            }
        }

        public MainViewModel()
        {
            clientName = mainModel.clientName;
            OnPropertyChanged("clientName");
            SelectedTabindex = 0;
        }

        public void ClickTab(int selectIndex)
        {
            switch (selectIndex) {
                case 0:
                    items = mainModel.bestSailitems();
                    break;
                case 1:
                    items = mainModel.sailingItems();
                    break;
            }
        }

        public Item GetItem(string itemID)
        {
            return mainModel.GetItem(itemID);
        }
    }
}
