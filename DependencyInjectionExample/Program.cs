using System;
using Autofac;
using DI.Core.Interfaces;
using DI.Core.Services;

namespace DependencyInjectionExample
{
    /**
     * Dependencies are injected through constructor as interfaces to abstract from concrete classes
     * and can be changed at runtime. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<WheatBread>().As<IBread>().InstancePerLifetimeScope();
            builder.RegisterType<Ham>().As<IMeat>().InstancePerLifetimeScope();
            builder.RegisterType<Lettuce>().As<IVeggie>().InstancePerLifetimeScope();
            builder.RegisterType<Sandwich>().As<ISandwich>().InstancePerLifetimeScope();

            builder.RegisterType<SandwichBuilderOne>();
            builder.RegisterType<SandwichBuilderTwo>();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var sandwichOne = scope.Resolve<SandwichBuilderOne>();
                sandwichOne.BuildSandwich();

                Console.WriteLine();

                var sandwichTwo = scope.Resolve<SandwichBuilderTwo>();
                sandwichTwo.BuildSandwich();
            }

            Console.ReadLine();
        }
    }
}
