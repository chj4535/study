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
        public string recruitLabel { get; private set; }
        public List<TypeCondition> conditions{get; set;}
        public List<Charactor> charactors { get; set; }
        public string test { get; set; }
        public DelegateCommand RecruitConditionCommand { get; private set; }
        public bool boolcheck = false;
        public List<string> selectCondition { get; set; }
        public ObservableCollection<SelectRecruitMember> recruitMap { get; set; }
        public MainViewModel()
        {
            RecruitConditionCommand = new DelegateCommand(RecruitCondtionButtonClick);
            recruitLabel = "///////////라벨 라인//////////////////////";
            test = "hello2";
            conditions = mainModel.GetRecruitConditions();
            charactors = mainModel.GetCharacterInfo();
            selectCondition = new List<string>();
            recruitMap = new ObservableCollection<SelectRecruitMember>();
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

            selectCondition.Sort(delegate (string x, string y)
            {
                int xTypenum = -1;
                int yTypenum = -1;
                foreach (TypeCondition typeCondition in conditions)
                {
                    if (typeCondition.Contexts.Contains(x))
                    {
                        xTypenum = typeCondition.ConditionNum;
                    }
                    if (typeCondition.Contexts.Contains(y))
                    {
                        yTypenum = typeCondition.ConditionNum;
                    }
                }
                if (xTypenum > yTypenum)
                {
                    return 1;
                }
                else if (xTypenum == yTypenum)
                {
                    return x.CompareTo(y);
                }
                else return -1;
            });

            CurrentRecurit();

        }

        public void CurrentRecurit()
        {
            int selectConditioncount = selectCondition.Count;
            List<string> currentCondition = new List<string>();
            recruitMap = new ObservableCollection<SelectRecruitMember>();
            select(selectConditioncount, currentCondition, 0);
            OnPropertyChanged("recruitMap");
        }

        public void select(int selectConditioncount, List<string> currentCondition, int currentselectConditioncount)
        {

            if(currentselectConditioncount== selectConditioncount)
            {
                if (currentCondition.Count != 0)
                {
                    string[] selectConditionarray;
                    Charactor[] recruitMemberarray;
                    List<Charactor> recruitMember = new List<Charactor>();
                    selectConditionarray = currentCondition.ToArray();
                    foreach(Charactor charactor in charactors)
                    {
                        bool check = true;
                        foreach(string condition in selectConditionarray)
                        {
                            if (!charactor.RecruitConditions.Contains(condition))
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check)
                        {
                            recruitMember.Add(charactor);
                        }
                    }
                    recruitMemberarray = recruitMember.ToArray();
                    if(recruitMemberarray.Length>0)
                        recruitMap.Add(new SelectRecruitMember() { currentSelectRecruitCondition= selectConditionarray, currentSelectRecruitConditionMember= recruitMemberarray });
                }
                return;
            }

            select(selectConditioncount, currentCondition, currentselectConditioncount + 1); //not select

            currentCondition.Add(selectCondition[currentselectConditioncount]);
            select(selectConditioncount, currentCondition, currentselectConditioncount + 1); //select
            currentCondition.Remove(selectCondition[currentselectConditioncount]);
            return;

        }

        public class SelectRecruitMember
        {
            public string[] currentSelectRecruitCondition { get; set; }
            public Charactor[] currentSelectRecruitConditionMember { get; set; }
        }

    }
}
