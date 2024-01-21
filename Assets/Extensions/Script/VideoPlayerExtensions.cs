using UnityEngine;
using System.Collections;
using UnityEngine.Video;

namespace Extension
{
    /// <summary>
    /// Extension methods for the Unity VideoPlayer class.
    /// </summary>
    public static class VideoPlayerExtensions
    {
        /// <summary>
        /// Smoothly pauses or unpauses the VideoPlayer with a fade effect.
        /// </summary>
        /// <param name="videoPlayer">The VideoPlayer instance to be paused or unpaused.</param>
        /// <param name="fadeDuration">The duration of the fade effect in seconds. The default is 0.5 seconds.</param>
        /// <param name="pause">If true, pauses the video; if false, unpauses the video.</param>
        public static void SmoothVideoPause(this VideoPlayer videoPlayer, float fadeDuration = 0.5f, bool pause = true)
        {
            videoPlayer.gameObject.GetComponent<MonoBehaviour>().StartCoroutine(SmoothVideoPauseCoroutine(videoPlayer, fadeDuration, pause));
        }

        /// <summary>
        /// Coroutine for smoothly pausing or unpausing the VideoPlayer with a fade effect.
        /// </summary>
        /// <param name="videoPlayer">The VideoPlayer instance to be paused or unpaused.</param>
        /// <param name="fadeDuration">The duration of the fade effect in seconds. The default is 0.5 seconds.</param>
        /// <param name="pause">If true, pauses the video; if false, unpauses the video.</param>
        /// <returns>Yield instruction to wait for the coroutine to complete.</returns>
        private static IEnumerator SmoothVideoPauseCoroutine(VideoPlayer videoPlayer, float fadeDuration = 0.5f, bool pause = true)
        {
            float time = 0.0f;

            while (time < fadeDuration)
            {
                time += Time.deltaTime;
                float t = time / fadeDuration;
                float newPlaybackSpeed = pause ? Mathf.Lerp(1f, 0f, t) : Mathf.Lerp(0f, 1f, t);
                videoPlayer.playbackSpeed = newPlaybackSpeed;
                yield return null;
            }

            if (pause)
            {
                videoPlayer.Pause();
            }
            else
            {
                videoPlayer.Play();
            }
        }
    }
}
