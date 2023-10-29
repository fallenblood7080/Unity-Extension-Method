using UnityEngine;

namespace Extension
{
    public static class CameraExtension
    {
        /// <summary>
        /// Converts a 2D world point to a screen point based on the specified camera's perspective.
        /// </summary>
        /// <param name="point">The 2D world point to convert.</param>
        /// <param name="cam">The Camera used for the conversion.</param>
        /// <returns>A Vector2 representing the screen point in pixels.</returns>
        public static Vector2 WorldToScreenPoint(this Vector2 point, Camera cam)
        {
            return cam.WorldToScreenPoint(point);
        }
        /// <summary>
        /// Converts a 3D world point to a screen point based on the specified camera's perspective.
        /// </summary>
        /// <param name="point">The 3D world point to convert.</param>
        /// <param name="cam">The Camera used for the conversion.</param>
        /// <returns>A Vector3 representing the screen point in pixels.</returns>
        public static Vector3 WorldToScreenPoint(this Vector3 point, Camera cam)
        {
            return cam.WorldToScreenPoint(point);
        }
        /// <summary>
        /// Converts a 2D world point to a viewport point based on the specified camera's perspective.
        /// </summary>
        /// <param name="point">The 2D world point to convert.</param>
        /// <param name="cam">The Camera used for the conversion.</param>
        /// <returns>A Vector2 representing the viewport point in normalized coordinates.</returns>
        public static Vector2 WorldToViewportPoint(this Vector2 point, Camera cam)
        {
            return cam.WorldToViewportPoint(point);
        }
        /// <summary>
        /// Converts a 3D world point to a viewport point based on the specified camera's perspective.
        /// </summary>
        /// <param name="point">The 3D world point to convert.</param>
        /// <param name="cam">The Camera used for the conversion.</param>
        /// <returns>A Vector3 representing the viewport point in normalized coordinates.</returns>
        public static Vector3 WorldToViewportPoint(this Vector3 point, Camera cam)
        {
            return cam.WorldToViewportPoint(point);
        }
        /// <summary>
        /// Converts a 3D screen point to a world point in the 3D scene based on the specified camera's perspective.
        /// </summary>
        /// <param name="point">The 3D screen point to convert.</param>
        /// <param name="cam">The Camera used for the conversion.</param>
        /// <returns>A Vector3 representing the world point in 3D space.</returns>
        public static Vector3 ScreenToWorldPoint(this Vector3 point, Camera cam)
        {
            return cam.ScreenToWorldPoint(point);
        }
        /// <summary>
        /// Converts a 2D screen point to a world point in the 2D scene based on the specified camera's perspective.
        /// </summary>
        /// <param name="point">The 2D screen point to convert.</param>
        /// <param name="cam">The Camera used for the conversion.</param>
        /// <returns>A Vector2 representing the world point in 2D space.</returns>
        public static Vector2 ScreenToWorldPoint(this Vector2 point, Camera cam)
        {
            return cam.ScreenToWorldPoint(point);
        }
        /// <summary>
        /// Converts a 3D screen point to a viewport point in normalized coordinates based on the specified camera's perspective.
        /// </summary>
        /// <param name="point">The 3D screen point to convert.</param>
        /// <param name="cam">The Camera used for the conversion.</param>
        /// <returns>A Vector3 representing the viewport point in normalized coordinates.</returns>
        public static Vector3 ScreenToViewportPoint(this Vector3 point, Camera cam)
        {
            return cam.ScreenToViewportPoint(point);
        }
        /// <summary>
        /// Converts a 2D screen point to a viewport point in normalized coordinates based on the specified camera's perspective.
        /// </summary>
        /// <param name="point">The 2D screen point to convert.</param>
        /// <param name="cam">The Camera used for the conversion.</param>
        /// <returns>A Vector2 representing the viewport point in normalized coordinates.</returns>
        public static Vector2 ScreenToViewportPoint(this Vector2 point, Camera cam)
        {
            return cam.ScreenToViewportPoint(point);
        }
        /// <summary>
        /// Creates a Ray originating from the specified screen point based on the specified camera's perspective.
        /// </summary>
        /// <param name="point">The screen point to originate the Ray.</param>
        /// <param name="cam">The Camera used for the Ray creation.</param>
        /// <returns>A Ray originating from the screen point in the camera's perspective.</returns>
        public static Ray ScreenToRay(this Vector3 point, Camera cam)
        {
            return cam.ScreenPointToRay(point);
        }
        /// <summary>
        /// Converts a 3D viewport point in normalized coordinates to a screen point in pixels based on the specified camera's perspective.
        /// </summary>
        /// <param name="point">The 3D viewport point to convert.</param>
        /// <param name="cam">The Camera used for the conversion.</param>
        /// <returns>A Vector3 representing the screen point in pixels.</returns>
        public static Vector3 ViewportToScreenPoint(this Vector3 point, Camera cam)
        {
            return cam.ViewportToScreenPoint(point);
        }
        /// <summary>
        /// Converts a 2D viewport point in normalized coordinates to a screen point in pixels based on the specified camera's perspective.
        /// </summary>
        /// <param name="point">The 2D viewport point to convert.</param>
        /// <param name="cam">The Camera used for the conversion.</param>
        /// <returns>A Vector2 representing the screen point in pixels.</returns>
        public static Vector2 ViewportToScreenPoint(this Vector2 point, Camera cam)
        {
            return cam.ViewportToScreenPoint(point);
        }
        /// <summary>
        /// Converts a 3D viewport point in normalized coordinates to a world point in the 3D scene based on the specified camera's perspective.
        /// </summary>
        /// <param name="point">The 3D viewport point to convert.</param>
        /// <param name "cam">The Camera used for the conversion.</param>
        /// <returns>A Vector3 representing the world point in 3D space.</returns>
        public static Vector3 ViewportToWorldPoint(this Vector3 point, Camera cam)
        {
            return cam.ViewportToWorldPoint(point);
        }
        /// <summary>
        /// Converts a 2D viewport point in normalized coordinates to a world point in the 2D scene based on the specified camera's perspective.
        /// </summary>
        /// <param name="point">The 2D viewport point to convert.</param>
        /// <param name="cam">The Camera used for the conversion.</param>
        /// <returns>A Vector2 representing the world point in 2D space.</returns>
        public static Vector2 ViewportToWorldPoint(this Vector2 point, Camera cam)
        {
            return cam.ViewportToWorldPoint(point);
        }
        /// <summary>
        /// Creates a Ray originating from the specified viewport point in normalized coordinates based on the specified camera's perspective.
        /// </summary>
        /// <param name="point">The viewport point to originate the Ray.</param>
        /// <param name="cam">The Camera used for the Ray creation.</param>
        /// <returns>A Ray originating from the viewport point in the camera's perspective.</returns>

        public static Ray ViewportToRay(this Vector3 point, Camera cam)
        {
            return cam.ViewportPointToRay(point);
        }
    }
}
