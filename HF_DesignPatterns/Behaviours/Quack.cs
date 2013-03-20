using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HF_DesignPatterns
{
    internal class Quack : IQuackBehaviour
    {
        void IQuackBehaviour.Quack()
        {
            Console.WriteLine("Quack! Quack! Quack!");
        }
    }
}
