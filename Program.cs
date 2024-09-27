using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrito carrito = new Carrito();

            Console.WriteLine("Selecciona El Articulo");
            Catalogo.MostrarCatalogo();
            int artID = Convert.ToInt32(Console.ReadLine());

            Articulo articuloSeleccionado = Catalogo.BuscarArticulosPorID(artID);

            if (articuloSeleccionado != null)
            {
                carrito.AgregarAlCarrito(articuloSeleccionado);
            }
            else
            {
                Console.WriteLine("Artículo no encontrado.");
            }

            Console.ReadLine();
        }
    }
}