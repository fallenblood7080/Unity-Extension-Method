using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extension
{
    /// <summary>
    /// Some Extra Extension which are or are not related Unity,mainly C-Sharp Extensions
    /// </summary>
    public static class CommonExtension
    {
        /// <summary>
        /// Write the log(string message) in console.Equivalent to Debug.Log()
        /// Example:
        /// <code>
        /// "Message".Log();
        /// "Message in RedColor".Log(logColorCode: "#ff0000");
        /// "Message in Red Color with 18 font Size".Log(logColorCode: "#ff0000",fontSize: 18);
        /// </code>
        /// </summary>
        /// <param name="message">Message to be wrriten in Unity Console</param>
        /// <param name="logColorCode">hexcode of color</param>
        /// <param name="fontSize">font size of message</param>
        public static void Log(this string message, string logColorCode = "#ffffff", int fontSize = 12)
        {
            Debug.Log($"<color={logColorCode}><size={fontSize}>{message}</size></color>");
        }
        /// <summary>
        /// Retrieves a random selection of items from the  List.
        /// </summary>
        /// <typeparam name="T">The type of elements in the List.</typeparam>
        /// <param name="list">The List of items from which to select randomly.</param>
        /// <param name="count">The number of random items to retrieve from the List.</param>
        /// <returns>A List of random items, containing 'count' elements, randomly selected from the input List.</returns>
        public static List<T> GetRandomItems<T>(this List<T> list, int count)
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
