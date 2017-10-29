using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroCompra
{
    class Program
    {
        static void Main(string[] args)
        {
        
            //Creamos todos los articulos que va a tener nuestra tienda.
            Articulo articulo_1 = new Articulo("Ordenador portátil", "Mac Book Pro 15´´", 2145.99f);
            Articulo articulo_2 = new Articulo("Teclado", "Logitech k760 bluetooth", 55.60f);
            Articulo articulo_3 = new Articulo("Ratón", "Logitech M535 bluetooth", 32.85f);
            Articulo articulo_4 = new Articulo("Disco Duro", "Disco Duro Samsung 256Gb SSD", 89.90f);
            Articulo articulo_5 = new Articulo("Disco Duro", "Disco Duro SanDisk Pro 512Gb SSD", 112.75f);
            Articulo articulo_6 = new Articulo("Pen Drive", "Pen Drive Kingston 32Gb bluetooth 3.0", 19.90f);
            Articulo articulo_7 = new Articulo("Pen Drive", "Pen Drive LG 64Gb bluetooth 3.0", 24.75f);
            Articulo articulo_8 = new Articulo("Monitor", "Monitor Led Samsung 22´´ VGA", 125.55f);
            Articulo articulo_9 = new Articulo("Monitor", "Monitor LG HDMI Panorámico 21´´", 98.70f);
            Articulo articulo_10 = new Articulo("Teclado", "Teclado por cable Microsoft", 18.89f);

            //Creamos un Carro para poder ir añadiendo articulos en este.
            Carro cestaCompra = new Carro();

            //Añadimos articulos al carrito de la compra.
            cestaCompra.InsertarArticulo(articulo_1);
            cestaCompra.InsertarArticulo(articulo_1);
            cestaCompra.InsertarArticulo(articulo_2);
            cestaCompra.InsertarArticulo(articulo_3);
            cestaCompra.InsertarArticulo(articulo_3);
            cestaCompra.InsertarArticulo(articulo_5);
            cestaCompra.InsertarArticulo(articulo_4);

            //Borramos articulos del carrito.
            cestaCompra.BorrarArticulo(articulo_1);

            //Mostramos la lista de articulos que tenemos en el carrito de la compra.
            //cestaCompra.MostrarListaCarro();

            //Mostramos la lista de articulos del carrito de la compra, pero ordenado por precio.
            cestaCompra.MostrarListaCarroOrdenadoPorPrecio();

            //Mostramos la lista de articulos del carrito de la compra, pero ordenado por nombre y precio.
            cestaCompra.MostrarListaCarroOrdenadoPorNombrePrecio();

            Console.Read();
        }
    }
}
