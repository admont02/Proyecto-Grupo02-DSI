using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ProyectoGrupo02
{
    public class VMObject : Object
    {
        public Image Img;
        public ContentControl CCImg;
        public int Zoom;
        public VMObject(Object obj)
        {
            Id = obj.Id;
            Nombre = obj.Nombre;
            Imagen = obj.Imagen;
            Explicacion = obj.Explicacion;
            Estado = obj.Estado;
            X = obj.X;
            Y = obj.Y;
            RX = obj.RX;
            RY = obj.RY;
            Img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + obj.Imagen;
            Img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            Img.Width = 50;
            Img.Height = 50;
            CCImg = new ContentControl();
            CCImg.Content = Img;
            CCImg.UseSystemFocusVisuals = true;
            //CCImg.Visibility = Windows.UI.Xaml.Visibility.Visible;//.Collapsed;
            //Mapa.Children.Add(CCImg);
            //Mapa.Children.Last().SetValue(Canvas.LeftProperty, X - 25);
            //Mapa.Children.Last().SetValue(Canvas.TopProperty, Y - 25);
        }
    }
}
