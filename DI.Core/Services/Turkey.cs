using System;
using DI.Core.Interfaces;

namespace DI.Core.Services
{
    public class Turkey : IMeat
    {
        public void Add()
        {
            Console.WriteLine("Added turkey");
        }
    }
}
