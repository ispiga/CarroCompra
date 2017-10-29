using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroCompra
{
    class Articulo : IComparable<Articulo>
    {
        private string nombreArticulo;
        private string descripcion;
        private float precio;
        private int unidades;

        /// <summary>
        /// Constructor de la clase Articulo.
        /// </summary>
        /// <param name="nombreArticulo"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        public Articulo(string nombreArticulo, string descripcion, float precio)
        {
            this.nombreArticulo = nombreArticulo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.unidades = 1;
        }

        /// <summary>
        /// Get y Set de Nombre del Articulo.
        /// </summary>
        public string NombreArticulo
        {
            get { return nombreArticulo; }
            set { nombreArticulo = value; }
        }

        /// <summary>
        /// Get y Set de la Descripcion del Articulo.
        /// </summary>
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        /// <summary>
        /// Get y Set del Precio del Articulo.
        /// </summary>
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        /// <summary>
        /// Get y Set de las Unidades del Articulo.
        /// </summary>
        public int Unidades
        {
            get { return unidades; }
            set { unidades = value; }
        }

        /// <summary>
        /// Metodo Equals sobreescrito para decir que dos articulos son iguales
        /// si tienen el mismo nombre y la misma descripcion.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object o)
        {
            if (o is Articulo)
            {
                Articulo articulo = (Articulo)o;
                if (this.NombreArticulo == articulo.NombreArticulo && this.Descripcion == articulo.Descripcion)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Metodo GetHashCode sobreescrito para el Equals.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int num = 31;
            int result = 1;
            result = num * result + ((NombreArticulo == null) ? 0 : NombreArticulo.GetHashCode());
            result = num * result + ((Descripcion == null) ? 0 : Descripcion.GetHashCode());
            return result;
        }

        /// <summary>
        /// Metodo CompareTo sobreescrito para ordenar por precio los articulos.
        /// </summary>
        /// <param name="articulo"></param>
        /// <returns></returns>
        public int CompareTo(Articulo articulo)
        {
            if (this.precio > articulo.precio)
            {
                return 1;
            }
            if (this.precio < articulo.precio)
            {
                return -1;
            }
            return 0;
        }

        /// <summary>
        /// Metodo ToString sobreescrito para imprimir en consola  
        /// la lista de articulos del carro de compra.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return " Artículo: " + nombreArticulo + "\n" 
                + " Descripción: " + descripcion + "\n" 
                + " Precio: " + precio + " Euros" + "\n" 
                + " Unidades: " + unidades 
                + "\n ------------------------------------------------ \n";
        }
        
    }
}
