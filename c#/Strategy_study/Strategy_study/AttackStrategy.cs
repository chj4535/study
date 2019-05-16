using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_study
{
    public interface AttackStrategy { void attack(); }
    // 구체적인 클래스
    public class MissileStrategy : AttackStrategy
    {
        public void attack() { Console.WriteLine("I have Missile."); }
    }
    public class PunchStrategy : AttackStrategy
    {
        public void attack() { Console.WriteLine("I have strong punch."); }
    }
}
