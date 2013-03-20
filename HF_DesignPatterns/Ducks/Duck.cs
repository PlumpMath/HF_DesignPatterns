using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HF_DesignPatterns
{
    public abstract class Duck
    {
        internal IFlyBehaviour flyBehaviour;
        internal IQuackBehaviour quackBehaviour;
        internal ISwimBehaviour swimBehaviour;

        public void PerformQuack() {
            quackBehaviour.Quack();
        }
        public void PerformSwim() {
            swimBehaviour.Swim();
        }
        public abstract void Display();

        public void PerformFly() {
            this.flyBehaviour.Fly();
        }
        public void SetFlyBehaviour(IFlyBehaviour flyBehaviour) {
            this.flyBehaviour = flyBehaviour;
        }
    }
}
