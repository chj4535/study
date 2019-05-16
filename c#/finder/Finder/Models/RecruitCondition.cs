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
        public RecruitCondition()
        {
            string csadd = "";
            csadd = Directory.GetCurrentDirectory();
            string[] lines = File.ReadLines(csadd+@"\data\set\RecruitCondition\Qualification.txt").ToArray();
            foreach(string condition in lines)
            {
                Console.WriteLine(condition);
            }
        }

    }
}
