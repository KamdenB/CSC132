using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class CrustyDoughPizza : Pizza
    {
        public override void MakeDough()
        {
            //Make CrustyDough
        }

        public override string GetIngredients()
        {
            return "Crusty Dough Pizza with ";
        }
    }
}
