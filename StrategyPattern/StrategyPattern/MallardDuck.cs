using System;

namespace StrategyPattern {
    public class MallardDuck : Duck {
        public MallardDuck() {
            _quackBehavior = new Quack();
            _flyBehavior = new FlyWithWings();
        }

        public override void Display() {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
