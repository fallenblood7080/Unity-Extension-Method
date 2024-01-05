using System.Collections.Generic;
using UnityEngine;

namespace Extension
{
    public static class Physics2DExtension
    {
        /// <summary>
        /// Applies a 2D explosive force originating from the specified point, affecting nearby Rigidbody2D objects within the given range and based on the provided parameters.
        /// </summary>
        /// <param name="body">The Rigidbody2D object representing the point where the explosion originates.</param>
        /// <param name="range">The range within which Rigidbody2D objects are affected by the explosion.</param>
        /// <param name="forceAmt">The magnitude of the explosive force applied to Rigidbody2D objects.</param>
        /// <param name="explosionImpactLayer">A LayerMask specifying which layers the explosion can impact.</param>
        /// <returns>A list of Rigidbody2D objects that were affected by the explosive force.</returns>
        public static List<Rigidbody2D> Add2DExplosiveForce(this Rigidbody2D body, float range, float forceAmt, LayerMask explosionImpactLayer)
        {
            List<Rigidbody2D> affectedBodies = new List<Rigidbody2D>();
            Collider2D[] colliders = Physics2D.OverlapCircleAll(body.position, range, explosionImpactLayer);

            if (colliders == null) return affectedBodies;

            foreach (Collider2D col in colliders)
            {
                if (col.TryGetComponent<Rigidbody2D>(out var rb))
                {
                    Vector2 direction = rb.position - body.position;
                    float distance = direction.magnitude;

                    // Check if there are no obstacles between the explosion origin and the Rigidbody2D object
                    if (!Physics2D.Raycast(body.position, direction.normalized, distance, ~explosionImpactLayer))
                    {
                        // Apply explosive force to the Rigidbody2D object
                        rb.AddForce(direction.normalized * (forceAmt * Mathf.Exp(-distance)), ForceMode2D.Impulse);

                        // Add the Rigidbody2D object to the list of affected bodies
                        affectedBodies.Add(rb);
                    }
                }
            }

            // Return the list of Rigidbody2D objects that were affected by the explosive force
            return affectedBodies;
        }

    }
}
