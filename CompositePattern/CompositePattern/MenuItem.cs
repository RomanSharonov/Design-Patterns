using System;

namespace CompositePattern {
    class MenuItem {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }

        public MenuItem(string name, string description, double price) {
            Name = name;
            Description = description;
            Price = price;
        }

        public new void Print() {
            Console.Write(Name);
            Console.WriteLine(Price);
            Console.WriteLine(Description);
        }
    }
}
