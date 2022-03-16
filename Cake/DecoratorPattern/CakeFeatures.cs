using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public abstract class CakeFeature : Cake
    {

        public Cake MyCake {get; set;}
        public override abstract string GetFeature();

    }
}
