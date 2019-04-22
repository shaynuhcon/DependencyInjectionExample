using DI.Core.Interfaces;
using DI.Core.Services;

namespace DoNotWant2
{
    public class Sandwich : ISandwich
    {
        private WheatBread _wheat;
        private Ham _ham;
        private Lettuce _lettuce;

        public Sandwich(WheatBread wheat, Ham ham, Lettuce lettuce)
        {
            _wheat = wheat;
            _ham = ham;
            _lettuce = lettuce;
        }

        public void MakeSandwich()
        {
            _wheat.Add();
            _ham.Add();
            _lettuce.Add();
        }
    }
}
