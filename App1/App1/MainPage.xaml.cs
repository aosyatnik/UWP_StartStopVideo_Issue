using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainViewModel MainViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.SelectRandomVideo();
            Video.Stop();

            // Workaround 1
            //await Task.Delay(300);

            Video.Play();
        }

        private void Video_MediaOpened(object sender, RoutedEventArgs e)
        {
            var video = sender as MediaElement;
            Debug.WriteLine($"Duration of video file: {video.NaturalDuration.TimeSpan.TotalMilliseconds} milliseconds");

            // Workaround 2
            // Video.Play();
        }
    }
}
