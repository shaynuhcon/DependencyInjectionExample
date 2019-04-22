using System;
using DI.Core.Interfaces;

namespace DI.Core.Services
{
    public class WhiteBread : IBread
    {
        public void Add()
        {
            Console.WriteLine("Added white bread");
        }
    }
}
