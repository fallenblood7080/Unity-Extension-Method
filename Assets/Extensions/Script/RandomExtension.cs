using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extension
{
    /// <summary>
    /// Some Extra Extension which are or are not related Unity,mainly C-Sharp Extensions
    /// </summary>
    public static class RandomExtension
    {

        /// <summary>
        /// Retrieves a random selection of items from the  List.
        /// </summary>
        /// <typeparam name="T">The type of elements in the List.</typeparam>
        /// <param name="list">The List of items from which to select randomly.</param>
        /// <param name="count">The number of random items to retrieve from the List.</param>
        /// <returns>A List of random items, containing 'count' elements, randomly selected from the input List.</returns>
        public static List<T> GetRandomItems<T>(this List<T> list, int count = 1)
        {
            System.Random random = new();
            int n = list.Count; 
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (list[i], list[j]) = (list[j], list[i]);
            }
            return list.Take(count).ToList();
        }
    }
}
