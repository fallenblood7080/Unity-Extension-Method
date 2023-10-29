using UnityEngine;

namespace Extension
{
    public static class PhysicsExtension
    {
        /// <summary>
        /// Checks if a LayerMask includes a specific layer.
        /// </summary>
        /// <param name="mask">The LayerMask to check for layer inclusion.</param>
        /// <param name="layer">The layer index to check for inclusion.</param>
        /// <returns>True if the LayerMask includes the specified layer; otherwise, false.</returns>
        public static bool IncludesLayer(this LayerMask mask, int layer)
        {
            return (mask.value & 1 << layer) > 0;
        }
    }
}
