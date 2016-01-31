using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern {
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory {
        public Dough CreateDough() {
            return new ThinCrustDough();
        }

        public Sause CreateSauce() {
            return new MarinaraSauce();
        }

        public Cheese CreateCheese() {
            return new RegdianoCheese();
        }

        public Veggies[] CreateVeggies() {
            Veggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }

        public Pepperoni CreatePepperoni() {
            return new SlicedPepperoni();
        }

        public Clams CreateClams() {
            return new FreshClams();
        }
    }
}
