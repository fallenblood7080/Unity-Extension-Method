using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extension
{
    /// <summary>
    /// Extension related to generating Random Data.
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
        public static List<T> GetRandomItems<T>(this List<T> items, int count = 1)
        {
            System.Random random = new();
            List<T> list = items.ToList();
            int n = list.Count; 
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (list[i], list[j]) = (list[j], list[i]);
            }
            return list.Take(count).ToList();
        }
        /// <summary>
        /// Retrieves a random selection of items from the  array.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array.</typeparam>
        /// <param name="items">The array  of items from which to select randomly.</param>
        /// <param name="count">The number of random items to retrieve from the array.</param>
        /// <returns>A array of random items, containing 'count' elements, randomly selected from the input array.</returns>
        public static T[] GetRandomItems<T>(this T[] items, int count = 1)
        {
            System.Random random = new();
            List<T> list = items.ToList();
            int n = list.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (list[i], list[j]) = (list[j], list[i]);
            }
            return list.Take(count).ToArray();
        }

        /// <summary>
        /// Generates a random 2D point within a circular area defined by a center and radius.
        /// </summary>
        /// <param name="center">The center of the circle in 2D space.</param>
        /// <param name="radius">The radius of the circle, determining the distance from the center to the generated point.</param>
        /// <returns>A randomly generated Vector2 point within the specified circle.</returns>
        public static Vector2 GetRandomPointInCircle(this Vector2 center, float radius)
        {
            float randomAngle = Random.Range(0f, 2f * Mathf.PI);
            float randomDistance = Random.Range(0f, radius); 
            float x = center.x + randomDistance * Mathf.Cos(randomAngle);
            float y = center.y + randomDistance * Mathf.Sin(randomAngle);
            return new(x,y);
        }
        /// <summary>
        /// Generates a random 3D point within a spherical volume defined by a center and radius.
        /// </summary>
        /// <param name="center">The center of the sphere in 3D space.</param>
        /// <param name="radius">The radius of the sphere, determining the distance from the center to the generated point.</param>
        /// <returns>A randomly generated Vector3 point within the specified sphere.</returns>
        public static Vector3 GetRandomPointInSphere(this Vector3 center, float radius)
        {
            float randomRadius = Random.Range(0f, radius);
            float randomTheta = Random.Range(0f, 2f * Mathf.PI);
            float randomPhi = Random.Range(0f, Mathf.PI);            

            float x = center.x + randomRadius * Mathf.Sin(randomPhi) * Mathf.Cos(randomTheta);
            float y = center.y + randomRadius * Mathf.Sin(randomPhi) * Mathf.Sin(randomTheta);
            float z = center.z + randomRadius * Mathf.Cos(randomPhi);

            return new Vector3(x, y, z);
        }

    }
}
