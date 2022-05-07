using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ProyectoGrupo02
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MediaPlayer musica;
        MediaPlayer click;
        public MainPage()
        {
            this.InitializeComponent();
            musica = new MediaPlayer();
            click = new MediaPlayer();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            PlayClick();
            Frame.Navigate(typeof(Levels));
            musica.Pause();
        }

        private void Settings_OnClick(object sender, RoutedEventArgs e)
        {
            PlayClick();
            musica.Pause();
            Frame.Navigate(typeof(Settings));
        }
        private void Exit_OnClick(object sender, RoutedEventArgs e)
        {
            PlayClick();
            Application.Current.Exit();
        }
        private async void PlayMusic()
        {
            // played = true;
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Music");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("menumusic.mp3");
            musica.Source = MediaSource.CreateFromStorageFile(file);
            musica.IsLoopingEnabled = true;
            musica.Volume = App.volumen;
            musica.Play();
            click.Play();
        }
        private async void PlayClick()
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Music");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("clicked.mp3");
            click.Source = MediaSource.CreateFromStorageFile(file);
            
            click.Volume = 1;
            click.Play();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            PlayMusic();
        }
    }
}
