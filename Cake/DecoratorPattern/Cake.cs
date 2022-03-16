using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class Cake
    {
        public virtual void PrepareCake()
        {
        }

        private void AddFrosting()
        {
        }

        public virtual void AddSprinkles()
        {
        }


        public virtual string GetFeature()
        {
            return "Cake with ";
        }
    }
}
