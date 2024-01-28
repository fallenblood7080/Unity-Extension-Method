# VideoPlayerExtensions Class

# Index
- [SmoothVideoPause](#SmoothVideoPause)

## SmoothVideoPause

Smoothly pauses or unpauses the `VideoPlayer` with a fade effect.

### Usage

```csharp
// Example: Smoothly pause the VideoPlayer with a fade effect lasting 1 second
videoPlayer.SmoothVideoPause(1.0f, true);
```

### General Syntax

```csharp
videoPlayer.SmoothVideoPause(fadeDuration, pause);
```

### Parameters

| Parameter     | Data Type  | Description                                            |
|---------------|------------|--------------------------------------------------------|
| videoPlayer   | VideoPlayer| The `VideoPlayer` instance is to be paused or unpaused.   |
| fadeDuration  | float      | The duration of the fade effect in seconds. The default is 0.5 seconds. |
| pause         | bool       | If true, pauses the video; if false, unpauses the video.|

### Method Description

This extension method smoothly pauses or unpauses the specified `VideoPlayer` with a fade effect. It utilizes a coroutine (`SmoothVideoPauseCoroutine`) to gradually adjust the audio volume associated with the `VideoPlayer`, creating a smooth transition effect.

### Example

```csharp
// Smoothly pause the VideoPlayer with a fade effect lasting 1 second
videoPlayer.SmoothVideoPause(1.0f, true);
```

In this example, the `SmoothVideoPause` method smoothly pauses the `videoPlayer` with a fade effect lasting 1 second. You can adjust the values according to your specific requirements.
