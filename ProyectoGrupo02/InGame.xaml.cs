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

        private async void Ellipse_Drop(object sender, DragEventArgs e)
        {
            //var id = e.DataView.GetTextAsync();
            //int n = int.Parse(await id);
            //Point pos = e.GetPosition(TopRectangle);
            //BitmapImage url = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\" + n.ToString() + ".png"));
            //Image objeto = new Image();
            //objeto.Source = url;
            //objeto.Width = url.PixelWidth;
            //objeto.Height = url.PixelHeight;
            //Canvas.SetLeft(objeto, pos.X);
            //Canvas.SetTop(objeto, pos.Y);
            ////objeto.SetValue(Canvas.LeftProperty, pos.X - 25);
            ////objeto.SetValue(Canvas.TopProperty, pos.Y - 15);
            //CanvasTop.Children.Add(objeto);
            //Point PD = e.GetPosition(MiCanvas);

            //var number = int.Parse(id);

            //ListaDrones[Sel].X = (int)PD.X;
            //ListaDrones[Sel].X = (int)PD.Y;

            //ListaDrones[Sel].Transformacion.Rotation = ListaDrones[Sel].Angulo;
            //// VOY POR AQUI ListaDrones[Sel].Transformacion.TranslateX
            //ListaDrones[Sel].Transformacion.CenterX = 20;
            //ListaDrones[Sel].Transformacion.CenterY = 15;


            //MiImagen.Source = ListaDrones[number].Img.Source;
            //Texto.Text = ListaDrones[number].Explicacion;
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
    }
}
