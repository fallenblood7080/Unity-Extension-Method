# VideoPlayerExtensions Class


## SmoothVideoPause Method

Performs a smooth pause or unpause of a Unity `VideoPlayer` by gradually adjusting the playback speed, creating a fade effect.


### Usage

```csharp
// Example: Smoothly pause a VideoPlayer for 1 second
videoPlayer.SmoothVideoPause(1.0f, true);


### General Syntax

void SmoothVideoPause(this VideoPlayer videoPlayer, float fadeDuration = 0.5f, bool pause = true);


### Parameter

Parameter	Data Type	Description
videoPlayer	VideoPlayer	The Unity VideoPlayer instance to be paused or unpaused smoothly.
fadeDuration	float	The duration of the fade effect in seconds (default is 0.5 seconds).
pause	bool	If true, smoothly pauses the video. If false, smoothly unpauses the video.

| Parameter          | Data Type    | Description                                                                                                       |
|--------------------|-----------   |-------------------------------------------------------------------------------------------------------------------|
| videoPlayer        | VideoPlayer  | The Unity VideoPlayer instance to be paused or unpaused smoothly.                                                 |
| fadeDuration       | float        | The duration of the fade effect in seconds (default is 0.5 seconds).                                              |
| pause              | bool         | If true, smoothly pauses the video. If false, smoothly unpauses the video.                                        |

### Method Description

This extension method smoothly pauses or unpauses a Unity VideoPlayer by gradually adjusting the playback speed, creating a fade effect. It achieves this by lerping the playbackSpeed property of the VideoPlayer over the specified fadeDuration. The method also utilizes coroutines to handle the asynchronous nature of the fade.


### Expamle

videoPlayer.SmoothVideoPause(1.0f, true);

In this example, the SmoothVideoPause method is used to smoothly pause the videoPlayer over a duration of 1 second. Adjust the fadeDuration and pause parameters according to your specific requirements.