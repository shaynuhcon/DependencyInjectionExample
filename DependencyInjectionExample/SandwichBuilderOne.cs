using DI.Core.Interfaces;

namespace DependencyInjectionExample
{
    public class SandwichBuilderOne
    {
        private ISandwich _sandwich;

        public SandwichBuilderOne(ISandwich sandwich)
        {
            _sandwich = sandwich;
        }

        public void BuildSandwich()
        {
            _sandwich.MakeSandwich();
        }
    }
}
