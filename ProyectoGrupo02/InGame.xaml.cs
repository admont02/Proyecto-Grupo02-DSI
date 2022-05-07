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
        public struct Datos
        {
            public Datos(int m)
            {
                coins = m;
            }
            public Datos(Datos d)
            {
                coins = d.coins;
            }
            public int coins { get; set; }
        }
        int nCoins =0;
        public ObservableCollection<VMObject> Objects { get; } = new ObservableCollection<VMObject>();
        private TranslateTransform dragTranslation;
        private readonly object myLock = new object();
        private List<Gamepad> myGamepads = new List<Gamepad>();
        private Gamepad mainGamepad = null;
        private GamepadReading reading, prereading;
        private GamepadVibration vibration;
        
        private DispatcherTimer timer;
        int initialTime = 0;
        int clicks = 1, labclicks = 0;

        DispatcherTimer GamePadTimer;
        MediaPlayer musica;
        MediaPlayer click;
        MediaPlayer money;

        Image casilla;

        public void ChangeImage(object sender, ItemClickEventArgs e)
        {
            VMObject selected = e.ClickedItem as VMObject;

            //perfil.Source = selected.Img.Source;
            ////perfil.Margin = (selected.RX,selected.RY,0,0);
            //perfil.Translation = new System.Numerics.Vector3(selected.RX, selected.RY, 0);
        }
        public InGame()
        {
            this.InitializeComponent();
            dragTranslation = new TranslateTransform();
            musica = new MediaPlayer();
            click = new MediaPlayer();
            money = new MediaPlayer();
            SonidoMonedas();

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
            Money.Text = (nCoins + labclicks).ToString();
        }
        private void Click_Pause(object sender, RoutedEventArgs e)
        {
            PlayClick();
            Datos d;
            d = new Datos(nCoins);
            musica.Pause();
            Frame.Navigate(typeof(Pause),d);
        }
        private void Coin_Clicker(object sender, RoutedEventArgs e)
        {
            money.Play();
            nCoins += clicks;
            Money.Text = (nCoins).ToString();
        }
        private void Lab_Click(object sender, RoutedEventArgs e)
        {
            int num = Objects[7].Precio;
            if (num <= (int.Parse(Money.Text)))
            {
                labclicks++;
                Money.Text = (int.Parse(Money.Text) - num).ToString();
            }
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            int num = Objects[8].Precio;
            if (num <= (int.Parse(Money.Text)))
            {
                clicks++;
                Money.Text = (int.Parse(Money.Text) - num).ToString();
            }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            timer.Start();
            if(e?.Parameter is Datos d)
            {
                nCoins = d.coins;
            }
            //this.NavigationCacheMode = NavigationCacheMode.Required;
            if (Objects != null) // Carga la lista de ModelView
            {
                foreach (Object obj in Model.GetAllObjects())
                {
                    VMObject VMitem = new VMObject(obj); Objects.Add(VMitem);
                }
            }
            PlayMusic();
            base.OnNavigatedTo(e);
        }

        private void a_DragStarting(object sender, DragStartingEventArgs e)
        {
            Image Item = sender as Image;
            string id = Item.Name;
            e.Data.SetText(id);
            e.Data.RequestedOperation = DataPackageOperation.Copy;
        }

        private async void Ellipse_Drop(object sender, DragEventArgs e)
        {
            var id = await e.DataView.GetTextAsync();
            int aux = int.Parse(id);
            Image i = sender as Image;
            i.Source = Objects[aux].Img.Source;
            i.Visibility = Visibility.Visible;
            //Image o = FindName(id) as Image;
            //int num = 999999999;
            //switch (o.Name)
            //{
            //    case "O0":
            //        num = Objects[0].Precio;
            //        break;
            //    case "O1":
            //        num = Objects[1].Precio;
            //        break;
            //    case "O2":
            //        num = Objects[2].Precio;
            //        break;
            //    case "O3":
            //        num = Objects[3].Precio;
            //        break;
            //    case "O4":
            //        num = Objects[4].Precio;
            //        break;
            //    case "O5":
            //        num = Objects[5].Precio;
            //        break;
            //    case "O6":
            //        num = Objects[6].Precio;
            //        break;
            //}
            //if (num <= (int.Parse(Money.Text)))
            //{
            //    Image r = sender as Image;
            //    int x = -1;
            //    switch (o.Name)
            //    {
            //        case "O0":
            //            x = 0;

            //            break;
            //        case "O1":
            //            x = 1;
            //            break;
            //        case "O2":
            //            x = 2;
            //            break;
            //        case "O3":
            //            x = 3;
            //            break;
            //        case "O4":
            //            x = 4;
            //            break;
            //        case "O5":
            //            x = 5;
            //            break;
            //        case "O6":
            //            x = 6;
            //            break;
            //    }
            //r.Source = Objects[x].Img.Source;
            //r.Visibility = Visibility.Visible;

            //Money.Text = (int.Parse(Money.Text) - num).ToString();
        }
        
        private void Ellipse_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;
            e.DragUIOverride.IsCaptionVisible = true;
            e.DragUIOverride.IsContentVisible = true;
            e.DragUIOverride.IsGlyphVisible = true;
        }
        private void LeeMando()
        {
            if (mainGamepad != null)
            {
                prereading = reading;
                reading = mainGamepad.GetCurrentReading();
            }
        }

        private async void Papelera_Drop(object sender, DragEventArgs e)
        {
            var id = await e.DataView.GetTextAsync();
            Image o = FindName(id) as Image;
            o.Source = casilla.Source;
            o.Visibility = Visibility.Visible;
            int num = 20;
            Money.Text = (int.Parse(Money.Text) + num).ToString();
        }
        private void Papelera_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Move;
        }

        private void RightUp0_DragStarting(object sender, DragStartingEventArgs e)
        {
            Image Item = sender as Image;
            string id = Item.Name;
            e.Data.SetText(id);
            e.Data.RequestedOperation = DataPackageOperation.Copy;
        }

        private void ZMMando()
        {
            //zona muerta joystick derecho
            if (reading.RightThumbstickX < -0.1) reading.RightThumbstickX += 0.1;
            else if (reading.RightThumbstickX > 0.1) reading.RightThumbstickX -= 0.1;

            else reading.RightThumbstickX = 0;


            if (reading.RightThumbstickY < -0.1) reading.RightThumbstickY += 0.1;
            else if (reading.RightThumbstickY > 0.1) reading.RightThumbstickY -= 0.1;

            else reading.RightThumbstickY = 0;
        }
        //public void GamepadTimerSetUp()
        //{
        //    GamePadTimer = new DispatcherTimer();
        //    GamePadTimer.Tick += GamePad_Tick;
        //    GamePadTimer.Interval = new TimeSpan(100000);
        //    GamePadTimer.Start();
        //}
        private async void PlayMusic()
        {
            // played = true;
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Music");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("mainmusic.mp3");
            musica.Source = MediaSource.CreateFromStorageFile(file);
            musica.IsLoopingEnabled = true;
            musica.Volume = 0.05;
            musica.Play();
            click.Play();
        }

        private void Grid3_ItemClick(object sender, ItemClickEventArgs e)
        {
            
           Object o= e.ClickedItem as Object;
            string aux = "ms-appx:" + o.Imagen;
           RightDown2.Source = new BitmapImage(new Uri(aux, UriKind.RelativeOrAbsolute));
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
