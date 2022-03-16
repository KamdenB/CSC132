using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class ChocolateCake : Cake
    {
        public override void PrepareCake()
        {
            //Make cocolate cake
        }

        public override string GetFeature()
        {
            return "Chocolate batter with";
        }
    }
}
