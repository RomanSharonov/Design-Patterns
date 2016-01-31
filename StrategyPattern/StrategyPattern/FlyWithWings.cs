using System;

namespace StrategyPattern {
    public class FlyWithWings : IFlyBehavior {
        public void fly() {
            Console.WriteLine("I'm flying!!");
        }
    }
}