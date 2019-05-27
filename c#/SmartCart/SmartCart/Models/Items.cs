using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCart.Models
{
    class Items
    {
        public Items()
        {
            string dir = "";
            dir = Directory.GetCurrentDirectory();
            string[] charactorNames = Directory.GetFiles(dir + @"\data\character");
        }

    }
}
