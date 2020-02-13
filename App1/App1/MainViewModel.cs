using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;

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
        public string VideoPath
        {
            get { return _videoPath; }
            set { Set(ref _videoPath, value); }
        }

        internal void SelectRandomVideo()
        {
            var rnd = new Random();
            VideoPath = _videos[rnd.Next(3)];
        }
    }
}
