using System;

namespace DoNotWant2
{
    /**
     * This project shows what happens when dependencies are passed through constructor without DI. In this case
     * they still need to be added everywhere the Sandwich class is used and any time we call
     * Sandwich, we will also need to call WheatBread, Ham, and Lettuce as well and if our parameters
     * change, we have to change that everywhere Sandwich is called
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Call one class which depends on Sandwich class
            var sandwichOne = new SandwichBuilderOne();
            sandwichOne.BuildSandwich();

            Console.WriteLine();

            // Call second class which depends on Sandwich class also
            var sandwichTwo = new SandwichBuilderTwo();
            sandwichTwo.BuildSandwich();

            Console.ReadLine();
        }
    }
}
