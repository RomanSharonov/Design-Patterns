using System;

namespace StrategyPattern {
    class Quack : IQuackBehavior {
        public void quack() {
            Console.WriteLine("Quack");
        }
    }
}
