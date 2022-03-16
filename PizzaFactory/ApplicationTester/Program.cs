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
            CrustyDoughPizza myFirstPizza = new CrustyDoughPizza();
            //Decorate the pizza with olive
            Olive olivePizza = new Olive(myFirstPizza);
            var firstPizzaIngredients = olivePizza.GetIngredients();
            //expected answer = Crusty pizza with olive

            ThickDoughPizza mySecondPizza = new ThickDoughPizza();
            //Decorate the pizza with Meat
            Meat pizzaWithMeat = new Meat(mySecondPizza);
            //Decorate the pizza with cheese
            Cheese pizzaWithCheese = new Cheese(pizzaWithMeat);
            var secondPizzaIngredients = pizzaWithCheese.GetIngredients();
            //expected answer = Crusty pizza with meat cheese

            Console.WriteLine(string.Format("First Pizza is a {0}\n Second Pizza is a {1}", firstPizzaIngredients, secondPizzaIngredients));
            Console.ReadLine();
        }
    }
}
