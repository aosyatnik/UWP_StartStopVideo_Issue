using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using Windows.Media.Core;

namespace App1
{
    public class MainViewModel : ViewModelBase
    {
        private readonly List<string> _videos = new List<string>()
        {
            "ms-appx:///Assets/Videos/video1.mp4",
            "ms-appx:///Assets/Videos/video2.mp4",
            "ms-appx:///Assets/Videos/video3.mp4",
        };

        private string _videoPath;
        public MediaSource VideoPath
        {
            get { return MediaSource.CreateFromUri(new Uri(_videoPath)); }
            set { Set(ref _videoPath, value.Uri.AbsoluteUri); }
        }

        internal void SelectRandomVideo()
        {
            var rnd = new Random();
            _videoPath = _videos[rnd.Next(3)];
            RaisePropertyChanged(nameof(VideoPath));
        }
    }
}
