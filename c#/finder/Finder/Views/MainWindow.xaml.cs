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

            //자격 조건들
            string[] recruitQualification;
            //포지션 조건들
            string[] recruitPosition;
            //성별 조건들
            string[] recruitGender;
            //클래스 조건들
            string[] recruitClass;
            //태그 조건들
            string[] recruitTag;

            string dir = "";
            dir = Directory.GetCurrentDirectory();
            List<Condition> conditions = new List<Condition>();
            recruitQualification = File.ReadLines(dir + @"\data\set\RecruitCondition\Qualification.txt").ToArray();
            recruitPosition = File.ReadLines(dir + @"\data\set\RecruitCondition\Position.txt").ToArray();
            recruitGender = File.ReadLines(dir + @"\data\set\RecruitCondition\Gender.txt").ToArray();
            recruitClass = File.ReadLines(dir + @"\data\set\RecruitCondition\Class.txt").ToArray();
            recruitTag = File.ReadLines(dir + @"\data\set\RecruitCondition\Tag.txt").ToArray();

            conditions.Add(new Condition() { Name = "자격", Contexts = recruitQualification });
            conditions.Add(new Condition() { Name = "포지션", Contexts = recruitPosition });
            conditions.Add(new Condition() { Name = "성별", Contexts = recruitGender });
            conditions.Add(new Condition() { Name = "클래스", Contexts = recruitClass });
            conditions.Add(new Condition() { Name = "태그", Contexts = recruitTag });

            icTodoList.ItemsSource = conditions;

        }
        public class Condition
        {
            public string Name { get; set; }
            public string[] Contexts { get; set; }
        }
    }
}
