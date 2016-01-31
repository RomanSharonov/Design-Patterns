using System;

namespace StrategyPattern {
    public abstract class Duck {
        protected IQuackBehavior _quackBehavior;
        protected IFlyBehavior _flyBehavior;

        public void SetFlyBehavior(IFlyBehavior flyBehavior) {
            _flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior) {
            _quackBehavior = quackBehavior;
        }

        public void PerformQuak() {
            _quackBehavior.quack();
        }

        public void PerformFly() {
            _flyBehavior.fly();
        }

        public abstract void Display();

        public void Swim() {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
