namespace FactoryPattern {
    public interface IPizzaIngredientFactory {
        Dough CreateDough();
        Sause CreateSauce();
        Cheese CreateCheese();
        Veggies[] CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClams();
    }
}