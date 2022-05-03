using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo02
{
    public class Object
    {
        public enum estados { Colocado, Tienda, Vendido };

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        //public Image Img;
        public string Explicacion { get; set; }
        public estados Estado { get; set; }
        public int Precio { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int RX;
        public int RY;



        public Object() { }
    }
    public class Model
    {
        public static List<Object> Objects = new List<Object>()
        {
            new Object()
            {
                Id = 0,
                Nombre = "Sol",
                Imagen = "Assets\\0.png",
                //Explicacion = @"Explicación Dron1 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id fa",
                Estado = Object.estados.Tienda,
                Precio=2000,
                //X = 10,
                //Y = 10,
                //RX =100,
                //RY =30,
             },
            new Object()
            {
                Id = 1,
                Nombre = "Pocion",
                Imagen = "Assets\\1.png",
                //Explicacion = @"Explicación Dron2 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Object.estados.Tienda,
                Precio=700,
                //X = 50,
                //Y = 50,
                //RX =150,
                //RY =50,
             },
            new Object()
            {
                Id = 2,
                Nombre = "Guillotina",
                Imagen = "Assets\\2.png",
                //Explicacion = @"Explicación Dron3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Object.estados.Tienda,
                Precio=300,
                //X = 100,
                //Y = 100,
                //RX =50,
                //RY =130,
             },
            new Object()
            {
                Id = 3,
                Nombre = "Agua",
                Imagen = "Assets\\3.png",
                //Explicacion = @"Explicación Dron4 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Object.estados.Tienda,
                Precio=250,
                //X = 150,
                //Y = 150,
                //RX =200,
                //RY =80,
             },
            new Object()
            {
                Id = 4,
                Nombre = "Arroz",
                Imagen = "Assets\\4.png",
                //Explicacion = @"Explicación Dron5 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Object.estados.Tienda,
                Precio=150,
                //X = 200,
                //Y = 200,
                //RX =100,
                //RY =140,
             },
            new Object()
            {
                Id = 5,
                Nombre = "Canyon",
                Imagen = "Assets\\5.png",
                //Explicacion = @"Explicación Dron6 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Object.estados.Tienda,
                Precio=100,
                //X = 250,
                //Y = 250,
                //RX =30,
                //RY =50,
             },
            new Object()
            {
                Id = 6,
                Nombre = "Ajo",
                Imagen = "Assets\\6.png",
                //Explicacion = @"Explicación Dron7 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Object.estados.Tienda,
                Precio=50,
                //X = 300,
                //Y = 300,
                //RX =250,
                //RY =200,
             },
            new Object()
            {
                Id = 7,
                Nombre = "Laboratorio",
                Imagen = "Assets\\7.png",
                //Explicacion = @"Explicación Dron6 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Object.estados.Tienda,
                Precio=700,
                //X = 250,
                //Y = 250,
                //RX =30,
                //RY =50,
             },
            new Object()
            {
                Id = 7,
                Nombre = "Click",
                Imagen = "Assets\\8.png",
                //Explicacion = @"Explicación Dron6 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer id facilisis lectus. Cras nec convallis ante, quis pulvinar tellus. Integer dictum accumsan pulvinar. Pellentesque eget enim sodales sapien vestibulum consequat. Maecenas eu sapien ac urna aliquam dictum. Nullam eget mattis metus. Donec pharetra, tellus in mattis tincidunt, magna ipsum gravida nibh, vitae lobortis ante odio vel quam.",
                Estado = Object.estados.Tienda,
                Precio=50,
                //X = 250,
                //Y = 250,
                //RX =30,
                //RY =50,
             },
          };


        public static IList<Object> GetAllObjects()
        {
            return Objects;
        }

        public static Object GetObjectById(int id)
        {
            return Objects[id];
        }
    }
}
