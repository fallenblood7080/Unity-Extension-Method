using UnityEngine;

namespace Extension
{
    public static class GameObjectExtension
    {
        /// <summary>
        /// Checks if the GameObject has a specified MonoBehaviour component attached.
        /// </summary>
        /// <typeparam name="T">Type of the MonoBehaviour component to check for.</typeparam>
        /// <param name="gameObject">The GameObject to check.</param>
        /// <returns>True if the component is attached, false otherwise.</returns>
        public static bool HasComponent<T>(this GameObject gameObject) where T : Component
        {
            // Returns true if the component of type T is attached, otherwise false.
            return gameObject.GetComponent<T>() != null;
        }
    }
}
