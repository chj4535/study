using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCart.Models
{
    class CardInfo
    {
        private static string cardUid ="";
        private static string clientName = "";
        private static CardInfo _instance;
        
        private CardInfo() { }
        public static CardInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CardInfo();
                }
                return _instance;
            }
        }

        public bool SetCardUid(string cardUidNum)
        {
            string[] clientDB;
            string dir = "";
            dir = Directory.GetCurrentDirectory();

            cardUid = cardUidNum;
            clientDB = File.ReadLines(dir + @"\SmartCard\clientInfo.txt").ToArray();
            foreach(string clientInfo in clientDB)
            {
                string[] clientInfos = clientInfo.Split(';');
                if (cardUid.Equals(clientInfos[0]))
                {
                    clientName = clientInfos[1];
                    return true;
                }
            }
            return false;
        }

        public string GetClientName()
        {
            return clientName;
        }
    }
}
