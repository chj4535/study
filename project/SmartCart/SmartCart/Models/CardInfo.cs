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
        private static string clientPassword = "";
        private static string[] clientItems;
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
                    if (clientInfos.Length > 2)
                    {
                        clientPassword = clientInfos[2];
                        int clientItemscount = clientInfos.Length - 3;
                        clientItems = new string[clientItemscount];
                        Array.Copy(clientInfos, 3, clientItems, 0, clientItemscount);
                    }
                    return true;
                }
            }
            return false;
        }

        public string GetClientName()
        {
            return clientName;
        }

        public string[] GetClientItems()
        {
            return clientItems;
        }

        public bool CheckClientPassword(string password)
        {
            if (password == clientPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
