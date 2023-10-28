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
        /// <param name="orientation">Orientation 2D shape in world</param>
        /// <param name="color">Color Of Outline</param>
        /// <param name="vertices">No of vertices </param>
        /// <param name="dur">how long the circle should appear in seconds</param>
        public static void DrawPolygon(this Vector3 center, float radius, Quaternion orientation, Color color, int vertices = 32, float dur = 0.1f)
        {
            if(vertices < 3)
            {
                vertices = 3;
            }
            float angleStep = (360.0f / vertices);
            angleStep *= Mathf.Deg2Rad;

            Vector3 pointStart = Vector3.zero;
            Vector3 pointEnd = Vector3.zero;

            for (int i = 0; i < vertices; i++)
            {
                pointStart.x = Mathf.Cos(angleStep * i);
                pointStart.y = Mathf.Sin(angleStep * i);
                pointStart.z = 0.0f;
                pointEnd.x = Mathf.Cos(angleStep * (i + 1));
                pointEnd.y = Mathf.Sin(angleStep * (i + 1));
                pointEnd.z = 0.0f;

                pointStart *= radius;
                pointEnd *= radius;

                pointStart = orientation * pointStart;
                pointEnd = orientation * pointEnd;

                pointStart += center;
                pointEnd += center;
                Debug.DrawLine(pointStart, pointEnd, color,dur);
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
