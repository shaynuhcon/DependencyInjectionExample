using DI.Core.Services;

namespace DoNotWant2
{
    public class SandwichBuilderOne
    {
        // Have to call each dependency to pass to constructor 
        private static WheatBread wheat = new WheatBread();
        private static Ham ham = new Ham();
        private static Lettuce lettuce = new Lettuce();

        private Sandwich sandwich = new Sandwich(wheat, ham, lettuce);

        public void BuildSandwich()
        {
            sandwich.MakeSandwich();
        }
    }
}
