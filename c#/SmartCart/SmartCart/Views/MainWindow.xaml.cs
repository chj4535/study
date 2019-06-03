using SmartCart.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SmartCart.ViewModels;


namespace SmartCart
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mainViewmodel;
        public MainWindow()
        {
            
            Window loadCart = new LoadCard();
            loadCart.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            var result = loadCart.ShowDialog();
            switch (result)
            {
                case true:
                    InitializeComponent();
                    this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    mainViewmodel = new MainViewModel();
                    DataContext = mainViewmodel;
                    break;
                default:
                    System.Windows.Application.Current.Shutdown();
                    break;
            }

            /*
            InitializeComponent();
            DataContext = new MainViewModel();
            ClientName.Content = "hello";
            */
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Border itemBorder = sender as Border;
            Grid itemGrid = (Grid)itemBorder.Child;
            TextBlock itemTextBlock = (TextBlock)itemGrid.Children[1];
            string itemID = itemTextBlock.Text;
            Window laodIteminfo = new LoadItemInfo(mainViewmodel.GetItem(itemID));
            laodIteminfo.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            var result = laodIteminfo.ShowDialog();
        }
    }
}
