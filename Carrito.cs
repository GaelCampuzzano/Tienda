using System;
using System.Collections.Generic;

namespace Tienda
{
    public class Carrito
    {
        public List<Articulo> Lista { get; set; } = new List<Articulo>();

        public void AgregarAlCarrito(Articulo articulo)
        {
            Lista.Add(articulo);
            Console.WriteLine($"Se ha agregado {articulo.Nombre} al carrito.");
        }
    }
}