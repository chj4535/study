using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finder.Models
{
    public class MainModel
    {
        RecruitCondition recruitCondtion = new RecruitCondition();
        List<Condition> conditions;
        public MainModel()
        {
            conditions = recruitCondtion.SetRecruitConditions();
        }

        public List<Condition>  GetRecruitConditions()
        {
            return conditions;
        }
    }
}
