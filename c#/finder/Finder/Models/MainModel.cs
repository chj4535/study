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
        CharacterInfo characterInfo = new CharacterInfo();
        public List<TypeCondition> conditions;
        public List<Charactor> charactors;
        public MainModel()
        {
            conditions = recruitCondtion.GetRecruitConditions();
            charactors = characterInfo.GetCharacterInfo();
        }

        public List<TypeCondition>  GetRecruitConditions()
        {
            return conditions;
        }

        public List<Charactor> GetCharacterInfo()
        {
            return charactors;
        }
    }
}
