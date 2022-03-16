using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class ThickDoughPizza : Pizza
    {
        public override void MakeDough()
        {
            //Make thick dough
        }

        public override string GetIngredients()
        {
            return "Thick Dough Pizza with";
        }
    }
}
