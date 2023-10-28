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
        /// Draw the Polygon Outline.
        /// Useful for drawing various polygons like squares, hexagons, and circles.
        /// <code>
        /// shapeCenter.DrawPolygon(radius: 5, orientation: Quaternion.identity, color: Color.white, vertices: 6) // Create a hexagon
        /// </code>
        /// </summary>
        /// <param name="center">Center of the polygon coordinate in Vector3D.</param>
        /// <param name="radius">Radius of the polygon, representing the distance from the center to a vertex.</param>
        /// <param name="orientation">Orientation of the 2D shape in the world as a Quaternion.</param>
        /// <param name="color">Color of the outline.</param>
        /// <param name="vertices">Number of vertices to determine the shape's sides (e.g., 3 for a triangle, 4 for a square).</param>
        /// <param name="dur">Duration for which the polygon should appear in seconds.</param>
        public static void DrawPolygon(this Vector3 center, float radius, Quaternion orientation, Color color, int vertices = 32, float dur = 0.1f)
        {
            if(vertices < 3)
            {
                vertices = 3;
            }
            float angleStep = (360.0f / vertices);
            angleStep *= Mathf.Deg2Rad;

            Vector3 pointStart;
            Vector3 pointEnd;

            for (int i = 0; i < vertices; i++)
            {
                pointStart = new Vector3(Mathf.Cos(angleStep * i), Mathf.Sin(angleStep * i), 0.0f);
                pointEnd = new Vector3(Mathf.Cos(angleStep * (i + 1)), Mathf.Sin(angleStep * (i + 1)), 0.0f);

                pointStart *= radius;
                pointEnd *= radius;

                pointStart = orientation * pointStart;
                pointEnd = orientation * pointEnd;

                pointStart += center;
                pointEnd += center;
                Debug.DrawLine(pointStart, pointEnd, color,dur);
            }

        }
        /// <summary>
        /// Visualizes a ray by drawing a line from the specified origin to the point where it hits an object.
        /// </summary>
        /// <param name="ray2D">The RaycastHit2D result representing the intersection of the ray with an object.</param>
        /// <param name="origin">The starting point of the ray in 2D space.</param>
        /// <param name="color">The color of the visualization line.</param>
        /// <param name="dur">The duration for which the visualization line should appear in seconds.</param>
        public static void VisualizeRay(this RaycastHit2D ray2D, Vector2 origin, Color color, float dur = 0.1f)
        {
            Debug.DrawLine(origin, ray2D.point, color, dur);
        }
        /// <summary>
        /// Visualizes a ray by drawing a line from the specified origin to the point where it hits an object.
        /// </summary>
        /// <param name="ray">The RaycastHit result representing the intersection of the ray with an object.</param>
        /// <param name="origin">The starting point of the ray in 3D space.</param>
        /// <param name="color">The color of the visualization line.</param>
        /// <param name="dur">The duration for which the visualization line should appear in seconds.</param>
        public static void VisualizeRay(this RaycastHit ray, Vector2 origin, Color color, float dur = 0.1f)
        {
            Debug.DrawLine(origin, ray.point, color, dur);
        }
        /// <summary>
        /// Draws a straight line from the specified 'origin' point to the 'end' point with the given color.
        /// </summary>
        /// <param name="origin">The starting point of the line in 3D space.</param>
        /// <param name="end">The ending point of the line in 3D space.</param>
        /// <param name="color">The color of the drawn line.</param>
        /// <param name="dur">The duration for which the line should be visible in seconds.</param>
        public static void DrawLineTo(this Vector3 origin, Vector3 end, Color color, float dur = 0.1f)
        {
            Debug.DrawLine(origin, end, color, dur);
        }
        /// <summary>
        /// Draws a series of lines connecting the points in the provided array, creating a continuous path.
        /// </summary>
        /// <param name="points">An array of Vector3 points representing the path to be drawn.</param>
        /// <param name="color">The color of the drawn lines.</param>
        /// <param name="dur">The duration for which the lines should be visible in seconds.</param>
        public static void DrawLineFromPoints(this Vector3[] points, Color color, float dur = 0.1f)
        {
            for (int i = 0; i < points.Length - 1; i++)
            {
                Vector3 start = points[i];
                Vector3 end = points[i + 1];

                Debug.DrawLine(start, end, color, dur);
            }
        }
        /// <summary>
        /// Draws a series of lines connecting the points in the provided List, creating a continuous path.
        /// </summary>
        /// <param name="points">A List of Vector3 points representing the path to be drawn.</param>
        /// <param name="color">The color of the drawn lines.</param>
        /// <param name="dur">The duration for which the lines should be visible in seconds.</param>
        public static void DrawLineFromPoints(this List<Vector3> points, Color color, float dur = 0.1f)
        {
            for (int i = 0; i < points.Count - 1; i++)
            {
                Vector3 start = points[i];
                Vector3 end = points[i + 1];

                Debug.DrawLine(start, end, color, dur);
            }
        }
        /// <summary>
        /// Draws a 3D sphere with the specified center, radius, orientation, color, and level of detail (segments).
        /// </summary>
        /// <param name="center">The center of the sphere in 3D space.</param>
        /// <param name="radius">The radius of the sphere, determining its size.</param>
        /// <param name="orientation">The orientation of the sphere as a Quaternion.</param>
        /// <param name="color">The color of the sphere's outline.</param>
        /// <param name="segments">The number of segments used to approximate the sphere's surface (for smoother rendering).</param>
        /// <param name="dur">The duration for which the sphere should appear in seconds.</param>
        public static void DrawSphere(this Vector3 center,float radius, Quaternion orientation,Color color,int segments = 16,float dur = 0.1f)
        {
            if(segments < 2)
            {
                segments = 2;
            }
            float merdianSteps = 180 / segments;
            for (int i = 0; i < segments; i++)
            {
                center.DrawPolygon(radius,orientation * Quaternion.Euler(0, merdianSteps * i, 0), color, segments * 2, dur);
            }

            float parallelAngleStep = Mathf.PI / segments;
            float stepRadius;
            float stepAngle;

            for (int i = 1; i < segments; i++)
            {
                stepAngle = parallelAngleStep * i;
                Vector3 verticalOffset = Mathf.Cos(stepAngle) * radius * new Vector3(0,1,0);
                stepRadius = Mathf.Sin(stepAngle) * radius;

                (center + verticalOffset).DrawPolygon(stepRadius, orientation * Quaternion.Euler(90, 0, 0), color, segments * 2, dur);
            }
        }
    } 
}
