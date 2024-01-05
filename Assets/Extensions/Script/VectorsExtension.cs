using UnityEngine;

namespace Extension
{
	public static class VectorsExtension
	{
        #region NearestPointOnAxis
        /// <summary>
        /// Finds the nearest point on a specified axis to a given point in 3D space.
        /// </summary>
        /// <param name="axisDirection">The direction vector of the axis.</param>
        /// <param name="point">The 3D point for which you want to find the nearest point on the axis.</param>
        /// <param name="isNormalized">Indicates whether the <paramref name="axisDirection"/> vector is already normalized. Default is <c>false</c>.</param>
        /// <returns>The nearest point on the axis to the input <paramref name="point"/>.</returns>
        public static Vector3 NearestPointOnAxis(this Vector3 axisDirection, Vector3 point, bool isNormalized = false)
        {
            float dotProduct;
            if (!isNormalized)
            {
                float sqrMagnitude = axisDirection.sqrMagnitude;

                // Check if the vector is not a zero vector
                if (sqrMagnitude > float.Epsilon)
                {
                    dotProduct = Vector3.Dot(point, axisDirection) / sqrMagnitude;
                    return axisDirection * dotProduct;
                }
            }

            // If the vector is already normalized or is a zero vector, perform the dot product without normalization
            dotProduct = Vector3.Dot(point, axisDirection);
            return axisDirection * dotProduct;
        }
        /// <summary>
        /// Finds the nearest point on a specified axis to a given point in 2D space.
        /// </summary>
        /// <param name="axisDirection">The direction vector of the axis.</param>
        /// <param name="point">The 2D point for which you want to find the nearest point on the axis.</param>
        /// <param name="isNormalized">Indicates whether the <paramref name="axisDirection"/> vector is already normalized. Default is <c>false</c>.</param>
        /// <returns>The nearest point on the axis to the input <paramref name="point"/>.</returns>
        public static Vector2 NearestPointOnAxis(this Vector2 axisDirection, Vector2 point, bool isNormalized = false)
        {
            float dotProduct;
            if (!isNormalized)
            {
                float sqrMagnitude = axisDirection.sqrMagnitude;

                // Check if the vector is not a zero vector
                if (sqrMagnitude > float.Epsilon)
                {
                    dotProduct = Vector2.Dot(point, axisDirection) / sqrMagnitude;
                    return axisDirection * dotProduct;
                }
            }

            // If the vector is already normalized or is a zero vector, perform the dot product without normalization
            var d = Vector2.Dot(point, axisDirection);
            return axisDirection * d;
        }
        #endregion

        #region NearestPointOnLine
        /// <summary>
        /// Finds the nearest point on a specified line to a given point in 3D space.
        /// </summary>
        /// <param name="lineDirection">The direction vector of the line.</param>
        /// <param name="point">The 3D point for which you want to find the nearest point on the line.</param>
        /// <param name="pointOnLine">A point on the line used as a reference for calculations.</param>
        /// <param name="isNormalized">Indicates whether the <paramref name="lineDirection"/> vector is already normalized. Default is <c>false</c>.</param>
        /// <returns>The nearest point on the line to the input <paramref name="point"/>.</returns>
        public static Vector3 NearestPointOnLine(this Vector3 lineDirection, Vector3 point, Vector3 pointOnLine, bool isNormalized = false)
        {
            if (!isNormalized)
            {
                float sqrMagnitude = lineDirection.sqrMagnitude;

                // Check if the vector is not a zero vector
                if (sqrMagnitude > float.Epsilon)
                {
                    lineDirection.Normalize();
                }
            }

            float d = Vector3.Dot(point - pointOnLine, lineDirection);
            return pointOnLine + (lineDirection * d);
        }
        /// <summary>
        /// Finds the nearest point on a specified line to a given point in 2D space.
        /// </summary>
        /// <param name="lineDirection">The direction vector of the line.</param>
        /// <param name="point">The 2D point for which you want to find the nearest point on the line.</param>
        /// <param name="pointOnLine">A point on the line used as a reference for calculations.</param>
        /// <param name="isNormalized">Indicates whether the <paramref name="lineDirection"/> vector is already normalized. Default is <c>false</c>.</param>
        /// <returns>The nearest point on the line to the input <paramref name="point"/>.</returns>
        public static Vector2 NearestPointOnLine(this Vector2 lineDirection, Vector2 point, Vector2 pointOnLine, bool isNormalized = false)
        {
            if (!isNormalized)
            {
                float sqrMagnitude = lineDirection.sqrMagnitude;

                // Check if the vector is not a zero vector
                if (sqrMagnitude > float.Epsilon)
                {
                    lineDirection.Normalize();
                }
            }

            var d = Vector2.Dot(point - pointOnLine, lineDirection);
            return pointOnLine + (lineDirection * d);
        }
        #endregion

        #region GetClosestVectorFrom
        /// <summary>
        /// Finds the vector in an array that is closest to a specified reference vector in 2D space.
        /// </summary>
        /// <param name="vector">The reference vector for which you want to find the closest vector.</param>
        /// <param name="otherVectors">An array of Vector2 vectors from which to find the closest vector.</param>
        /// <returns>The Vector2 vector from the array that is closest to the reference vector.</returns>
        public static Vector2 GetClosestVectorFrom(this Vector2 vector, Vector2[] otherVectors)
        {
            // Early exit for an empty array
            if (otherVectors.Length == 0)
            {
                Debug.LogError("The list of other vectors is empty");
                return Vector2.zero;
            }

            // Initialize variables to store the minimum squared distance and corresponding vector
            var minSqrDistance = Vector2.SqrMagnitude(vector - otherVectors[0]);
            var minVector = otherVectors[0];

            // Iterate through the array of other vectors
            for (var i = otherVectors.Length - 1; i > 0; i--)
            {
                // Calculate the squared distance between the reference vector and the current other vector
                var newSqrDistance = Vector2.SqrMagnitude(vector - otherVectors[i]);

                // Check if the new squared distance is smaller than the current minimum squared distance
                if (newSqrDistance < minSqrDistance)
                {
                    // Update the minimum squared distance and corresponding vector
                    minSqrDistance = newSqrDistance;
                    minVector = otherVectors[i];
                }
            }

            // Return the Vector2 vector from the array that has the minimum squared distance to the reference vector
            return minVector;
        }

        /// <summary>
        /// Finds the vector in an array that is closest to a specified reference vector in 3D space.
        /// </summary>
        /// <param name="vector">The reference vector for which you want to find the closest vector.</param>
        /// <param name="otherVectors">An array of Vector3 vectors from which to find the closest vector.</param>
        /// <returns>The Vector3 vector from the array that is closest to the reference vector.</returns>
        public static Vector3 GetClosestVectorFrom(this Vector3 vector, Vector3[] otherVectors)
        {
            // Early exit for an empty array
            if (otherVectors.Length == 0)
            {
                Debug.LogError("The list of other vectors is empty");
                return Vector3.zero;
            }
            // Initialize variables to store the minimum squared distance and corresponding vector
            var minSqrDistance = Vector3.SqrMagnitude(vector - otherVectors[0]);
            var minVector = otherVectors[0];

            // Iterate through the array of other vectors
            for (var i = otherVectors.Length - 1; i > 0; i--)
            {
                // Calculate the squared distance between the reference vector and the current other vector
                var newSqrDistance = Vector3.SqrMagnitude(vector - otherVectors[i]);

                // Check if the new squared distance is smaller than the current minimum squared distance
                if (newSqrDistance < minSqrDistance)
                {
                    // Update the minimum squared distance and corresponding vector
                    minSqrDistance = newSqrDistance;
                    minVector = otherVectors[i];
                }
            }

            // Return the Vector3 vector from the array that has the minimum squared distance to the reference vector
            return minVector;
        }
        #endregion

    }


}