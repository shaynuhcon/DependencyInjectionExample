using System;
using DI.Core.Interfaces;

namespace DI.Core.Services
{
    public class Ham : IMeat
    {
        public void Add()
        {
            Console.WriteLine("Added ham");
        }
    }
}
