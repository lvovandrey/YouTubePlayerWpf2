using System;
using System.IO;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Media;
using Vlc.DotNet.Wpf;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для vlc.xaml
    /// </summary>
    public partial class vlc : UserControl
    {
        public vlc()
        {
            InitializeComponent();

            vlcPlayer.MediaPlayer.VlcLibDirectory =
                        //replace this path with an appropriate one
                        new DirectoryInfo(@"c:\Program Files\VideoLAN\VLC\");
            vlcPlayer.MediaPlayer.EndInit();
           // vlcPlayer.MediaPlayer.SetMedia("http://sfrom.net/https://www.youtube.com/watch?v=k1K_4UkVSAE");

             //   vlcPlayer.MediaPlayer.Play();
            vlcPlayer.MediaPlayer.Play(new Uri(@"https://www.youtube.com/embed/3Su7trrJZQI"));
        }
    }

}

