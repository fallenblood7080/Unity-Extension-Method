using System;
using System.Collections;
using System.IO;
using UnityEditor;
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
        public static void PlayFadeIn(this AudioSource audioSource, float fadeDuration, EaseType easeType, float targetVolume = 1, Action OnFadeInComplete = null)
        {
            audioSource.volume = 0;
            audioSource.Play();
            audioSource.gameObject.GetComponent<MonoBehaviour>().StartCoroutine(AudioFadeIn(audioSource, fadeDuration, targetVolume, easeType, OnFadeInComplete));
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
            audioSource.gameObject.GetComponent<MonoBehaviour>().StartCoroutine(AudioFadeOut(audioSource, fadeDuration, easeType, true, OnFadeOutComplete));
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
            audioSource.gameObject.GetComponent<MonoBehaviour>().StartCoroutine(AudioFadeOut(audioSource, fadeDuration, easeType, false, OnFadeOutComplete));
        }
        /// <summary>
        /// Plays an AudioSource with a fade-in followed by a fade-out effect.
        /// </summary>
        /// <param name="audioSource">The AudioSource to play with the fade-in and fade-out effects.</param>
        /// <param name="fadeInDuration">The duration of the fade-in effect in seconds.</param>
        /// <param name="fadeOutDuration">The duration of the fade-out effect in seconds.</param>
        /// <param name="fadeInEase">The type of easing to use for the fade-in and fade-out animations.</param>
        /// <param name="targetVolume">The target volume to reach at the end of the fade-in (default is 1).</param>
        /// <param name="OnFadeInComplete">An optional callback to invoke when the fade-in is complete.</param>
        /// <param name="OnFadeOutComplete">An optional callback to invoke when the fade-out is complete.</param>
        public static void PlayFadeInOut(this AudioSource audioSource, float fadeInDuration, float fadeOutDuration, EaseType fadeInEase, EaseType fadeOutEase, float targetVolume = 1, Action OnFadeInComplete = null, Action OnFadeOutComplete = null)
        {
            audioSource.PlayFadeIn(fadeInDuration, fadeInEase, targetVolume, () =>
            {
                OnFadeInComplete?.Invoke();
                audioSource.gameObject.GetComponent<MonoBehaviour>().StartCoroutine(AudioFadeOut(audioSource, fadeOutDuration, fadeOutEase, false, () =>
                {
                    OnFadeOutComplete?.Invoke();
                    if (audioSource.loop)
                    {
                        audioSource.PlayFadeInOut(fadeInDuration, fadeOutDuration, fadeInEase, fadeOutEase, targetVolume, OnFadeInComplete, OnFadeOutComplete);
                    }
                }));
            });
        }
        /// <summary>
        /// Plays a sequence of AudioSources with fade-in and fade-out effects, allowing for sequential playback.
        /// </summary>
        /// <param name="audioSourceSeq">An array of AudioSources to play in sequence.</param>
        /// <param name="fadeInDuration">The duration of the fade-in effect for each AudioSource in the sequence (in seconds).</param>
        /// <param name="fadeOutDuration">The duration of the fade-out effect for each AudioSource in the sequence (in seconds).</param>
        /// <param name="fadeInEase">The easing type for the fade-in animation.</param>
        /// <param name="fadeOutEase">The easing type for the fade-out animation.</param>
        /// <param name="shouldLoopSeq">Indicates whether the sequence should loop when it reaches the end.</param>
        /// <param name="targetVolume">The target volume to reach at the end of the fade-in (default is 1).</param>
        /// <param name="startingIndex">The index of the AudioSource to start the sequence from (default is 0).</param>
        /// <param name="OnFadeInComplete">An optional callback to invoke when each fade-in is complete.</param>
        /// <param name="OnFadeOutComplete">An optional callback to invoke when each fade-out is complete.</param>
        public static void PlayAudioSequence(this AudioSource[] audioSourceSeq, float fadeInDuration, float fadeOutDuration, EaseType fadeInEase, EaseType fadeOutEase, bool shouldLoopSeq = false, float targetVolume = 1, int startingIndex = 0, Action OnFadeInComplete = null, Action OnFadeOutComplete = null)
        {
            int index = startingIndex;
            audioSourceSeq[index].PlayFadeInOut(fadeInDuration, fadeOutDuration, fadeInEase, fadeOutEase, targetVolume, OnFadeInComplete, OnFadeOutComplete: () =>
            {
                OnFadeOutComplete?.Invoke();
                index++;
                index.ToString().Log();
                if (index >= audioSourceSeq.Length - 1)
                {
                    if (shouldLoopSeq)
                    {
                        index = 0;
                    }
                    else
                    {
                        return;
                    }
                }
                audioSourceSeq.PlayAudioSequence(fadeInDuration, fadeOutDuration, fadeInEase, fadeOutEase, shouldLoopSeq, targetVolume, index, OnFadeInComplete, OnFadeOutComplete);
            });
        }

        /// <summary>
        /// Plays a portion of the audio clip between specified start and end times.
        /// </summary>
        /// <param name="source">The AudioSource to play the portion on.</param>
        /// <param name="start">The start time of the portion (in seconds).</param>
        /// <param name="end">The end time of the portion (in seconds). If end is 0 then end will automatically set to clip length</param>
        public static void PlayPortion(this AudioSource source, float start, float end)
        {
            float stop = end;
            if (end <= 0 || end <= start)
            {
                stop = source.clip.length;
            }
            source.clip = source.clip.MakeSubclip(start, stop);
            source.Play();
        }
        /// <summary>
        /// Plays a portion of the audio clip between specified start and end times with a fade-in effect.
        /// </summary>
        /// <param name="source">The AudioSource to play the portion on.</param>
        /// <param name="start">The start time of the portion (in seconds).</param>
        /// <param name="end">The end time of the portion (in seconds).</param>
        /// <param name="fadeInDuration">The duration of the fade-in effect (in seconds).</param>
        /// <param name="fadeInEaseType">The easing type for the fade-in effect.</param>
        /// <param name="targetVolume">The target volume to reach at the end of the fade-in (default is 1).</param>
        /// <param name="OnFadeInComplete">An optional callback to invoke when the fade-in is complete.</param>
        public static void PlayPortionFadeIn(this AudioSource source, float start, float end, float fadeInDuration, EaseType fadeInEaseType, float targetVolume = 1, Action OnFadeInComplete = null)
        {
            float stop = end;
            if (end <= 0 || end <= start)
            {
                stop = source.clip.length;
            }
            source.clip = source.clip.MakeSubclip(start, stop);
            source.PlayFadeIn(fadeInDuration, fadeInEaseType, targetVolume, OnFadeInComplete);
        }
        /// <summary>
        /// Plays a portion of the audio clip between specified start and end times with a fade-out effect.
        /// </summary>
        /// <param name="source">The AudioSource to play the portion on.</param>
        /// <param name="start">The start time of the portion (in seconds).</param>
        /// <param name="end">The end time of the portion (in seconds).</param>
        /// <param name="fadeOutDuration">The duration of the fade-out effect (in seconds).</param>
        /// <param name="fadeOutEaseType">The easing type for the fade-out effect.</param>
        /// <param name="OnFadeOutComplete">An optional callback to invoke when the fade-out is complete.</param>
        public static void PlayPortionFadeOut(this AudioSource source, float start, float end, float fadeOutDuration, EaseType fadeOutEaseType, Action OnFadeOutComplete = null)
        {
            float stop = end;
            if (end <= 0 || end <= start)
            {
                stop = source.clip.length;
            }
            source.clip = source.clip.MakeSubclip(start, stop);
            source.PlayFadeOut(fadeOutDuration, fadeOutEaseType, OnFadeOutComplete);
        }

        /// <summary>
        /// Plays a portion of the audio clip between specified start and end times with both fade-in and fade-out effects.
        /// </summary>
        /// <param name="source">The AudioSource to play the portion on.</param>
        /// <param name="start">The start time of the portion (in seconds).</param>
        /// <param name="end">The end time of the portion (in seconds).</param>
        /// <param name="fadeInDuration">The duration of the fade-in effect (in seconds).</param>
        /// <param name="fadeOutDuration">The duration of the fade-out effect (in seconds).</param>
        /// <param name="fadeInEase">The easing type for the fade-in effect.</param>
        /// <param name="fadeOutEase">The easing type for the fade-out effect.</param>
        /// <param name="targetVolume">The target volume to reach at the end of the fade-in (default is 1).</param>
        /// <param name="OnFadeInComplete">An optional callback to invoke when the fade-in is complete.</param>
        /// <param name="OnFadeOutComplete">An optional callback to invoke when the fade-out is complete.</param>
        public static void PlayPortion(this AudioSource source, float start, float end, float fadeInDuration, float fadeOutDuration, EaseType fadeInEase, EaseType fadeOutEase, float targetVolume = 1, Action OnFadeInComplete = null, Action OnFadeOutComplete = null)
        {
            float stop = end;
            if (end <= 0 || end <= start)
            {
                stop = source.clip.length;
            }
            source.clip = source.clip.MakeSubclip(start, stop);
            source.PlayFadeInOut(fadeInDuration, fadeOutDuration, fadeInEase, fadeOutEase, targetVolume, OnFadeInComplete, OnFadeOutComplete);
        }
        /// <summary>
        /// Creates a subclip from the original AudioClip based on specified start and stop times.
        /// </summary>
        /// <param name="clip">The original AudioClip to create a subclip from.</param>
        /// <param name="start">The start time of the subclip (in seconds).</param>
        /// <param name="stop">The stop time of the subclip (in seconds).</param>
        /// <returns>A subclip of the original AudioClip.</returns>
        public static AudioClip MakeSubclip(this AudioClip clip, float start, float stop)
        {
            if(start >= stop)
            {
                Debug.LogError("MakeSubClip Stop Parameter must be greater than start!");
                return clip;
            }
            if(stop <= 0)
            {
                stop = clip.length;
            }
            int frequency = clip.frequency;
            float timeLength = stop - start;
            int samplesLength = (int)(frequency * timeLength);
            AudioClip newClip = AudioClip.Create(clip.name + "-sub", samplesLength, 1, frequency, false);
            float[] data = new float[samplesLength];
            clip.GetData(data, (int)(frequency * start));
            newClip.SetData(data, 0);
            return newClip;
        }
        /// <summary>
        /// Saves the AudioClip as a WAV file at the specified path.(EDITOR ONLY)
        /// </summary>
        /// <param name="clip">The AudioClip to save as a WAV file.</param>
        /// <param name="path">The file path where the WAV file will be saved.</param>
        public static void SaveClip(this AudioClip clip,string path)
        {
            // Ensure the directory exists
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Convert AudioClip to WAV format using WavUtility
            byte[] wavData = WAVUtlity.ClipToWav(clip);
            File.WriteAllBytes(path, wavData);

            AssetDatabase.Refresh();
            Debug.Log("AudioClip saved as WAV to: " + path);
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

                        if (audioSource.volume <= 0.001)
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

    #region IDK what is this but it's important
    public static class WAVUtlity
    {
        public static byte[] ClipToWav(AudioClip clip)
        {
            float[] floats = new float[clip.samples * clip.channels];
            clip.GetData(floats, 0);

            byte[] bytes = new byte[floats.Length * 2];

            for (int ii = 0; ii < floats.Length; ii++)
            {
                short uint16 = (short)(floats[ii] * short.MaxValue);
                byte[] vs = BitConverter.GetBytes(uint16);
                bytes[ii * 2] = vs[0];
                bytes[ii * 2 + 1] = vs[1];
            }

            byte[] wav = new byte[44 + bytes.Length];

            byte[] header = {0x52, 0x49, 0x46, 0x46, 0x00, 0x00, 0x00, 0x00,
                         0x57, 0x41, 0x56, 0x45, 0x66, 0x6D, 0x74, 0x20,
                         0x10, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00,
                         0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                         0x04, 0x00, 0x10, 0x00, 0x64, 0x61, 0x74, 0x61 };

            Buffer.BlockCopy(header, 0, wav, 0, header.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(36 + bytes.Length), 0, wav, 4, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(clip.channels), 0, wav, 22, 2);
            Buffer.BlockCopy(BitConverter.GetBytes(clip.frequency), 0, wav, 24, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(clip.frequency * clip.channels * 2), 0, wav, 28, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(clip.channels * 2), 0, wav, 32, 2);
            Buffer.BlockCopy(BitConverter.GetBytes(bytes.Length), 0, wav, 40, 4);
            Buffer.BlockCopy(bytes, 0, wav, 44, bytes.Length);

            //File.WriteAllBytes(Application.dataPath + "/my.wav", wav);
            return wav;
        }
    }
    #endregion

}
