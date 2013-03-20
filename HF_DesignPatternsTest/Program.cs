using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HF_DesignPatterns;

namespace HF_DesignPatternsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallard = new MallardDuck();
            RedHeadDuck redHead = new RedHeadDuck();
            RubberDuck rubber = new RubberDuck();
            DecoyDuck decoy = new DecoyDuck();
            RobotDuck robot = new RobotDuck();
            ModelDuck model = new ModelDuck();

            PerformDuckFunctions(mallard);
            PerformDuckFunctions(redHead);
            PerformDuckFunctions(rubber);
            PerformDuckFunctions(decoy);
            PerformDuckFunctions(robot);
            PerformDuckFunctions(model);

            model.SetFlyBehaviour(new FlyRocketPowered());
            PerformDuckFunctions(model);

            Console.ReadKey();
        }

        private static void PerformDuckFunctions(Duck duck)
        {
            duck.Display();
            duck.PerformQuack();
            duck.PerformSwim();
            duck.PerformFly();
            
            Console.WriteLine();
        }
    }
}
