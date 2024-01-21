# Audio Extension
## Extension Related to Unity's built-in Audio System

#### *Note: Following Extension method depends on [EasingExtension](./Assets/Extensions/Docs/EasingExtension.md)*

## Index
- [PlayFadeIn](#playfadein)
- [StopFadeOut](#stopfadeout)
- [PlayFadeOut](#PlayFadeOut)
- [PlayFadeInOut](#PlayFadeInOut)
- [PlayAudioSequence](#PlayAudioSequence)
- [PlayPortion](#PlayPortion)
- [PlayPortion with Fade](#PlayPortionFadeIn)
- [PlayPortionFadeIn](#PlayPortionFadeIn)
- [PlayPortionFadeOut](#PlayPortionFadeOut)
- [MakeSubclip](#MakeSubclip)
- [SaveClip](#SaveClip)

## PlayFadeIn

This extension method plays an `AudioSource` with a fade-in effect.

### Usage

```csharp
public AudioSource audioSource; // Assign your AudioSource in the Inspector

private float fadeInDuration = 1.0f;
private float targetVolume = 0.8f;

void Start()
{
    // Example: Play the AudioSource with a fade-in effect
    audioSource.PlayFadeIn(fadeInDuration, EaseType.EaseIn, targetVolume, OnFadeInCallback);
}
```

### General Syntax

```csharp
audioSource.PlayFadeIn(fadeDuration, easeType, targetVolume, OnFadeInComplete);
```

### Parameters

| Parameter          | Data Type   | Description                                                                                                       |
|--------------------|-----------  |-------------------------------------------------------------------------------------------------------------------|
| audioSource        | AudioSource | The AudioSource to play with the fade-in effect.                                                                  |
| fadeDuration       | float       | The duration of the fade-in effect (in seconds).                                                                  |
| easeType           | EaseType    | The type of easing to use for the fade-in animation.                                                              |
| targetVolume       | float       | The target volume to reach at the end of the fade-in (default is 1).                                              |
| OnFadeInComplete   | Action      | An optional callback to invoke when the fade-in is complete.                                                      |

### Method Description

This method plays the specified `AudioSource` with a fade-in effect. The volume of the `AudioSource` is initially set to 0, and then it gradually increases to the specified `targetVolume` over the specified `fadeDuration` using the specified easing `easeType`.

### Example

```csharp
// Play the AudioSource with a fade-in effect
audioSource.PlayFadeIn(1.0f, EaseType.EaseIn, 0.8f, OnFadeInCallback);
```

In this example, the `PlayFadeIn` method is used to play the `audioSource` with a fade-in effect. Adjust the parameter values according to your specific requirements.


## StopFadeOut

This extension method stops an `AudioSource` with a fade-out effect.

### Usage

```csharp
public AudioSource audioSource; // Assign your AudioSource in the Inspector

private float fadeOutDuration = 1.0f;

void Start()
{
    // Example: Stop the AudioSource with a fade-out effect
    audioSource.StopFadeOut(fadeOutDuration, EaseType.EaseOut, OnFadeOutStartCallback, OnFadeOutCallback);
}
```

### General Syntax

```csharp
audioSource.StopFadeOut(fadeDuration, easeType, OnFadeOutStart, OnFadeOutComplete);
```

### Parameters

| Parameter            | Data Type | Description                                                                                                      |
|----------------------|-----------|------------------------------------------------------------------------------------------------------------------|
| audioSource          | AudioSource | The AudioSource to stop with the fade-out effect.                                                               |
| fadeDuration         | float     | The duration of the fade-out effect (in seconds).                                                               |
| easeType             | EaseType  | The type of easing to use for the fade-out animation.                                                            |
| OnFadeOutStart       | Action    | An optional callback to invoke when the fade-out is started.                                                     |
| OnFadeOutComplete    | Action    | An optional callback to invoke when the fade-out is complete.                                                    |

### Method Description

This method stops the specified `AudioSource` with a fade-out effect. The volume of the `AudioSource` gradually decreases to 0 over the specified `fadeDuration` using the specified easing `easeType`.

### Example

```csharp
// Stop the AudioSource with a fade-out effect
audioSource.StopFadeOut(1.0f, EaseType.EaseOut, OnFadeOutStartCallback, OnFadeOutCallback);
```

In this example, the `StopFadeOut` method is used to stop the `audioSource` with a fade-out effect. Adjust the parameter values according to your specific requirements.

## PlayFadeOut

This extension method plays an `AudioSource` with a fade-out effect.

### Usage

```csharp
public AudioSource audioSource; // Assign your AudioSource in the Inspector

private float fadeOutDuration = 1.0f;

void Start()
{
    // Example: Play the AudioSource with a fade-out effect
    audioSource.PlayFadeOut(fadeOutDuration, EaseType.EaseOut, OnFadeOutStartCallback, OnFadeOutCallback);
}
```

### General Syntax

```csharp
audioSource.PlayFadeOut(fadeDuration, easeType, OnFadeOutStart, OnFadeOutComplete);
```

### Parameters

| Parameter            | Data Type | Description                                                                                                      |
|----------------------|-----------|------------------------------------------------------------------------------------------------------------------|
| audioSource          | AudioSource | The AudioSource to play with the fade-out effect.                                                               |
| fadeDuration         | float     | The duration of the fade-out effect (in seconds).                                                               |
| easeType             | EaseType  | The type of easing to use for the fade-out animation.                                                            |
| OnFadeOutStart       | Action    | An optional callback to invoke when the fade-out is started.                                                     |
| OnFadeOutComplete    | Action    | An optional callback to invoke when the fade-out is complete.                                                    |

### Method Description

This method plays the specified `AudioSource` with a fade-out effect. The volume of the `AudioSource` gradually decreases to 0 over the specified `fadeDuration` using the specified easing `easeType`. Unlike `StopFadeOut`, this method does not stop the audio playback after fading out.

### Example

```csharp
// Play the AudioSource with a fade-out effect
audioSource.PlayFadeOut(1.0f, EaseType.EaseOut, OnFadeOutStartCallback, OnFadeOutCallback);
```

In this example, the `PlayFadeOut` method is used to play the `audioSource` with a fade-out effect. Adjust the parameter values according to your specific requirements.

## PlayFadeInOut

This extension method plays an `AudioSource` with a fade-in followed by a fade-out effect.

### Usage

```csharp
public AudioSource audioSource; // Assign your AudioSource in the Inspector

private float fadeInDuration = 1.0f;
private float fadeOutDuration = 1.0f;
private float targetVolume = 0.8f;

void Start()
{
    // Example: Play the AudioSource with a fade-in followed by a fade-out effect
    audioSource.PlayFadeInOut(fadeInDuration, fadeOutDuration, EaseType.EaseIn, EaseType.EaseOut, targetVolume, OnFadeInCallback, OnFadeOutStartCallback, OnFadeOutCallback);
}
```

### General Syntax

```csharp
audioSource.PlayFadeInOut(fadeInDuration, fadeOutDuration, fadeInEase, fadeOutEase, targetVolume, OnFadeInComplete, OnFadeOutStart, OnFadeOutComplete);
```

### Parameters

| Parameter            | Data Type | Description                                                                                                      |
|----------------------|-----------|------------------------------------------------------------------------------------------------------------------|
| audioSource          | AudioSource | The AudioSource to play with the fade-in and fade-out effects.                                                  |
| fadeInDuration       | float     | The duration of the fade-in effect (in seconds).                                                               |
| fadeOutDuration      | float     | The duration of the fade-out effect (in seconds).                                                              |
| fadeInEase           | EaseType  | The easing type for the fade-in animation.                                                                      |
| fadeOutEase          | EaseType  | The easing type for the fade-out animation.                                                                     |
| targetVolume         | float     | The target volume to reach at the end of the fade-in (default is 1).                                           |
| OnFadeInComplete     | Action    | An optional callback to invoke when the fade-in is complete.                                                    |
| OnFadeOutStart       | Action    | An optional callback to invoke when the fade-out is started.                                                     |
| OnFadeOutComplete    | Action    | An optional callback to invoke when the fade-out is complete.                                                    |

### Method Description

This method plays the specified `AudioSource` with a fade-in effect followed by a fade-out effect. The volume of the `AudioSource` gradually increases to the specified `targetVolume` over the specified `fadeInDuration` using the specified easing `fadeInEase`. After the fade-in is complete, the volume then gradually decreases to 0 over the specified `fadeOutDuration` using the specified easing `fadeOutEase`.

### Example

```csharp
// Play the AudioSource with a fade-in followed by a fade-out effect
audioSource.PlayFadeInOut(1.0f, 1.0f, EaseType.EaseIn, EaseType.EaseOut, 0.8f, OnFadeInCallback, OnFadeOutStartCallback, OnFadeOutCallback);
```

In this example, the `PlayFadeInOut` method is used to play the `audioSource` with a fade-in effect followed by a fade-out effect. Adjust the parameter values according to your specific requirements.


## PlayAudioSequence

This extension method plays a sequence of `AudioSources` with fade-in and fade-out effects, allowing for sequential playback.

### Usage

```csharp
public AudioSource[] audioSequence; // Assign your AudioSources in the Inspector

private float fadeInDuration = 2.0f;
private float fadeOutDuration = 1.5f;
private float targetVolume = 0.8f;

void Start()
{
    // Example 1: Basic usage without callbacks
    audioSequence.PlayAudioSequence(fadeInDuration , fadeOutDuration , EaseType.EaseIn, EaseType.EaseOut, shouldLoopSeq: true);

    // Example 2: With callbacks
    audioSequence.PlayAudioSequence(fadeInDuration , fadeOutDuration , EaseType.EaseIn, EaseType.EaseOut, targetVolume: targetVolume , OnFadeInComplete: OnFadeInCallback, OnFadeOutStart: OnFadeOutStartCallback, OnFadeOutComplete: OnFadeOutCallback);
}
```

### General Syntax

```csharp
audioSequence.PlayAudioSequence(fadeInDuration, fadeOutDuration, fadeInEase, fadeOutEase, shouldLoopSeq, targetVolume, startingIndex, OnFadeInComplete, OnFadeOutStart, OnFadeOutComplete);
```

### Parameters

| Parameter             | Data Type     | Description                                              |
|-----------------------|---------------|----------------------------------------------------------|
| audioSourceSeq        | AudioSource[] | An array of AudioSources to play sequentially.           |
| fadeInDuration        | float         | The duration of the fade-in effect for each AudioSource in the sequence (in seconds). |
| fadeOutDuration       | float         | The duration of the fade-out effect for each AudioSource in the sequence (in seconds). |
| fadeInEase            | EaseType      | The easing type for the fade-in animation.                |
| fadeOutEase           | EaseType      | The easing type for the fade-out animation.               |
| shouldLoopSeq         | bool          | Indicates whether the sequence should loop when it ends. |
| targetVolume          | float         | The target volume to reach at the end of the fade-in (default is 1). |
| startingIndex         | int           | The index of the AudioSource to start the sequence from (default is 0). |
| OnFadeInComplete      | Action        | An optional callback to invoke when each fade-in is complete. |
| OnFadeOutStart        | Action        | An optional callback to invoke when the fade-out is started. |
| OnFadeOutComplete     | Action        | An optional callback to invoke when each fade-out is complete. |

### Method Description

This method plays a sequence of `AudioSources` with fade-in and fade-out effects. It starts by playing the `AudioSource` at the specified `startingIndex` with a fade-in effect, and upon completion, it triggers the optional `OnFadeInComplete` callback. After the fade-in, the method starts a coroutine to perform a fade-out effect on the same `AudioSource`, triggering the optional `OnFadeOutStart` callback. When the fade-out is complete, the optional `OnFadeOutComplete` callback is invoked. If the sequence reaches the end and `shouldLoopSeq` is set to `true`, it loops back to the beginning.

### Example

```csharp
// Play a sequence of AudioSources with fade-in and fade-out effects
audioSequence.PlayAudioSequence(2.0f, 1.5f, EaseType.EaseIn, EaseType.EaseOut, shouldLoopSeq: true, targetVolume: 0.8f, OnFadeInComplete: OnFadeInCallback, OnFadeOutStart: OnFadeOutStartCallback, OnFadeOutComplete: OnFadeOutCallback);
```

In this example, the `PlayAudioSequence` method is used to play a sequence of `AudioSources` with specified fade-in and fade-out durations, easing types, and optional callbacks. Adjust the parameter values according to your specific requirements.

## PlayPortion

This extension method plays a portion of an audio clip between specified start and end times using the provided `AudioSource`.

### Usage

```csharp
public AudioSource audioSource; // Assign your AudioSource in the Inspector

private float portionStart = 2.0f;
private float portionEnd = 5.0f;

void Start()
{
    // Example: Play a portion of the audio clip
    audioSource.PlayPortion(portionStart, portionEnd);
}
```

### General Syntax

```csharp
audioSource.PlayPortion(start, end);
```

### Parameters

| Parameter  | Data Type | Description                                                                                                       |
|------------|-----------|-------------------------------------------------------------------------------------------------------------------|
| source     | AudioSource | The AudioSource to play the portion on.                                                                         |
| start      | float     | The start time of the portion (in seconds).                                                                    |
| end        | float     | The end time of the portion (in seconds). If `end` is 0 or less than or equal to `start`, it is automatically set to the clip length. |

### Method Description

This method plays a specified portion of an audio clip using the provided `AudioSource`. If the `end` parameter is 0 or less than or equal to the `start` parameter, the `end` is automatically set to the clip length. The audio clip is then played starting from the specified `start` time to the calculated `end` time.

### Example

```csharp
// Play a portion of the audio clip starting from 2 seconds to 5 seconds
audioSource.PlayPortion(2.0f, 5.0f);
```

In this example, the `PlayPortion` method is used to play a specific portion of the audio clip attached to the `audioSource`. Adjust the `portionStart` and `portionEnd` values according to your specific requirements.

## PlayPortion with Fade

This extension method plays a portion of an audio clip between specified start and end times using the provided `AudioSource`, with optional fade-in and fade-out effects.

### Usage

```csharp
public AudioSource audioSource; // Assign your AudioSource in the Inspector

private float portionStart = 2.0f;
private float portionEnd = 5.0f;
private float fadeInDuration = 1.0f;
private float fadeOutDuration = 1.0f;
private float targetVolume = 0.8f;

void Start()
{
    // Example: Play a portion of the audio clip with fade-in and fade-out effects
    audioSource.PlayPortion(portionStart, portionEnd, fadeInDuration, fadeOutDuration, EaseType.EaseIn, EaseType.EaseOut, targetVolume, OnFadeInCallback, OnFadeOutStartCallback, OnFadeOutCallback);
}
```

### General Syntax

```csharp
audioSource.PlayPortion(start, end, fadeInDuration, fadeOutDuration, fadeInEase, fadeOutEase, targetVolume, OnFadeInComplete, OnFadeOutStart, OnFadeOutComplete);
```

### Parameters

| Parameter          | Data Type | Description                                                                                                       |
|--------------------|-----------|-------------------------------------------------------------------------------------------------------------------|
| source             | AudioSource | The AudioSource to play the portion on.                                                                         |
| start              | float     | The start time of the portion (in seconds).                                                                    |
| end                | float     | The end time of the portion (in seconds). If `end` is 0 or less than or equal to `start`, it is automatically set to the clip length. |
| fadeInDuration     | float     | The duration of the fade-in effect (in seconds).                                                               |
| fadeOutDuration    | float     | The duration of the fade-out effect (in seconds).                                                              |
| fadeInEase         | EaseType  | The easing type for the fade-in effect.                                                                         |
| fadeOutEase        | EaseType  | The easing type for the fade-out effect.                                                                        |
| targetVolume       | float     | The target volume to reach at the end of the fade-in (default is 1).                                           |
| OnFadeInComplete   | Action    | An optional callback to invoke when the fade-in is complete.                                                    |
| OnFadeOutStart     | Action    | An optional callback to invoke when the fade-out is started.                                                    |
| OnFadeOutComplete  | Action    | An optional callback to invoke when the fade-out is complete.                                                   |

### Method Description

This method plays a specified portion of an audio clip using the provided `AudioSource` with optional fade-in and fade-out effects. If the `end` parameter is 0 or less than or equal to the `start` parameter, the `end` is automatically set to the clip length. The audio clip is then played starting from the specified `start` time to the calculated `end` time with fade-in and fade-out effects.

### Example

```csharp
// Play a portion of the audio clip with fade-in and fade-out effects
audioSource.PlayPortion(2.0f, 5.0f, 1.0f, 1.0f, EaseType.EaseIn, EaseType.EaseOut, 0.8f, OnFadeInCallback, OnFadeOutStartCallback, OnFadeOutCallback);
```

In this example, the `PlayPortion` method is used to play a specific portion of the audio clip attached to the `audioSource` with fade-in and fade-out effects. Adjust the parameter values according to your specific requirements.

## PlayPortionFadeIn

This extension method plays a portion of the audio clip between specified start and end times with a fade-in effect.

### Usage

```csharp
public AudioSource audioSource; // Assign your AudioSource in the Inspector

private float start = 1.0f;
private float end = 5.0f;
private float fadeInDuration = 2.0f;

void Start()
{
    // Example: Play a portion of the audio clip with a fade-in effect
    audioSource.PlayPortionFadeIn(start, end, fadeInDuration, EaseType.EaseIn, targetVolume: 0.8f, OnFadeInComplete: OnFadeInCallback);
}
```

### General Syntax

```csharp
audioSource.PlayPortionFadeIn(start, end, fadeInDuration, fadeInEaseType, targetVolume, OnFadeInComplete);
```

### Parameters

| Parameter             | Data Type     | Description                                              |
|-----------------------|---------------|----------------------------------------------------------|
| source                | AudioSource   | The AudioSource to play the portion on.                  |
| start                 | float         | The start time of the portion (in seconds).             |
| end                   | float         | The end time of the portion (in seconds).               |
| fadeInDuration        | float         | The duration of the fade-in effect (in seconds).        |
| fadeInEaseType        | EaseType      | The easing type for the fade-in effect.                 |
| targetVolume          | float         | The target volume to reach at the end of the fade-in (default is 1). |
| OnFadeInComplete      | Action        | An optional callback to invoke when the fade-in is complete. |

### Method Description

This method plays a portion of the audio clip between the specified `start` and `end` times on the provided `AudioSource`. The portion is created using the `MakeSubclip` method, and a fade-in effect is applied using the `PlayFadeIn` method with the specified `fadeInDuration` and `fadeInEaseType`. The optional `OnFadeInComplete` callback is invoked when the fade-in is complete.

### Example

```csharp
// Play a portion of the audio clip with a fade-in effect
audioSource.PlayPortionFadeIn(1.0f, 5.0f, 2.0f, EaseType.EaseIn, targetVolume: 0.8f, OnFadeInComplete: OnFadeInCallback);
```

In this example, the `PlayPortionFadeIn` method is used to play a portion of the audio clip with a fade-in effect. Adjust the parameter values according to your specific requirements.
## PlayPortionFadeOut

This extension method plays a portion of the audio clip between specified start and end times with a fade-out effect.

### Usage

```csharp
public AudioSource audioSource; // Assign your AudioSource in the Inspector

private float start = 1.0f;
private float end = 5.0f;
private float fadeOutDuration = 2.0f;

void Start()
{
    // Example: Play a portion of the audio clip with a fade-out effect
    audioSource.PlayPortionFadeOut(start, end, fadeOutDuration, EaseType.EaseOut, OnFadeOutStartCallback, OnFadeOutCallback);
}
```

### General Syntax

```csharp
audioSource.PlayPortionFadeOut(start, end, fadeOutDuration, fadeOutEaseType, OnFadeOutStart, OnFadeOutComplete);
```

### Parameters

| Parameter             | Data Type     | Description                                              |
|-----------------------|---------------|----------------------------------------------------------|
| source                | AudioSource   | The AudioSource to play the portion on.                  |
| start                 | float         | The start time of the portion (in seconds).             |
| end                   | float         | The end time of the portion (in seconds).               |
| fadeOutDuration       | float         | The duration of the fade-out effect (in seconds).       |
| fadeOutEaseType       | EaseType      | The easing type for the fade-out effect.                |
| OnFadeOutStart        | Action        | An optional callback to invoke when the fade-out is started. |
| OnFadeOutComplete     | Action        | An optional callback to invoke when the fade-out is complete. |

### Method Description

This method plays a portion of the audio clip between the specified `start` and `end` times on the provided `AudioSource`. The portion is created using the `MakeSubclip` method, and a fade-out effect is applied using the `PlayFadeOut` method with the specified `fadeOutDuration` and `fadeOutEaseType`. The optional `OnFadeOutStart` callback is invoked when the fade-out is started, and the optional `OnFadeOutComplete` callback is invoked when the fade-out is complete.

### Example

```csharp
// Play a portion of the audio clip with a fade-out effect
audioSource.PlayPortionFadeOut(1.0f, 5.0f, 2.0f, EaseType.EaseOut, OnFadeOutStartCallback, OnFadeOutCallback);
```

In this example, the `PlayPortionFadeOut` method is used to play a portion of the audio clip with a fade-out effect. Adjust the parameter values according to your specific requirements.
## MakeSubclip

This extension method creates a subclip from the original AudioClip based on specified start and stop times.

### Usage

```csharp
public AudioClip originalClip; // Assign your AudioClip in the Inspector

private float start = 1.0f;
private float stop = 5.0f;

void Start()
{
    // Example: Create a subclip from the original AudioClip
    AudioClip subclip = originalClip.MakeSubclip(start, stop);
}
```

### General Syntax

```csharp
AudioClip subclip = originalClip.MakeSubclip(start, stop);
```

### Parameters

| Parameter             | Data Type     | Description                                              |
|-----------------------|---------------|----------------------------------------------------------|
| clip                  | AudioClip     | The original AudioClip to create a subclip from.         |
| start                 | float         | The start time of the subclip (in seconds).             |
| stop                  | float         | The stop time of the subclip (in seconds).              |

### Return Value

- **AudioClip**: A subclip of the original AudioClip.

### Method Description

This method creates a subclip from the original AudioClip based on the specified start and stop times. It checks if the start time is greater than or equal to the stop time and logs an error if so. If the stop time is less than or equal to 0, it is set to the length of the original AudioClip. The method then calculates the required length and creates a new AudioClip (`newClip`) with the specified frequency, samples length, and data. The data is extracted from the original AudioClip and set to the new subclip.

### Example

```csharp
// Create a subclip from the original AudioClip
AudioClip subclip = originalClip.MakeSubclip(1.0f, 5.0f);
```

In this example, the `MakeSubclip` method is used to create a subclip from the `originalClip` starting at 1 second and ending at 5 seconds. Adjust the `start` and `stop` parameters according to your specific requirements.

## SaveClip

This extension method saves the AudioClip as a WAV file at the specified path. (EDITOR ONLY)

### Usage

```csharp
public AudioClip audioClip; // Assign your AudioClip in the Inspector

private string filePath = "Assets/Audio/MyAudioClip.wav";

void Start()
{
    // Example: Save the AudioClip as a WAV file
    audioClip.SaveClip(filePath);
}
```

### General Syntax

```csharp
audioClip.SaveClip(path);
```

### Parameters

| Parameter             | Data Type     | Description                                              |
|-----------------------|---------------|----------------------------------------------------------|
| clip                  | AudioClip     | The AudioClip to save as a WAV file.                     |
| path                  | string        | The file path where the WAV file will be saved.          |

### Method Description

This method saves the provided AudioClip as a WAV file at the specified file path. It is intended for use in the Unity Editor (`#if UNITY_EDITOR`). The method first ensures that the directory specified in the path exists. If not, it creates the directory. It then converts the AudioClip to WAV format using a hypothetical `WAVUtlity.ClipToWav` method (as it is not provided in the code snippet), writes the WAV data to the file, and refreshes the Asset Database. A log message is displayed indicating that the AudioClip has been saved as a WAV file.

### Example

```csharp
// Save the AudioClip as a WAV file
audioClip.SaveClip("Assets/Audio/MyAudioClip.wav");
```

In this example, the `SaveClip` method is used to save the `audioClip` as a WAV file at the specified file path. Adjust the `filePath` parameter according to your specific requirements. Note that this method is intended for use in the Unity Editor.
