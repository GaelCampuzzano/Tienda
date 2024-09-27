using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Carrito
    {
        public List<Articulo> Lista { get; set; } = new List<Articulo>();

        public void AgregarAlCarrito(Articulo articulo)
        {
            Lista.Add(articulo);
            Console.WriteLine($"Se ha agregado {articulo.Nombre} al carrito.");
        }
    }
}