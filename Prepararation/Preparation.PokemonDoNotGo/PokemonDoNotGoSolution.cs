using System;
using System.Collections.Generic;
using System.Linq;

namespace Preparation.PokemonDoNotGo
{
    public class PokemonDoNotGoSolution
    {
        public static void Main()
        {
            List<long> pokemonIndices = Console.ReadLine()
                 .Split()
                 .Select(long.Parse)
                 .ToList();

            long removedElementsSum = 0;
            while (pokemonIndices.Count > 0)
            {
                int currentPokemonIndex = int.Parse(Console.ReadLine());
                if (currentPokemonIndex < 0)
                    removedElementsSum += RemoveElementForNegativeInputIndex(pokemonIndices);
                else if (currentPokemonIndex >= pokemonIndices.Count)
                    removedElementsSum +=RemoveElementForGreaterThanCountInputIndex(pokemonIndices);
                else
                    removedElementsSum +=RemoveElementValidInputIndex(currentPokemonIndex, pokemonIndices);
            }

            Console.WriteLine(removedElementsSum);
        }

        private static long RemoveElementForNegativeInputIndex(List<long> pokemonIndices)
        {
            long removedElement = pokemonIndices[0];
            pokemonIndices.RemoveAt(0);
            pokemonIndices.Insert(0, pokemonIndices[pokemonIndices.Count - 1]);
            ModifyRemainingIndices(removedElement, pokemonIndices);
            return removedElement;
        }

        private static void ModifyRemainingIndices(long removedElement, List<long> pokemonIndices)
        {
            for (int currentElementIndex = 0; currentElementIndex < pokemonIndices.Count; currentElementIndex++)
            {
                long currentElement = pokemonIndices[currentElementIndex];
                if (currentElement <= removedElement)
                    pokemonIndices[currentElementIndex] += removedElement;
                else
                    pokemonIndices[currentElementIndex] -= removedElement;
            }
        }

        private static long RemoveElementForGreaterThanCountInputIndex(List<long> pokemonIndices)
        {
            long removedElement = pokemonIndices[pokemonIndices.Count - 1];
            pokemonIndices.RemoveAt(pokemonIndices.Count - 1);
            pokemonIndices.Add(pokemonIndices[0]);
            ModifyRemainingIndices(removedElement, pokemonIndices);

            return removedElement;
        }

        private static long RemoveElementValidInputIndex(int validInputIndex, List<long> pokemonIndices)
        {
            long removedElement = pokemonIndices[validInputIndex];
            pokemonIndices.RemoveAt(validInputIndex);
            ModifyRemainingIndices(removedElement, pokemonIndices);

            return removedElement;
        }
    }
}
