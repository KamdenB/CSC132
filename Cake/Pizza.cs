using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class Pizza
    {
        public void PreparePizza()
        {
        }

        private void AddSauce()
        {
        }

        public virtual void MakeDough()
        {
        }

        private void PutInOven()
        {
        }

        private void PrepareSauce()
        {
        }

        public virtual string GetIngredients()
        {
            return "Pizza with ";
        }
    }
}
