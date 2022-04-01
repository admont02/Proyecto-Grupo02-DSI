using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
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
    }
}
