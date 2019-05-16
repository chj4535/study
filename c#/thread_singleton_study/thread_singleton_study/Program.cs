using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thread_singleton_study
{
    class Program
    {
        private static int THREAD_NUM = 5;
        static void Main(string[] args)
        {
            Thread[] user = new Thread[THREAD_NUM];
            for (int i = 0; i < THREAD_NUM; i++)
            {
                // UserThread 인스턴스 생성
                UserThread obj = new UserThread();
                user[i] = new Thread(()=>obj.run());
                user[i].Name = (i + 1).ToString();
                user[i].Start();
            }
        }
    }

    public class UserThread
    {
        public void run()
        {
            Printer printer = Printer.Instance;
            if(Int32.Parse(Thread.CurrentThread.Name)%2==0)
                printer.print(Thread.CurrentThread.Name + " print using ");
            else
                printer.print2(Thread.CurrentThread.Name + " print using ");
        }
    }

    class Geek
    {

        // Method of Geek class 
        public void value()
        {
            // Fetching the name of  
            // the current thread 
            // Using Name property 
            Thread thr = Thread.CurrentThread;
            Console.WriteLine("The name of the current " +
                               "thread is: " + thr.Name);
        }
    }
}
