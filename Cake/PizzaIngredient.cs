using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public abstract class PizzaIngredient : Pizza
    {

        public Pizza MyPizza {get; set;}
        public override abstract string GetIngredients();

    }
}
