using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extension.Example
{
    public class DebugVisualExtensionExample : MonoBehaviour
    {
        [Header("Polygon")]
        [SerializeField] private Transform polygonCenter;
        [SerializeField] private float radius;
        [SerializeField] private Color shapeColor = Color.white;
        [SerializeField] private int vertices = 64;

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

        [Header("Sphere")]
        [SerializeField] private Transform sphereCenter;
        [SerializeField] private float sphereRadius;
        [SerializeField] private Color sphereColor;
        [SerializeField] private int segments;
        void Update() 
        {
            float duration = Time.deltaTime;

            polygonCenter.position.DrawPolygon(radius, polygonCenter.rotation, shapeColor,vertices,duration);

            RaycastHit rayHit;

            if(Physics.Raycast(rayOrigin.position, rayOrigin.up, out rayHit))
            {
                rayHit.VisualizeRay(rayOrigin.position, rayColor, duration);
            }

            start.position.DrawLineTo(end.position, lineColor, duration);

            points.DrawLineFromPoints(linesColor, duration);

            sphereCenter.position.DrawSphere(sphereRadius,sphereCenter.rotation,sphereColor,segments,duration);
        }
    }  
}
