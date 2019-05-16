using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finder.Models
{
    public class RecruitCondition
    {
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

        public List<Condition> conditions = new List<Condition>();

        public RecruitCondition()
        {
            string dir = "";
            dir = Directory.GetCurrentDirectory();

            recruitQualification = File.ReadLines(dir + @"\data\set\RecruitCondition\Qualification.txt").ToArray();
            recruitPosition = File.ReadLines(dir + @"\data\set\RecruitCondition\Position.txt").ToArray();
            recruitGender = File.ReadLines(dir + @"\data\set\RecruitCondition\Gender.txt").ToArray();
            recruitClass = File.ReadLines(dir + @"\data\set\RecruitCondition\Class.txt").ToArray();
            recruitTag = File.ReadLines(dir + @"\data\set\RecruitCondition\Tag.txt").ToArray();
        }

        public List<Condition> SetRecruitConditions()
        {
            conditions.Add(new Condition() { Name = "자격", Contexts = recruitQualification });
            conditions.Add(new Condition() { Name = "포지션", Contexts = recruitPosition });
            conditions.Add(new Condition() { Name = "성별", Contexts = recruitGender });
            conditions.Add(new Condition() { Name = "클래스", Contexts = recruitTag });
            conditions.Add(new Condition() { Name = "태그", Contexts = recruitTag });
            return conditions;
        }

    }

    public class Condition
    {
        public string Name { get; set; }
        public string[] Contexts { get; set; }
    }
}
