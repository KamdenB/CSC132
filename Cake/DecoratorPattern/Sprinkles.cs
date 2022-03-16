using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class Sprinkles : CakeFeature
    {
        public Sprinkles(Cake cake)
        {
            MyCake = cake;
        }
        public override string GetFeature()
        {
            return MyCake.GetFeature() + " Sprinkles ";
        }
    }
}
