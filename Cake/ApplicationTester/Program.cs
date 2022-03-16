using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorPattern;

namespace ApplicationTester
{
    class Program
    {
        static void Main(string[] args)
        {
   
            VanillaCake myFirstCake = new VanillaCake();
            Frosting frostingCake = new Frosting(myFirstCake);
            var firstCakeIngredients = frostingCake.GetFeature();

            ChocolateCake mySecondCake = new ChocolateCake();
            Sprinkles sprinklesCake = new Sprinkles(mySecondCake);
            var secondCakeIngredients = sprinklesCake.GetFeature();

            Console.WriteLine(string.Format("First cake is a {0}\n Second cake is a {1}", firstCakeIngredients, secondCakeIngredients));
            Console.ReadLine();

        }
    }
}
