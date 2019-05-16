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
using Timer.ViewModels;
//using System.IO;
namespace Timer.Views
{
    /// <summary>
    /// EditRequestWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EditRequestWindow : Window
    {
        public EditRequestWindow(string content,MainViewModel mainViewmodel)
        {
            InitializeComponent();
            this.editRequestcontent.Document.Blocks.Clear();
            this.editRequestcontent.Document.Blocks.Add(new Paragraph(new Run(content)));
            DataContext = mainViewmodel;
        }
    }
}
