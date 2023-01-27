using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();

            espresso = new Mocha(espresso);

            Console.WriteLine(espresso.getDescription() + " Р " + espresso.cost());

            Beverage darkRoast = new DarkRoast();

            darkRoast = new Milk(darkRoast);

            Console.WriteLine(darkRoast.getDescription() + " Р " + darkRoast.cost());

        }
    }
}
