using UnityEngine;

namespace Extension
{
    public static class Physics2DExtension
    {
        public static void Add2DExplosiveForce(this Vector2 point, float range, float forceAmt)
        {
            Collider2D[] cols = Physics2D.OverlapCircleAll(point, range);
            if(cols!= null)
            {
                foreach (Collider2D col in cols)
                {
                    Vector2 dir = (Vector2)col.transform.position - point;
                    col.attachedRigidbody.AddForce(dir.normalized * (forceAmt/dir.magnitude), ForceMode2D.Impulse);
                }
            }
        }
    }
}
