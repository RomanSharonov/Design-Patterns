using System;
using System.Collections.Generic;

namespace CompositePattern {
    public class Menu {
        List<Menu> _menuComponents = new List<Menu>();
        public string Name { get; private set; }
        public string Descriprion { get; private set; }

        public Menu(string name, string descriprion) {
            Name = name;
            Descriprion = descriprion;
        }

        public void Add(Menu menuComponent) {
            _menuComponents.Add(menuComponent);
        }

        public void Remove(Menu menuComponent) {
            _menuComponents.Remove(menuComponent);
        }

        public Menu GetChild(int i) {
            return _menuComponents[i];
        }

        public void Print() {
            foreach (var menu in _menuComponents) {
                Console.Write(menu.Name);
                Console.WriteLine(menu.Descriprion);
                Console.WriteLine("--------------------------");
            }
        }
    }
}