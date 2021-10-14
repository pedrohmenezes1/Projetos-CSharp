using System;
using System.Collections.Generic;
class intercalar
{
    static void Main(string[] args)
    {
      int[] numeros = {1,2,3};
      Intercalar<int>(numeros, 3);

      Console.Write("===========================\n");

      string[] strings = { "Papel","Lápis","Borracha"};
      Intercalar<string>(strings, 3);

    }

    static void Intercalar<T>(IEnumerable<T> input, int count)
    {
        foreach (IEnumerable<T> permutation in PermuteUtils.Permute<T>(input, count))
        {
            foreach (T i in permutation)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }
    }
}
public class PermuteUtils
{
    public static IEnumerable<IEnumerable<T>> Permute<T>(IEnumerable<T> list, int count)
    {
        if (count == 0)
        {
            yield return new T[0];
        }
        else
        {
            int startingElementIndex = 0;
            foreach (T startingElement in list)
            {
                IEnumerable<T> remainingItems = AllExcept(list, startingElementIndex);

                foreach (IEnumerable<T> permutationOfRemainder in Permute(remainingItems, count - 1))
                {
                    yield return Concat<T>(
                        new T[] { startingElement },
                        permutationOfRemainder);
                }
                startingElementIndex += 1;
            }
        }
    }

    public static IEnumerable<T> Concat<T>(IEnumerable<T> a, IEnumerable<T> b)
    {
        foreach (T item in a) { yield return item; }
        foreach (T item in b) { yield return item; }
    }

    public static IEnumerable<T> AllExcept<T>(IEnumerable<T> input, int indexToSkip)
    {
        int index = 0;
        foreach (T item in input)
        {
            if (index != indexToSkip) yield return item;
            index += 1;
        }
    }
}