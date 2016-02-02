using System;

namespace CompositePattern {
    class Program {
        static void Main(string[] args) {
            var menu1 = new Menu("Pancake menu", "Breakfast");
            var menu2 = new Menu("Dinner menu", "Lunch");
            var menu3 = new Menu("Cafe", "Dinner");
            var menu4 = new Menu("Desert menu", "Desert");

            var allMenus = new Menu("All menus", "All menus Combined");

            allMenus.Add(menu1);
            allMenus.Add(menu2);
            allMenus.Add(menu3);

            menu2.Add(menu4);

            var waitress = new Waitress(allMenus);
            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}
