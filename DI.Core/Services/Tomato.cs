using System;
using DI.Core.Interfaces;

namespace DI.Core.Services
{
    public class Tomato : IVeggie
    {
        public void Add()
        {
            Console.WriteLine("Added tomato");
        }
    }
}
