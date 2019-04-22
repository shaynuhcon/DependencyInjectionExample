using DI.Core.Interfaces;
using DI.Core.Services;

namespace DoNotWant
{
    public class Sandwich : ISandwich
    {
        private IBread wheat = new WheatBread();
        private IMeat ham = new Ham();
        private IVeggie lettuce = new Lettuce();

        public void MakeSandwich()
        {
            wheat.Add();
            ham.Add();
            lettuce.Add();
        }
    }
}
