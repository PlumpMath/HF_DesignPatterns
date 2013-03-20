using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HF_DesignPatterns
{
    internal class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Sorry, I can't quack! <mute>");
        }
    }
}
