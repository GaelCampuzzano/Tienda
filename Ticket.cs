using System;
using System.Collections.Generic;

namespace Tienda
{
    public class Ticket
    {
        public List<Articulo> Lista { get; set; }
        public decimal Total { get; set; }
        public decimal Pagado { get; set; }
        public decimal Cambio { get; set; }
        public DateTime Fecha { get; set; }
        public int NumCompra { get; set; }
        public decimal IVA { get; set; }

        public void Imprimir()
        {
            Console.Clear();
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine($"Número de Compra: {NumCompra}");
            Console.WriteLine("Artículos:");

            foreach (Articulo articulo in Lista)
            {
                Console.WriteLine($"{articulo.Nombre} - {articulo.Precio:C2} x {articulo.Cantidad} = {articulo.Precio * articulo.Cantidad:C2}");
            }

            Console.WriteLine($"Subtotal: {Total - IVA:C2}");
            Console.WriteLine($"IVA: {IVA:C2}");
            Console.WriteLine($"Total: {Total:C2}");
            Console.WriteLine($"Pagado: {Pagado:C2}");
            Console.WriteLine($"Cambio: {Cambio:C2}");
        }
    }
}