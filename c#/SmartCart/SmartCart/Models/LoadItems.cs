using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCart.Models
{
    class LoadItems
    {
        public List<Item> items { get; set; }
        public LoadItems()
        {
            items = new List<Item>();

            string dir = "";
            dir = Directory.GetCurrentDirectory();
            string[] itemsPath = Directory.GetFiles(dir + @"\SmartCard\Items");

            foreach (string itemPath in itemsPath)
            {
                string itemName = Path.GetFileNameWithoutExtension(itemPath);
                string[] itemInfos = File.ReadLines(dir + @"\SmartCard\ItemInfo\" + itemName + ".txt", Encoding.Default).ToArray();
                Item item = new Item();
                item.ImgUrl = itemPath;
                foreach (string itemInfo in itemInfos)
                {
                    string infoType = itemInfo.Split(':').First();
                    string infoDetails = itemInfo.Split(':').Last();
                    switch (infoType)
                    {
                        case "itemID":
                            item.ItemID = infoDetails;
                            break;
                        case "description":
                            item.Description = infoDetails;
                            break;
                        case "price":
                            item.Price = Int32.Parse(infoDetails);
                            break;
                        case "weight":
                            item.Weight = infoDetails;
                            break;
                        case "stock":
                            item.Stock = Int32.Parse(infoDetails);
                            break;
                        case "discountRate":
                            item.DiscountRate = Int32.Parse(infoDetails);
                            break;
                        case "categoryNumber":
                            item.CategoryNumber = Int32.Parse(infoDetails);
                            break;
                        case "sellCount":
                            item.SellCount = Int32.Parse(infoDetails);
                            break;
                    }
                }
                items.Add(item);
            }
        }
    }

    public class Item
    {
        public string ItemID { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string  Weight { get; set; }
        public int Stock { get; set; }
        public int DiscountRate { get; set; }
        public int CategoryNumber { get; set; }
        public int SellCount { get; set; }
        public string ImgUrl { get; set; }
    }
}
