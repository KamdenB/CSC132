using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class VanillaCake : Cake
    {
        public override void PrepareCake()
        {
            //Make Vanilla cake
        }

        public override string GetFeature()
        {
            return "Vanilla batter with ";
        }
    }
}
