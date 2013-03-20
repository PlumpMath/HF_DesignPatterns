using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HF_DesignPatterns
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Sorry, I can't fly!");
        }
    }
}
