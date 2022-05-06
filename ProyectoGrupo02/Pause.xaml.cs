using System;
using System.Collections.Generic;
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
    public sealed partial class Pause : Page
    {
        InGame.Datos d;
        public Pause()
        {
            this.InitializeComponent();
        }

        private void Return_Click_Pause(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(InGame), d);
        }
        private void Return_Menu(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e?.Parameter is InGame.Datos d)
            {
                d = new InGame.Datos(d);
                base.OnNavigatedTo(e);
            }
        }
    }
}
