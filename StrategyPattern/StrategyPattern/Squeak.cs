using System;

namespace StrategyPattern {
    class Squeak : IQuackBehavior {
        public void quack() {
            Console.WriteLine("Squeak");
        }
    }
}
