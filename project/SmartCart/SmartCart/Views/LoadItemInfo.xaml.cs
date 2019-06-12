using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SmartCart.Models;

namespace SmartCart.Views
{
    /// <summary>
    /// LoadItemInfo.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoadItemInfo : Window
    {
        public LoadItemInfo(Item selectedItem)
        {
            Console.Write(selectedItem.ItemID);
            InitializeComponent();
            this.Title = selectedItem.ItemID;
            string dir = "";
            dir = Directory.GetCurrentDirectory();
            Uri iconUri = new Uri(dir + @"\SmartCard\icon2.png", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(iconUri);
            itemImage.Source = new BitmapImage( new Uri(selectedItem.ImgUrl));
            this.Category.Text = "타입 : " + selectedItem.Category +"("+selectedItem.CategoryNumber+")"; 
            this.itemID.Text = "이름 : " + selectedItem.ItemID;
            if (selectedItem.DiscountRate != 0)
            {
                this.price.Text = "가격 : " + selectedItem.Price + " -> " + selectedItem.DiscountPrice;
            }
            else
            {
                this.price.Text = "가격 : " + selectedItem.Price;
            }
            this.stock.Text = "재고 : " + selectedItem.Stock;
            this.sellCount.Text = "판매수량 : " + selectedItem.SellCount;
            this.description.Text = selectedItem.Description;
        }
    }
}
