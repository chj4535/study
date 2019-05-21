using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finder.Models;
using Finder.ViewModels.Command;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Collections.ObjectModel;

namespace Finder.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        MainModel mainModel = new MainModel();
        public string[] ActorList; 
        public string recruitLabel { get; private set; }
        public List<TypeCondition> conditions{get; set;}
        public List<Charactor> charactors { get; set; }
        public string test { get; set; }
        public DelegateCommand RecruitConditionCommand { get; private set; }
        public bool boolcheck = false;
        public ObservableCollection<string> selectCondition { get; set; }
        public MainViewModel()
        {
            RecruitConditionCommand = new DelegateCommand(RecruitCondtionButtonClick);
            recruitLabel = "///////////라벨 라인//////////////////////";
            test = "hello2";
            ActorList= new string[] { "test1", "test2", "test3" };
            conditions = mainModel.GetRecruitConditions();
            charactors = mainModel.GetCharacterInfo();
            selectCondition = new ObservableCollection<string>();
        }

        public void RecruitCondtionButtonClick(object sender)
        {
            var button = sender as Button;
            string tagValue = String.Empty;

            if (button != null)
            {
                tagValue = button.Tag.ToString();

                if (tagValue == "button1") //condition add
                {
                    button.Style = (Style)Application.Current.MainWindow.Resources["button2"];
                    selectCondition.Add((string)button.Content);
                }
                else if (tagValue == "button2") //condition remove
                {
                    button.Style = (Style)Application.Current.MainWindow.Resources["button1"];
                    selectCondition.Remove((string)button.Content);
                }
            }
        }


        
    }
}
