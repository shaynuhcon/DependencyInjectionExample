using System;

namespace DoNotWant
{
    /**
     * In this project, our objects rely too much on the dependencies so now if we later want to change Ham to another
     * meat, we have to manually change it here or create another sandwich object and even then,
     * our sandwich relies too heavily on the objects that we are giving to it. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new Sandwich();
            sandwich.MakeSandwich();
            Console.ReadLine();
        }
    }
}
