using System;
using System.Collections.Generic;
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
            itemImage.Source = new BitmapImage( new Uri(selectedItem.ImgUrl));
        }
    }
}
