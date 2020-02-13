# UWP_StartStopVideo_Issue
This repo is a minimal reproducible scenario for videos issue.

# Steps to reproduce
1. Run application.
2. Click "Stop and start" button. It will load one of a random video among 3 available videos (correct).
3. Click button again. If you are lucky and the next video is the same video it will be played. If the next video is another video it won't be played.

# Expected behaviour
The video should be played regardless if it's the same video or another video. `Stop` and `Play` calls should not break video playing.

# Known workarounds
1. Add small await between `Stop` and `Play` like this:
```csharp
Video.Stop();

// Workaround 1
//await Task.Delay(300);

Video.Play();
```

2. Add `Video_MediaOpened` event handler and run `Play` there.


