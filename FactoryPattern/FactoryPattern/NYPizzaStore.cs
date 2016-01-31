namespace FactoryPattern {
    public class NYPizzaStore : PizzaStore {
        protected override Pizza CreatePizza(string item) {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (item.Equals("cheese")) {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("New York style cheese pizza");
            }

            return pizza;
        }
    }
}