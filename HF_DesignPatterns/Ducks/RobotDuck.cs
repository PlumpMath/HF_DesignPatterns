using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HF_DesignPatterns
{
    public class RobotDuck : Duck
    {
        public RobotDuck()
        {
            flyBehaviour = new FlyRocketPowered();
            quackBehaviour = new Quack();
            swimBehaviour = new SwimNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("I am a Robot duck!");
        }
    }
}
