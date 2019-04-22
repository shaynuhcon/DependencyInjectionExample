using DI.Core.Interfaces;

namespace DependencyInjectionExample
{
    public class Sandwich : ISandwich
    {
        private IBread _bread;
        private IMeat _meat;
        private IVeggie _veggie;

        public Sandwich(IBread bread, IMeat meat, IVeggie veggie)
        {
            _bread = bread;
            _meat = meat;
            _veggie = veggie;
        }


        public void MakeSandwich()
        {
            _bread.Add();
            _meat.Add();
            _veggie.Add();
        }
    }
}
