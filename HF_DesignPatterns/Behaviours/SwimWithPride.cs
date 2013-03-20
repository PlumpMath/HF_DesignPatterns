using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HF_DesignPatterns
{
    internal class SwimWithPride : ISwimBehaviour
    {
        void ISwimBehaviour.Swim()
        {
            Console.WriteLine("I am swimming!");
        }
    }
}
