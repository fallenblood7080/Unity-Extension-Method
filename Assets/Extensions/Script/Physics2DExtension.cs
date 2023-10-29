using UnityEngine;

namespace Extension
{
    public static class Physics2DExtension
    {
        /// <summary>
        /// Applies a 2D explosive force originating from the specified point, affecting nearby objects within the given range and based on the provided parameters.
        /// </summary>
        /// <param name="point">The 2D point where the explosion originates.</param>
        /// <param name="range">The range within which objects are affected by the explosion.</param>
        /// <param name="forceAmt">The magnitude of the explosive force applied to objects.</param>
        /// <param name="explosionImpactLayer">A LayerMask specifying which layers the explosion can impact.</param>
        public static void Add2DExplosiveForce(this Vector2 point, float range, float forceAmt, LayerMask explosionImpactLayer)
        {
            Collider2D[] cols = Physics2D.OverlapCircleAll(point, range, explosionImpactLayer);

            if (cols == null) return;

            foreach (Collider2D col in cols)
            {
                if (col.TryGetComponent<Rigidbody2D>(out var rb))
                {
                    Vector2 dir = rb.position - point;
                    float distance = dir.magnitude;

                    if (!Physics2D.Raycast(point, dir.normalized, distance, ~explosionImpactLayer))
                    {
                        rb.AddForce(dir.normalized * (forceAmt * Mathf.Exp(-distance)), ForceMode2D.Impulse);
                    }
                }
            }
        }
    }
}
