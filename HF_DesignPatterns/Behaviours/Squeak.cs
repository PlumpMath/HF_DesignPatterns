using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HF_DesignPatterns
{
    internal class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak! Squeak! Squeak!");
        }
    }
}
