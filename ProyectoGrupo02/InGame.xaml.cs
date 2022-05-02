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
        private TranslateTransform dragTranslation;
        private readonly object myLock = new object();
        private List<Gamepad> myGamepads = new List<Gamepad>();
        private Gamepad mainGamepad = null;

        private GamepadReading reading, prereading;
        private GamepadVibration vibration;

        DispatcherTimer GamePadTimer;

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

            Gamepad.GamepadAdded += (object sender, Gamepad e) =>
            {
                lock (myLock)
                {
                    bool gamepadInList = myGamepads.Contains(e);

                    if (!gamepadInList)
                    {
                        myGamepads.Add(e);
                        mainGamepad = myGamepads[0];
                    }
                }
            };
            Gamepad.GamepadRemoved += (object sender, Gamepad e) =>
            {
                lock (myLock)
                {
                    int indexRemoved = myGamepads.IndexOf(e);

                    if (indexRemoved > -1)
                    {
                        if (mainGamepad == myGamepads[indexRemoved])
                        {
                            mainGamepad = null;
                        }

                        myGamepads.RemoveAt(indexRemoved);
                    }
                }
            };
        }

        private void Click_Pause(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pause));
        }
        private void Coin_Clicker(object sender, RoutedEventArgs e)
        {
            Money.Text = (Int64.Parse(Money.Text) + 1).ToString();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (Objects != null) // Carga la lista de ModelView
            {
                foreach (Object obj in Model.GetAllObjects())
                {
                    VMObject VMitem = new VMObject(obj); Objects.Add(VMitem);
                }
            }
            base.OnNavigatedTo(e);
        }

        private void ListView_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            VMObject Item = e.Items[0] as VMObject;
            string id = Item.Id.ToString();
            e.Data.SetText(id);
            e.Data.RequestedOperation = DataPackageOperation.Copy;
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
            Image o = FindName(id) as Image;
            int num = 999999999;
            switch (o.Name)
            {
                case "O0":
                    num = Objects[0].Precio;
                    break;
                case "O1":
                    num = Objects[1].Precio;
                    break;
                case "O2":
                    num = Objects[2].Precio;
                    break;
                case "O3":
                    num = Objects[3].Precio;
                    break;
                case "O4":
                    num = Objects[4].Precio;
                    break;
                case "O5":
                    num = Objects[5].Precio;
                    break;
                case "O6":
                    num = Objects[6].Precio;
                    break;
            }
            if ( num <= (int.Parse(Money.Text)))
            {
                Image r = sender as Image;
                int x = -1;
                switch (o.Name)
                {
                    case "O0":
                        x = 0;
                        break;
                    case "O1":
                        x = 1;
                        break;
                    case "O2":
                        x = 2;
                        break;
                    case "O3":
                        x = 3;
                        break;
                    case "O4":
                        x = 4;
                        break;
                    case "O5":
                        x = 5;
                        break;
                    case "O6":
                        x = 6;
                        break;
                }
                r.Source = Objects[x].Img.Source;
                r.Visibility = Visibility.Visible;

                Money.Text = (int.Parse(Money.Text) - num).ToString();
            }
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
            int x = -1;
            switch (o.Name)
            {
                case "O0":
                    x = 0;
                    break;
                case "O1":
                    x = 1;
                    break;
                case "O2":
                    x = 2;
                    break;
                case "O3":
                    x = 3;
                    break;
                case "O4":
                    x = 4;
                    break;
                case "O5":
                    x = 5;
                    break;
                case "O6":
                    x = 6;
                    break;
            }
            //o.Source = "Assets/casilla.png";
            o.Visibility = Visibility.Visible;
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
    }
}
