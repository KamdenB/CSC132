using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class Frosting : CakeFeature
    {
        public Frosting(Cake cake)
        {
            MyCake = cake;
        }

        public override string GetFeature()
        {
            return MyCake.GetFeature() + " Frosting ";
        }
    }
}
