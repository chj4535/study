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
using Finder.ViewModels;
using System.IO;

namespace Finder
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            /*
            var button = sender as Button;
            string tagValue = String.Empty;

            if (button != null)
            {
                tagValue = button.Tag.ToString();

                if (tagValue == "button1")
                {
                    button.Style = (Style)Application.Current.Resources["button1"];
                }
                else if (tagValue == "button2")
                {
                    button.Style = (Style)Application.Current.Resources["button2"];
                }
            }
            */
        }
    }
}
