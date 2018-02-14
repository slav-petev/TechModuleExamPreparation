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
            while (changingPokePower >= pokeTargetDistance)
            {
                if (changingPokePower == halfPokePower && exhaustionFactor > 1)
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
