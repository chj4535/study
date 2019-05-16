using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace thread_singleton_study
{
    class Printer
    {
        //singleton member static으로 만들어야함
        private static int coin = 0;
        private static object lockObject = new object();
        private static object lockObject2 = new object();
        //

        private static Printer _instance;
        private Printer() { }
        public static Printer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Printer();
                }
                return _instance;
            }
        }
        public void InsertCoin()
        {
            lock (lockObject)
            {
                coin += 100;
                Console.WriteLine("insert coin " + " / remain coin : " + coin);
            }
        }
        public void print(String str)
        {
                InsertCoin();
                if (coin >= 30)
                {
                    coin -= 30;
                    Console.WriteLine("print : " + str + " / remain coin : " + coin);
                }
        }

        public void print2(String str)
        {
                InsertCoin();
                if (coin >= 30)
                {
                    coin -= 30;
                    Console.WriteLine("print2 : " + str + " / remain coin : " + coin);
                }
        }
    }
}
