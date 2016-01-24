using System;

namespace StrategyPattern {
    class Program {
        static void Main(string[] args) {

            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuak();
            mallard.Display();
            mallard.Swim();

            Console.ReadKey();
        }
    }
}
