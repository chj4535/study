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

namespace Top_Level_Window
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            WindowMenu.SubmenuOpened += WindowMenuSubmenuOpend;
        }

        private void WindowMenuSubmenuOpend(object sender, RoutedEventArgs e)
        {
            WindowMenu.Items.Clear();
            foreach(Window window in Application.Current.Windows)
            {
                MenuItem item = new MenuItem();
                item.Header = window.Title;
                item.Click += WindowMenuItemClick;
                item.Tag = window;
                WindowMenu.Items.Add(item);
            }
        }

        private void WindowMenuItemClick(object sender, RoutedEventArgs e)
        {
            Window window = (Window)((MenuItem)sender).Tag;
            window.Activate();
        }
    }
}
