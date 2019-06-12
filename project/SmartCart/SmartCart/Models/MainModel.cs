using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SmartCart.Models
{
    public class Bucket
    {
        public string ItemID { get; set; }
        public int Price { get; set; }
        public int SelectCount { get; set; }
        public int TotalPrice { get; set; }
        public string ImgUrl { get; set; }
    }

    public class MainModel
    {
        CardInfo cardInfo = CardInfo.Instance;
        LoadItems loadItems = new LoadItems();
        public ObservableCollection<Bucket> buckets { get; set; }
        public string clientName { get; set; }
        public string[] clientItem { get; set; }
        public List<Item> items { get; set; }
        public MainModel()
        {
            buckets = new ObservableCollection<Bucket>();
            clientName = cardInfo.GetClientName();
            clientItem = cardInfo.GetClientItems();
            items = loadItems.items;
        }

        public List<Item> BestSailitems()
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

        public int GetTotalPrice()
        {
            int totalPrice = 0;
            foreach(Bucket bucket in buckets)
            {
                totalPrice += bucket.TotalPrice;
            }
            return totalPrice;
        }

        public List<Item> SailingItems()
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

        public List<Item> PrivateItems()
        {
            List<Item> selectedItem = new List<Item>();
            foreach(Item item in items)
            {
                string itemID = item.ItemID;
                foreach(string clientItemID in clientItem)
                {
                    if (itemID == clientItemID)
                    {
                        selectedItem.Add(item);
                        break;
                    }
                }
            }
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

        public List<Item> FilteringItems(string type)
        {
            int categoryNumber = Int32.Parse(type);
            List<Item> filteringItems = new List<Item>();
            foreach(Item item in items)
            {
                if(item.CategoryNumber== categoryNumber)
                {
                    filteringItems.Add(item);
                }
            }
            return filteringItems;
        }
        
        public Item SearchItem(string searchText)
        {
            foreach (Item item in items)
            {
                if (item.ItemID == (searchText))
                {
                    return item;
                }
            }
            return null;
        }

        public List<Item> SelectCategory(string type)
        {
            switch (type)
            {
                case "all":
                    return SailingItems();
                case "mine":
                    return PrivateItems();
                default:
                    return FilteringItems(type);
            }
        }
        
        public ObservableCollection<Bucket> GetBucketList()
        {
            return buckets;
        }

        public ObservableCollection<Bucket> BucketCountMinus(string itemID)
        {
            foreach (Bucket bucket in buckets)
            {
                if (bucket.ItemID == itemID)
                {
                    if (bucket.SelectCount > 0) { 
                        bucket.SelectCount--;
                        bucket.TotalPrice = bucket.SelectCount * bucket.Price;
                    }
                    break;
                }
            }
            return buckets;
        }

        public void PrintPurchase()
        {
            string dir = "";
            dir = Directory.GetCurrentDirectory();
            string path = dir + @"\"+ DateTime.Now.ToString("yyyyMMddHHmmss") + "_"+clientName +".txt";
            StreamWriter writer = new StreamWriter(path);
            string header = String.Format("{0,-20}{1,-20}{2,-20}{3,-20}\n",
                                         "ItemID", "Count", "Price", "SubTotal");
            //Console.WriteLine(header);
            writer.WriteLine(header);
            foreach (Bucket bucket in buckets)
            {

                writer.Write("{0,-20} {1,-20} {2,-20} {3,-20} {4}", bucket.ItemID, bucket.SelectCount,bucket.Price ,bucket.TotalPrice, Environment.NewLine);
                /*
                foreach (var city in cities)
                {
                    writer.Write("{0,-12}{1,-8:yyyy}{2,-12:N0}{3,-8:yyyy}{4,-12:N0}{5,-14:P1}{6}",
                                           city.Item1, city.Item2, city.Item3, city.Item4, city.Item5,
                                           (city.Item5 - city.Item3) / city.Item3 * 1.0, Environment.NewLine);




                }*/
            }
            writer.Close();

        }

        public ObservableCollection<Bucket> BucketCountPlus(string itemID)
        {
            foreach (Bucket bucket in buckets)
            {
                if (bucket.ItemID == itemID)
                {
                    bucket.SelectCount++;
                    bucket.TotalPrice = bucket.SelectCount * bucket.Price;
                    break;
                }
            }
            return buckets;
        }

        public ObservableCollection<Bucket> AddBasket(Item searchItems,int productCount)
        {
            foreach(Bucket bucket in buckets)
            {
                if (searchItems.ItemID == bucket.ItemID)
                {
                    bucket.SelectCount += productCount;
                    return buckets;
                }
            }
            Bucket newBucket = new Bucket();
            newBucket.ImgUrl = searchItems.ImgUrl;
            newBucket.ItemID = searchItems.ItemID;
            newBucket.Price = searchItems.DiscountPrice;
            newBucket.SelectCount = productCount;
            newBucket.TotalPrice = productCount * newBucket.Price;
            buckets.Add(newBucket);
            return buckets;
        }
    }
}
