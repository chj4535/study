using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_study
{
    public interface MovingStrategy{ void move(); }

    public class FlyingStrategy : MovingStrategy
    {
        public void move() { Console.WriteLine("I can fly."); }
    }
    public class WalkingStrategy : MovingStrategy
    {
        public void move() { Console.WriteLine("I can only walk."); }
    }
}