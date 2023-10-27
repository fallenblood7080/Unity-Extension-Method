using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extension.Example
{
    public class DebugVisualExtensionExample : MonoBehaviour
    {
        [Header("Polygon")]
        [SerializeField] private Vector2 polygonCenter;
        [SerializeField] private float radius;
        [SerializeField] private Color shapeColor = Color.white;
        [SerializeField] private int vertices = 64;
        [SerializeField] private float rotationAngle = 0;

        [Header("Ray Visualizer")]
        [SerializeField] private Transform rayOrigin;
        [SerializeField] private Color rayColor = Color.green;

        [Header("Line")]
        [SerializeField] private Transform start;
        [SerializeField] private Transform end;
        [SerializeField] private Color lineColor = Color.red;

        [Header("Line from points")]
        [SerializeField] private Vector3[] points;
        [SerializeField] private Color linesColor = Color.blue;
        void Update()
        {
            float duration = Time.deltaTime;

            polygonCenter.DrawPolygon(radius,shapeColor,vertices,rotationAngle,duration);

            RaycastHit2D rayHit;
            rayHit = Physics2D.Raycast(rayOrigin.position, rayOrigin.up);
            rayHit.VisualizeRay(rayOrigin.position, rayColor,duration);

            start.position.DrawLineTo(end.position, lineColor, duration);

            points.DrawLineFromPoints(linesColor, duration);
        }
    } 
}
