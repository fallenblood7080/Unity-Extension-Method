
using System;
using System.Collections;
using UnityEngine;

namespace Extension
{
    /// <summary>
    /// Contains Extension Methods related Audio and Audio Source etc..
    /// </summary>
    public static class AudioExtension
    {
        /// <summary>
        /// Plays an AudioSource with a fade-in effect.
        /// </summary>
        /// <param name="audioSource">The AudioSource to play with the fade-in effect.</param>
        /// <param name="fadeDuration">The duration of the fade-in effect in seconds.</param>
        /// <param name="easeType">The type of easing to use for the fade-in animation.</param>
        /// <param name="targetVolume">The target volume to reach at the end of the fade-in (default is 1).</param>
        /// <param name="OnFadeInComplete">An optional callback to invoke when the fade-in is complete.</param>
        public static void PlayFadeIn(this AudioSource audioSource, float fadeDuration, EaseType easeType,float targetVolume = 1, Action OnFadeInComplete = null)
        {
            audioSource.volume = 0;
            audioSource.Play();
            audioSource.gameObject.GetComponent<MonoBehaviour>().StartCoroutine(AudioFadeIn(audioSource,fadeDuration,targetVolume, easeType,OnFadeInComplete));
        }
        /// <summary>
        /// Stops an AudioSource with a fade-out effect.
        /// </summary>
        /// <param name="audioSource">The AudioSource to stop with the fade-out effect.</param>
        /// <param name="fadeDuration">The duration of the fade-out effect in seconds.</param>
        /// <param name="easeType">The type of easing to use for the fade-out animation.</param>
        /// <param name="OnFadeOutComplete">An optional callback to invoke when the fade-out is complete.</param>
        public static void StopFadeOut(this AudioSource audioSource, float fadeDuration, EaseType easeType, Action OnFadeOutComplete = null)
        {
            audioSource.gameObject.GetComponent<MonoBehaviour>().StartCoroutine(AudioFadeOut(audioSource, fadeDuration, easeType, true,OnFadeOutComplete));
        }
        /// <summary>
        /// Plays an AudioSource with a fade-out effect in the end.
        /// </summary>
        /// <param name="audioSource">The AudioSource to play with the fade-out effect.</param>
        /// <param name="fadeDuration">The duration of the fade-out effect in seconds.</param>
        /// <param name="easeType">The type of easing to use for the fade-out animation.</param>
        /// <param name="OnFadeOutComplete">An optional callback to invoke when the fade-out is complete.</param>
        public static void PlayFadeOut(this AudioSource audioSource, float fadeDuration, EaseType easeType, Action OnFadeOutComplete = null)
        {
            audioSource.Play();
            audioSource.gameObject.GetComponent<MonoBehaviour>().StartCoroutine(AudioFadeOut(audioSource, fadeDuration, easeType, false,OnFadeOutComplete));
        }
        /// <summary>
        /// Plays an AudioSource with a fade-in followed by a fade-out effect.
        /// </summary>
        /// <param name="audioSource">The AudioSource to play with the fade-in and fade-out effects.</param>
        /// <param name="fadeInDuration">The duration of the fade-in effect in seconds.</param>
        /// <param name="fadeOutDuration">The duration of the fade-out effect in seconds.</param>
        /// <param name="easeType">The type of easing to use for the fade-in and fade-out animations.</param>
        /// <param name="targetVolume">The target volume to reach at the end of the fade-in (default is 1).</param>
        /// <param name="OnFadeInComplete">An optional callback to invoke when the fade-in is complete.</param>
        /// <param name="OnFadeOutComplete">An optional callback to invoke when the fade-out is complete.</param>
        public static void PlayFadeInOut(this AudioSource audioSource, float fadeInDuration, float fadeOutDuration, EaseType easeType, float targetVolume = 1, Action OnFadeInComplete = null, Action OnFadeOutComplete = null)
        {
            audioSource.PlayFadeIn(fadeInDuration, easeType, targetVolume, () =>
            {
                OnFadeInComplete?.Invoke();
                audioSource.gameObject.GetComponent<MonoBehaviour>().StartCoroutine(AudioFadeOut(audioSource, fadeOutDuration, easeType, false,() => 
                {
                    OnFadeOutComplete?.Invoke();
                    if (audioSource.loop)
                    {
                        audioSource.PlayFadeInOut(fadeInDuration,fadeOutDuration,easeType,targetVolume,OnFadeInComplete,OnFadeOutComplete);
                    }
                }));
            });
        }

        private static IEnumerator AudioFadeIn(AudioSource audioSource, float duration, float targetVolume, EaseType ease, Action OnFadeInComplete = null)
        {
            float currentTime = 0;
            while (currentTime < duration)
            {
                currentTime += Time.deltaTime;
                float t = currentTime / duration;
                if (ease == EaseType.Linear) audioSource.volume = t.LerpLinear(targetVolume);
                else if (ease == EaseType.EaseIn) audioSource.volume = t.LerpEaseInQuad(targetVolume);
                else if (ease == EaseType.EaseOut) audioSource.volume = t.LerpEaseOutQuad(targetVolume);
                else if (ease == EaseType.EaseInOut) audioSource.volume = t.LerpEaseOutQuad(targetVolume);
                yield return null;
            }
            OnFadeInComplete?.Invoke();
            yield break;
        }
        private static IEnumerator AudioFadeOut(AudioSource audioSource, float duration, EaseType ease, bool forceStop, Action OnFadeOutComplete = null)
        {
            float currentTime = 0;
            float startVolume = audioSource.volume;
            float playbackTime = audioSource.time;
            if (!forceStop)
            {
                while (true)
                {
                    playbackTime += Time.deltaTime;
                    if ((audioSource.clip.length - playbackTime) <= duration)
                    {
                        currentTime += Time.deltaTime;
                        float t = currentTime / duration;

                        if (ease == EaseType.Linear) audioSource.volume = startVolume - t.LerpLinear();
                        else if (ease == EaseType.EaseIn) audioSource.volume = startVolume - t.LerpEaseInQuad();
                        else if (ease == EaseType.EaseOut) audioSource.volume = startVolume - t.LerpEaseOutQuad();
                        else if (ease == EaseType.EaseInOut) audioSource.volume = startVolume - t.LerpEaseOutQuad(); 

                        if(audioSource.volume <= 0.001)
                        {
                            break;
                        }
                    }

                    yield return null;
                }
            }
            else
            {
                while (currentTime < duration)
                {
                    currentTime += Time.deltaTime;
                    float t = currentTime / duration;
                    if (ease == EaseType.Linear) audioSource.volume = startVolume - t.LerpLinear();
                    else if (ease == EaseType.EaseIn) audioSource.volume = startVolume - t.LerpEaseInQuad();
                    else if (ease == EaseType.EaseOut) audioSource.volume = startVolume - t.LerpEaseOutQuad();
                    else if (ease == EaseType.EaseInOut) audioSource.volume = startVolume - t.LerpEaseOutQuad();

                    if (audioSource.volume <= 0.001)
                    {
                        audioSource.Stop();
                    }

                    yield return null;
                }
            }
            OnFadeOutComplete?.Invoke();
            yield break;
        }
    }
}
