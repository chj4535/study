using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_study
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robotA = new RobotForm("A");
            Robot robotB = new RobotForm("B");
            robotA.SetAttackStrategy(new MissileStrategy());
            robotA.SetMovingStrategy(new FlyingStrategy());
            robotB.SetAttackStrategy(new PunchStrategy());
            robotB.SetMovingStrategy(new WalkingStrategy());

            Console.WriteLine("my name is "+robotA.getName());
            robotA.attack();
            robotA.move();

            Console.WriteLine("my name is " + robotB.getName());
            robotB.attack();
            robotB.move();
        }
    }
}
