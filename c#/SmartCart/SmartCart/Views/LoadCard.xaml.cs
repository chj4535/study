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
    /// LoadCard.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoadCard : Window
    {
        CardInfo cardInfo = CardInfo.Instance;
        public LoadCard()
        {
            InitializeComponent();
            this.SizeToContent = SizeToContent.Height;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (cardInfo.SetCardUid(cardUid.Text))
            {
                this.DialogResult = true;
            }
            else
            {
                MessageBox.Show(this,"등록되지 않은 카드입니다!");
            }
            
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
