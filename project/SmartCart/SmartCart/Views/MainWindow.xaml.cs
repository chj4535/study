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
using System.IO;

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
                case true: //카드 삽입 성공
                    Window checkPassword = new CheckPassWord();
                    checkPassword.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    var checkPasswordresult = checkPassword.ShowDialog();
                    switch (checkPasswordresult)
                    {
                        case true://비밀번호 성공
                            InitializeComponent();
                            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                            string dir = "";
                            dir = Directory.GetCurrentDirectory();
                            Uri iconUri = new Uri(dir + @"\SmartCard\icon2.png", UriKind.RelativeOrAbsolute);
                            this.Icon = BitmapFrame.Create(iconUri);
                            mainViewmodel = new MainViewModel();
                            DataContext = mainViewmodel;
                            break;
                        case false:
                            System.Windows.Application.Current.Shutdown();
                            break;
                    }
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

        private void Typeall_Click(object sender, RoutedEventArgs e)
        {
            this.listScrollbar.ScrollToTop();
        }
    }
}
