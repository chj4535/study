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
                    DataContext = new MainViewModel();
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
    }
}
