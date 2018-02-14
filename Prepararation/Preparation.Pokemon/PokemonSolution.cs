using System;

namespace Preparation.Pokemon
{
    public class PokemonSolution
    {
        public static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeTargetDistance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int targetsPoked = 0;
            int changingPokePower = pokePower;
            int halfPokePower = pokePower / 2;

            //We can't divide by zero per definition and if we divide by 1, we won't change the value at all,
            //thus creating an infinite loop
            bool canDivideByExhaustionFactor = exhaustionFactor > 1;
            while (changingPokePower >= pokeTargetDistance)
            {
                if (changingPokePower == halfPokePower && canDivideByExhaustionFactor)
                {
                    changingPokePower /= exhaustionFactor;
                }
                else
                {
                    changingPokePower -= pokeTargetDistance;
                    targetsPoked++;
                }  
            }

            Console.WriteLine(changingPokePower);
            Console.WriteLine(targetsPoked);
        }
    }
}
