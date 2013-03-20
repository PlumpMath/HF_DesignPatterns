using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HF_DesignPatterns
{
    public class FlyWithwings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }
    }
}
