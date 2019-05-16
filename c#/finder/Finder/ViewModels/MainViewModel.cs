using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finder.Models;
namespace Finder.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        MainModel mainModel = new MainModel();
        public string[] ActorList; 
        public string recruitLabel { get; private set; }
        List<Condition> conditions;
        public MainViewModel()
        {
            recruitLabel = "hello";
            ActorList= new string[] { "test1", "test2", "test3" };
            conditions = mainModel.GetRecruitConditions();
        }
    }
}
