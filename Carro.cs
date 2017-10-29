using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroCompra
{
    class Carro
    {
        //Instanciamos una lista de la clase Articulo.
        List<Articulo> listaArticulos = new List<Articulo>();

        /// <summary>
        /// Metodo para buscar un articulo en la lista, utilizando
        /// Equals redefinido en la clase Articulo.
        /// </summary>
        /// <param name="articulo"></param>
        /// <returns></returns>
        public Articulo BuscarArticulo(Articulo articulo)
        {
            foreach (Articulo articuloEnLista in listaArticulos)
            {
                if (articuloEnLista.Equals(articulo))
                {
                    return articuloEnLista;
                }
            }
            return null;
        }

        /// <summary>
        /// Metodo para eliminar un articulo de la lista.
        /// </summary>
        /// <param name="articulo"></param>
        public void InsertarArticulo(Articulo articulo)
        {
            if (listaArticulos.Contains(articulo))
            {
                Articulo articuloExistente = BuscarArticulo(articulo);
                articuloExistente.Unidades = articuloExistente.Unidades + 1;
            }
            else
            {
                listaArticulos.Add(articulo);
            }
        }

        /// <summary>
        /// Metodo para eliminar un articulo de la lista.
        /// </summary>
        /// <param name="articulo"></param>
        public void BorrarArticulo(Articulo articulo)
        {
            if (listaArticulos.Contains(articulo))
            {
                Articulo articuloExistente = BuscarArticulo(articulo);
                articuloExistente.Unidades = articuloExistente.Unidades - 1;
                if (articuloExistente.Unidades == 0)
                {
                    listaArticulos.Remove(articuloExistente);
                }
            }
        }

        /// <summary>
        /// Lista articulos carro sin ordenacion.
        /// </summary>
        public void MostrarListaCarro()
        {
            foreach (Articulo articuloEnLista in listaArticulos)
            {
                Console.WriteLine(articuloEnLista);
            }
        }

        /// <summary>
        /// Lista articulos carro con ordenacion por precio, con el
        /// CompareTo redefinido en la clase Articulo.
        /// </summary>
        public void MostrarListaCarroOrdenadoPorPrecio()
        {
            listaArticulos.Sort();    

            foreach (Articulo articuloEnLista in listaArticulos)
            {
                Console.WriteLine(articuloEnLista);
            }
        }

        /// <summary>
        /// Lista articulos carro con ordenacion por nombre, con el metodo Comparison 
        /// definido aqui con delegate, y por precio con el CompareTo 
        /// redefinido en la clase Articulo.
        /// </summary>
        public void MostrarListaCarroOrdenadoPorNombrePrecio()
        {
            listaArticulos.Sort(delegate (Articulo articulo1, Articulo articulo2) { return articulo1.NombreArticulo.CompareTo(articulo2.NombreArticulo); });

            foreach (Articulo articuloEnLista in listaArticulos)
            {
                Console.WriteLine(articuloEnLista);
            }
        }
    }
}
