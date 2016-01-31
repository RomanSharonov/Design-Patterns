using System;

namespace FactoryPattern {
    class Program {
        static void Main(string[] args) {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            nyPizzaStore.OrderPizza("cheese");

            Console.ReadKey();
        }
    }
}
