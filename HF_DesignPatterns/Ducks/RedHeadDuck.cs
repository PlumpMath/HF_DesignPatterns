using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HF_DesignPatterns
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck() {
            flyBehaviour = new FlyWithwings();
            quackBehaviour = new Quack();
            swimBehaviour = new SwimWithPride();
        }
        public override void Display()
        {
            Console.WriteLine("I am a real Red Head duck!");
        }
    }
}
