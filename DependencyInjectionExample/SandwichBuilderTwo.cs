using DI.Core.Interfaces;

namespace DependencyInjectionExample
{
    public class SandwichBuilderTwo
    {
        private ISandwich _sandwich;

        public SandwichBuilderTwo(ISandwich sandwich)
        {
            _sandwich = sandwich;
        }

        public void BuildSandwich()
        {
            _sandwich.MakeSandwich();
        }
    }
}
