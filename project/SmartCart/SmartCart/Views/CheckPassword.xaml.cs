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
    /// CheckPassWord.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CheckPassWord : Window
    {
        CardInfo cardInfo = CardInfo.Instance;
        public CheckPassWord()
        {
            InitializeComponent();
            string dir = "";
            dir = Directory.GetCurrentDirectory();
            Uri iconUri = new Uri(dir + @"\SmartCard\icon2.png", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(iconUri);
            this.SizeToContent = SizeToContent.Height;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (cardInfo.CheckClientPassword(Password.Text))
            {
                this.DialogResult = true;
            }
            else
            {
                MessageBox.Show(this, "비밀번호가 일치하지 않습니다!");
            }

        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
