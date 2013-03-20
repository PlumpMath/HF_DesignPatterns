using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HF_DesignPatterns
{
    public class ModelDuck : Duck
    {
        public ModelDuck() {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new Quack();
            swimBehaviour = new SwimWithPride();
        }

        public override void Display()
        {
            Console.WriteLine("I am a model duck!");
        }
    }
}
