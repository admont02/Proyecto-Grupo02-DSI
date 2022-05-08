using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Gaming.Input;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProyectoGrupo02
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class InGame : Page
    {
        public ObservableCollection<VMObject> Objects { get; } = new ObservableCollection<VMObject>();
        public ObservableCollection<VMObject> Pots { get; } = new ObservableCollection<VMObject>();
        private TranslateTransform dragTranslation;


        private DispatcherTimer timer;
        int initialTime = 0;
        int clicks = 1, labclicks = 0;

        bool mu0, mu1, mu2, mu3, md0, md1, md2, md3 = false;
        bool ru0,ru1,ru2,ru3,rd0,rd1,rd2,rd3 = false;
        bool lu0, lu1, lu2, lu3, ld0, ld1, ld2, ld3 = false;

        MediaPlayer musica;
        MediaPlayer click;
        MediaPlayer money;
        MediaPlayer pop;

        Image casilla;

        public void ChangeImage(object sender, ItemClickEventArgs e)
        {
            VMObject selected = e.ClickedItem as VMObject;

        }
        public InGame()
        {
            this.InitializeComponent();
            dragTranslation = new TranslateTransform();
            musica = new MediaPlayer();
            click = new MediaPlayer();
            money = new MediaPlayer();
            pop= new MediaPlayer();
            SonidoMonedas();
            PlayDrop();

            casilla = new Image();
            casilla.Width = 50;
            casilla.Height = 50;
            casilla.Source = new BitmapImage(new Uri("ms-appx:///Assets/casilla.png", UriKind.RelativeOrAbsolute));

            timer = new DispatcherTimer();
            timer.Tick += timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            

        }
        void timer_Tick(object sender, object e)
        {
            initialTime++;
            App.monedas += labclicks;
            Money.Text = App.monedas.ToString();
        }
        private void Click_Pause(object sender, RoutedEventArgs e)
        {

            PlayClick();
            musica.Pause();
            string coins = Money.Text;
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
            Frame.Navigate(typeof(Pause), coins);
        }
        private void Coin_Clicker(object sender, RoutedEventArgs e)
        {
            money.Play();
            App.monedas += clicks;
            Money.Text = App.monedas.ToString();

        }
        private void Lab_Click(object sender, RoutedEventArgs e)
        {
            int num = Pots[0].Precio;
            if (num <= (int.Parse(Money.Text)))
            {
                labclicks++;
                App.monedas -= num;
                Money.Text = App.monedas.ToString();
            }
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            int num = Pots[1].Precio;
            if (num <= (int.Parse(Money.Text)))
            {
                clicks++;
                App.monedas -= num;
                Money.Text = App.monedas.ToString();
                pop.Play();
            }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            timer.Start();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
            //this.NavigationCacheMode = NavigationCacheMode.Required;
            if (Objects != null) // Carga la lista de ModelView
            {
                foreach (Object obj in Model.GetAllObjects())
                {
                    VMObject VMitem = new VMObject(obj); Objects.Add(VMitem);
                }
                
            }
            if (Pots != null)
            {
                foreach (Object Pot in Model.GetAllPot())
                {
                    VMObject VMPot = new VMObject(Pot); Pots.Add(VMPot);
                }
            }
            PlayMusic();

            base.OnNavigatedTo(e);
        }

        private async void MiDrop(object sender, DragEventArgs e)
        {
            var id = await e.DataView.GetTextAsync();
            int aux = int.Parse(id);
            Image i = sender as Image;
            int precio = Objects[aux].Precio;
            if (App.monedas >= precio)
            {
                i.Source = Objects[aux].Img.Source;
                i.Visibility = Visibility.Visible;
                App.monedas -= precio;
                Money.Text = App.monedas.ToString();
                pop.Play();
            }
        }

        private void MiDragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;
            e.DragUIOverride.IsCaptionVisible = true;
            e.DragUIOverride.IsContentVisible = true;
            e.DragUIOverride.IsGlyphVisible = true;
        }


        private async void Papelera_Drop(object sender, DragEventArgs e)
        {

            var id = await e.DataView.GetTextAsync();
            Image o = FindName(id) as Image;
            if (o != null)
            {
                o.Source = casilla.Source;
                o.Visibility = Visibility.Visible;
                int num = 25;
                App.monedas += num;
                Money.Text = App.monedas.ToString();
                pop.Play();
            }
        }

        private void MiDragStarting(object sender, DragStartingEventArgs e)
        {
            Image Item = sender as Image;
            string id = Item.Name;
            e.Data.SetText(id);
            e.Data.RequestedOperation = DataPackageOperation.Copy;
        }


        private async void PlayMusic()
        {
            // played = true;
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Music");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("mainmusic.mp3");
            musica.Source = MediaSource.CreateFromStorageFile(file);
            musica.IsLoopingEnabled = true;
            musica.Volume = App.volumen;
            musica.Play();

        }

        private void MiItemClick(object sender, ItemClickEventArgs e)
        {

            Object o = e.ClickedItem as Object;
            string aux = "ms-appx:" + o.Imagen;
            
            int id = o.Id;
            int num = Objects[id].Precio;
            if (App.monedas >= num)
            {
                pop.Play();
                App.monedas -= num;
                Money.Text = App.monedas.ToString();
                bool puesto = false;
                if (!puesto)
                {
                    if (!mu3 && !puesto)
                    {
                        middleLeft3.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        mu3 = true;
                        puesto = true;
                    }
                    else if (!md3 && !puesto)
                    {
                        middleRight3.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        md3 = true; puesto = true;
                    }
                    else if (!md2 && !puesto)
                    {
                        middleRight2.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        md2 = true; puesto = true;
                    }
                    else if (!mu2 && !puesto)
                    {
                        middleLeft2.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        mu2 = true;
                        puesto = true;
                    }

                    else if (!mu1 && !puesto)
                    {
                        middleLeft1.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        mu1 = true;
                        puesto = true;
                    }
                    else if (!md1 && !puesto)
                    {
                        middleRight1.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        md1 = true; puesto = true;
                    }


                    else if (!md0 && !puesto)
                    {
                        middleRight0.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        md0 = true; puesto = true;
                    }
                    if (!mu0 && !puesto)
                    {
                        middleLeft0.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        mu0 = true;
                        puesto = true;
                    }



                    else if (!ru0 && !puesto)
                    {
                        RightUp0.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        ru0 = true;
                        puesto = true;
                    }
                    else if (!rd0 && !puesto)
                    {
                        RightDown0.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        rd0 = true; puesto = true;
                    }
                    else if (!rd1 && !puesto)
                    {
                        RightDown1.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        rd1 = true; puesto = true;
                    }

                    else if (!ru1 && !puesto)
                    {
                        RightUp1.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        ru1 = true; puesto = true;
                    }
                    else if (!ru2 && !puesto)
                    {
                        RightUp2.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        ru2 = true; puesto = true;

                    }
                    else if (!rd2 && !puesto)
                    {
                        RightDown2.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        rd2 = true; puesto = true;
                    }
                    else if (!rd3 && !puesto)
                    {
                        RightDown3.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        rd3 = true; puesto = true;
                    }
                    else if (!ru3 && !puesto)
                    {
                        RightUp3.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        ru3 = true; puesto = true;
                    }



                    if (!lu0 && !puesto)
                    {
                        leftUp0.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        lu0 = true; puesto = true;
                    }
                    else if (!ld0 && !puesto)
                    {
                        leftDown0.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        ld0 = true; puesto = true;
                    }
                    else if (!ld1 && !puesto)
                    {
                        leftDown1.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        ld1 = true; puesto = true;
                    }
                    else if (!lu1 && !puesto)
                    {
                        leftUp1.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        lu1 = true; puesto = true;
                    }
                    else if (!lu2 && !puesto)
                    {
                        leftUp2.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        lu2 = true; puesto = true;
                    }
                    else if (!ld2 && !puesto)
                    {
                        leftDown2.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        ld2 = true; puesto = true;
                    }
                    else if (!ld3 && !puesto)
                    {
                        leftDown3.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        ld3 = true; puesto = true;
                    }
                    else if (!lu3 && !puesto)
                    {
                        leftUp3.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
                        lu3 = true; puesto = true;
                    }


                }
            }
            
           
        }

        private void Grid3_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            Object aux = e.Items[0] as Object;
            string id = aux.Id.ToString();
            e.Data.SetText(id);
            e.Data.RequestedOperation = DataPackageOperation.Copy;
        }

        private async void PlayClick()
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Music");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("clicked.mp3");
            click.Source = MediaSource.CreateFromStorageFile(file);

            click.Volume = 1;
            click.Play();
        }
        private async void PlayDrop()
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Music");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("pop.mp3");
            pop.Source = MediaSource.CreateFromStorageFile(file);

            pop.Volume = 1;
            pop.Play();
        }

        private async void SonidoMonedas()
        {
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Music");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("moneda.mp3");
            money.Source = MediaSource.CreateFromStorageFile(file);
            money.Volume = 1;

            //click.Play();
        }
    }
}
