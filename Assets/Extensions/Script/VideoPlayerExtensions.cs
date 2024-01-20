// call SmoothVideoPause and pass the duration for pausing/unpausing and a bool(if pausing the true if unpausing then false)

using UnityEngine;
using System.Collections;
using UnityEngine.Video;

namespace Extension
{
    public static class VideoPlayerExtensions
    {
        public static void SmoothVideoPause(this VideoPlayer videoPlayer, float fadeDuration = 0.5f, bool pause = true)
        {
            videoPlayer.gameObject.GetComponent<MonoBehaviour>().StartCoroutine(SmoothVideoPauseCoroutine(videoPlayer, fadeDuration, pause));
        }
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
                videoPlayer.Pause();   // If pausing
            }
            else
            {
                videoPlayer.Play();
            }
        }
    }
}