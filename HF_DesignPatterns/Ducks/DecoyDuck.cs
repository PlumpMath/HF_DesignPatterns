using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HF_DesignPatterns
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck() {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new MuteQuack();
            swimBehaviour = new SwimNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("I am a Decoy duck!");
        }
    }
}
