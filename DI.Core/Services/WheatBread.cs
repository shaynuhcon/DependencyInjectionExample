using System;
using DI.Core.Interfaces;

namespace DI.Core.Services
{
    public class WheatBread : IBread
    {
        public void Add()
        {
            Console.WriteLine("Added wheat bread");
        }
    }
}
