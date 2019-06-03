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
        CardInfo cardInfo = CardInfo.Instance;
        LoadItems loadItems = new LoadItems();

        public string clientName { get; set; }
        public List<Item> items { get; set; }
        public MainModel()
        {
            clientName = cardInfo.GetClientName();
            items = loadItems.items;
        }

        public List<Item> bestSailitems()
        {
            List<Item> selectedItem;
            items.Sort(delegate (Item x, Item y)
            {
                if (x.SellCount > y.SellCount)
                {
                    return -1;
                }
                else if (x.SellCount == y.SellCount)
                {
                    return x.ItemID.CompareTo(y.ItemID);
                }
                else return 1;
            });
            selectedItem = items;
            return selectedItem;
        }

        public List<Item> sailingItems()
        {
            List<Item> selectedItem;
            items.Sort(delegate (Item x, Item y)
            {
                if (x.DiscountRate > y.DiscountRate)
                {
                    return -1;
                }
                else if (x.DiscountRate == y.DiscountRate)
                {
                    return x.ItemID.CompareTo(y.ItemID);
                }
                else return 1;
            });
            selectedItem = items;
            return selectedItem;
        }

        public Item GetItem(string itemID)
        {
            foreach(Item item in items)
            {
                if (item.ItemID.Equals(itemID))
                {
                    return item;
                }
            }
            return null;
        }


    }
}
