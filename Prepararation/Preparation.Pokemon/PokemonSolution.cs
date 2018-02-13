using System;

namespace Preparation.Pokemon
{
    public class PokemonSolution
    {
        public static void Main()
        {
            uint pokePower = uint.Parse(Console.ReadLine());
            uint pokeTargetDistance = uint.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());

            uint targetsPoked = 0;
            uint changingPokePower = pokePower;
            uint halfPokePower = pokePower / 2;
            while (changingPokePower >= pokeTargetDistance)
            {
                if (changingPokePower == halfPokePower && exhaustionFactor != 0)
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
