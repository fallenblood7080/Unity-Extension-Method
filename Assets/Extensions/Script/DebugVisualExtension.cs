using System.Collections.Generic;
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
        /// Draw the Polygon Outline<br></br>
        /// Useful for drawing Square,hexgon,circle
        /// <code>
        /// shapeCenter.DrawPolygon(radius: 5, color: Color.white,vertices:6) //create the hexagon
        /// </code>
        /// </summary>
        /// <param name="center">Center of polygon coordinate in vector 2D </param>
        /// <param name="radius">radius of poltgon, just the distance from center to vertex</param>
        /// <param name="color">Color Of Outline</param>
        /// <param name="vertices">No of vertices </param>
        /// <param name="rotationAngle">How much shape will rotate in degree</param>
        /// <param name="dur">how long the circle should appear in seconds</param>
        public static void DrawPolygon(this Vector2 center, float radius, Color color, int vertices = 32, float rotationAngle = 0, float dur = 0.1f)
        {
            if (vertices > 0)
            {
                Vector2[] points = new Vector2[vertices];
                float angleIncrement = 2 * Mathf.PI / vertices;

                for (int i = 0; i < vertices; i++)
                {
                    float angle = i * angleIncrement + (Mathf.Deg2Rad * rotationAngle);
                    Vector2 point = new(center.x + radius * Mathf.Cos(angle), center.y + radius * Mathf.Sin(angle));
                    points[i] = point;
                }

                for (int i = 0; i < vertices - 1; i++)
                {
                    Debug.DrawLine(points[i], points[i + 1], color, dur);
                }

                Debug.DrawLine(points[vertices - 1], points[0], color, dur); 
            }
        }

        public static void VisualizeRay(this RaycastHit2D ray2D, Vector2 origin, Color color, float dur = 0.1f)
        {
            Debug.DrawLine(origin, ray2D.point, color, dur);
        }
        public static void VisualizeRay(this RaycastHit ray, Vector2 origin, Color color, float dur = 0.1f)
        {
            Debug.DrawLine(origin, ray.point, color, dur);
        }

        public static void DrawLineTo(this Vector3 origin, Vector3 end, Color color, float dur = 0.1f)
        {
            Debug.DrawLine(origin, end, color, dur);
        }

        public static void DrawLineFromPoints(this Vector3[] points, Color color, float dur = 0.1f)
        {
            for (int i = 0; i < points.Length - 1; i++)
            {
                Vector3 start = points[i];
                Vector3 end = points[i + 1];

                Debug.DrawLine(start, end, color, dur);
            }
        }
        public static void DrawLineFromPoints(this List<Vector3> points, Color color, float dur = 0.1f)
        {
            for (int i = 0; i < points.Count - 1; i++)
            {
                Vector3 start = points[i];
                Vector3 end = points[i + 1];

                Debug.DrawLine(start, end, color, dur);
            }
        }
    } 
}
