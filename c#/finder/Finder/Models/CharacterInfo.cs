using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finder.Models
{
    class CharacterInfo
    {
        public List<Charactor> charactors = new List<Charactor>();
        public CharacterInfo()
        {
            string dir = "";
            dir = Directory.GetCurrentDirectory();

            string[] charactorNames = Directory.GetFiles(dir + @"\data\character");

            foreach(string name in charactorNames)
            {
                /*
                Console.WriteLine(name);
                Console.WriteLine(Path.GetFileName(name));
                */
                string charactorName = Path.GetFileNameWithoutExtension(name);
                string[] charactorInfos = File.ReadLines(dir + @"\data\charateristic\"+ charactorName+".txt").ToArray();
                Console.WriteLine(charactorInfos[0]);
                Charactor charactor = new Charactor();
                charactor.Name = charactorName;
                charactor.ImgUrl = name;
                foreach (string charactorInfo in charactorInfos)
                {
                    string infoType = charactorInfo.Split(':').First();
                    string[] infoDetails = charactorInfo.Split(':').Last().Split(';');
                    Console.WriteLine(infoDetails[0]);
                    switch (infoType)
                    {
                        case "Star":
                            charactor.Star = Convert.ToInt32(infoDetails[0]);
                            charactor.StarColor = SetStarColor(charactor.Star);
                            break;
                        case "RecruitCondition":
                            charactor.RecruitConditions = infoDetails;
                            break;
                        case "InfraBonus":
                            charactor.InfraBonus = infoDetails;
                            break;
                    }
                }

                charactors.Add(charactor);
            }

            charactors.Sort(delegate (Charactor x, Charactor y)
            {
                return y.Star.CompareTo(x.Star);
            });
        }

        public string SetStarColor(int star)
        {
            switch (star)
            {
                case 1:
                    return "Green";
                case 2:
                    return "Green";
                case 3:
                    return "Green";
                case 4:
                    return "Purple";
                case 5:
                    return "Gold";
                case 6:
                    return "Gold";
            }
            return "Black";
        }

        public List<Charactor> GetCharacterInfo()
        {
            return charactors;
        }

    }

    public class Charactor
    {
        public string Name { get; set; } //charactor name
        public int Star { get; set; } //charactor star
        public string StarColor { get; set; } //charactor star
        public string ImgUrl { get; set; }//charactor imgurl
        public string[] RecruitConditions { get; set; }
        public string[] InfraBonus { get; set; }
    }
}
