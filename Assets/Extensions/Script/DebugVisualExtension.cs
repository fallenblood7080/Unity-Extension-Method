using UnityEngine;

namespace Extension
{
    /// <summary>
    /// This class contains set of extension method which allows you to debug in unity by visual.
    /// These Extension methods are just alternative of <b>OnGizmosDraw.</b> <br></br>
    /// With the help of this you quickly draw shapes to determine radius of enemy, FOV, draw line from A to B etc. easily
    /// </summary>
    public static class DebugVisualExtension
    {
        /// <summary>
        /// Draw the Circle Outline
        /// <code>
        /// circleCenter.DrawCircle(radius: 5, color: Color.white)
        /// </code>
        /// </summary>
        /// <param name="center">Center of Circle coordinate in vector 2D </param>
        /// <param name="radius">Radius of circle</param>
        /// <param name="color">Color Of Circle Outline</param>
        /// <param name="segments">No of vertices in circle</param>
        /// <param name="dur">how long the circle should appear in seconds</param>
        public static void DrawCircle(this Vector2 center, float radius, Color color, int segments = 32, float dur = 1)
        {
            Vector2[] points = new Vector2[segments];
            float angleIncrement = 2 * Mathf.PI / segments;

            for (int i = 0; i < segments; i++)
            {
                float angle = i * angleIncrement;
                Vector2 point = new(center.x + radius * Mathf.Cos(angle), center.y + radius * Mathf.Sin(angle));
                points[i] = point;
            }

            for (int i = 0; i < segments - 1; i++)
            {
                Debug.DrawLine(points[i], points[i + 1], color, dur);
            }

            Debug.DrawLine(points[segments - 1], points[0], color, dur);
        }
    } 
}
