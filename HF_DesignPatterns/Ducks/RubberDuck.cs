using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HF_DesignPatterns
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new Squeak();
            swimBehaviour = new SwimWithPride();
        }
        public override void Display()
        {
            Console.WriteLine("I am not a real duck.  I am a Rubber duck!");
        }
    }
}
