using System;

namespace StrategyPattern {
    class MuteQuack : IQuackBehavior {
        public void quack() {
            Console.WriteLine("<< Silence >>");
        }
    }
}
