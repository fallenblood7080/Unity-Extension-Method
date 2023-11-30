using UnityEngine;

namespace Extension
{
    public static class EasingExtensions
    {
        /// <summary>
        /// Linear interpolation between 0 and a specified maximum value.
        /// </summary>
        /// <param name="t">The interpolation factor (usually between 0 and 1).</param>
        /// <param name="max">The maximum value to interpolate to (default is 1).</param>
        /// <returns>The result of linear interpolation between 0 and the specified maximum value.</returns>
        public static float LerpLinear(this float t, float max = 1f)
        {
            float result = t * max;
            return (result > max) ? max : result;
        }

        /// <summary>
        /// Ease-in quadratic interpolation between 0 and a specified maximum value.
        /// </summary>
        /// <param name="t">The interpolation factor (usually between 0 and 1).</param>
        /// <param name="max">The maximum value to interpolate to (default is 1).</param>
        /// <returns>The result of ease-in quadratic interpolation between 0 and the specified maximum value.</returns>
        public static float LerpEaseInQuad(this float t, float max = 1f)
        {
            float result = t * t * max;
            return (result > max) ? max : result;
        }

        /// <summary>
        /// Ease-out quadratic interpolation between 0 and a specified maximum value.
        /// </summary>
        /// <param name="t">The interpolation factor (usually between 0 and 1).</param>
        /// <param name="max">The maximum value to interpolate to (default is 1).</param>
        /// <returns>The result of ease-out quadratic interpolation between 0 and the specified maximum value.</returns>
        public static float LerpEaseOutQuad(this float t, float max = 1f)
        {
            float result = max - (max - t * t * max);
            return (result > max) ? max : result;
        }

        /// <summary>
        /// Ease-in-out quadratic interpolation between 0 and a specified maximum value.
        /// </summary>
        /// <param name="t">The interpolation factor (usually between 0 and 1).</param>
        /// <param name="max">The maximum value to interpolate to (default is 1).</param>
        /// <returns>The result of ease-in-out quadratic interpolation between 0 and the specified maximum value.</returns>
        public static float LerpEaseInOutQuad(this float t, float max = 1f)
        {
            float result = (t < 0.5f) ? t * t * max * 2 : max - Mathf.Pow(max * 2 * t - 2, 2) / 2;
            return (result > max) ? max : result;
        }

    }

    public enum EaseType
    {
        Linear,
        EaseIn,
        EaseOut,
        EaseInOut
    }

}
