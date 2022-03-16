using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class Olive : PizzaIngredient
    {
        public Olive(Pizza pizza)
        {
            MyPizza = pizza;
        }

        public override string GetIngredients()
        {
            return MyPizza.GetIngredients() + " Olive ";
        }
    }
}
