using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class Cheese : PizzaIngredient
    {
        public Cheese(Pizza pizza)
        {
            MyPizza = pizza;
        }

        public override string GetIngredients()
        {
            return MyPizza.GetIngredients() + " Cheese ";
        }
    }
}
