using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_study
{
    public abstract class Robot
    {
        private string name;
        public AttackStrategy attackStrategy;
        public MovingStrategy movingStrategy;
        protected Robot(string name){this.name = name; } //constructor
        public string getName(){return name;} //get name
        public void attack() { attackStrategy.attack(); }
        public void move() { movingStrategy.move(); }
        public void SetAttackStrategy(AttackStrategy attackStrategy) { this.attackStrategy = attackStrategy; }
        public void SetMovingStrategy(MovingStrategy movingStrategy) { this.movingStrategy = movingStrategy; }
    }

    public class RobotForm : Robot
    {
        public RobotForm(string name) : base(name)
        {

        }
    }
}
