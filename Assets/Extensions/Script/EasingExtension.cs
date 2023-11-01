using UnityEngine;

namespace Extension
{
    public static class EasingExtensions
    {
        public static float LerpLinear(this float t, float max = 1f)
        {
            float result = t * max;
            return (result > max) ? max : result;
        }

        public static float LerpEaseInQuad(this float t, float max = 1f)
        {
            float result = t * t * max;
            return (result > max) ? max : result;
        }
        public static float LerpEaseOutQuad(this float t, float max = 1f)
        {
            float result = max - (max - t * t * max);
            return (result > max) ? max : result;
        }

        public static float LerpEaseInOutQuad(this float t, float max = 1f)
        {
            float result = (t < 0.5) ? t * t * max * 2 : max - Mathf.Pow(max * 2 * t - 2, 2) / 2;
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
