using UnityEngine;

namespace Extension
{
	public static class QuaternionExtension
	{
        /// <summary>
        /// Smoothly adjusts the current quaternion rotation towards a target direction.
        /// </summary>
        /// <param name="currentRotation">The current rotation quaternion.</param>
        /// <param name="targetDirection">The target direction vector.</param>
        /// <param name="rotationSpeed">The speed of the rotation adjustment. Adjust as needed.</param>
        /// <returns>The smoothly adjusted quaternion rotation.</returns>
        public static Quaternion SmoothlyRotateTowards(this Quaternion currentRotation, Vector3 targetDirection, float rotationSpeed)
        {
            if (targetDirection.sqrMagnitude < Mathf.Epsilon)
            {
                // No need to rotate if the target direction is very small
                return currentRotation;
            }

            targetDirection.Normalize();
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            return Quaternion.Slerp(currentRotation, targetRotation, rotationSpeed);
        }


    }
}
