using System;
using DI.Core.Interfaces;

namespace DI.Core.Services
{
    public class Lettuce : IVeggie
    {
        public void Add()
        {
            Console.WriteLine("Added lettuce");
        }
    }
}
