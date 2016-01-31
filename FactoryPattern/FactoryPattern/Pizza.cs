using System;

namespace FactoryPattern {
    public abstract class Pizza {
        public String name;
        public Dough dough;
        public Sause sauce;
        public Cheese cheese;
        public Veggies[] veggies;
        public Pepperoni pepperoni;
        public Clams clams;

        public abstract void Prepare();

        public void Bake() {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut() {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box() {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public void SetName(String name) {
            this.name = name;
        }

        public string GetName() {
            return name;
        }
    }
}
