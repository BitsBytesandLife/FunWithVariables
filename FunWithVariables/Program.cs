using System;

namespace FunWithVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Brian";
            int age = 43;
            char nickname = 'B';
            bool hasBeard = true;
            double powerLevel = 1000.00;
            decimal beardRating = 100m;

            Console.WriteLine($"Name:{name} Age:{age} Nickname:{nickname} \n" +
                $"Beard:{hasBeard} Power Level:{powerLevel} Beard Rating:{beardRating}");

            Console.ReadLine();
        }
    }
}
