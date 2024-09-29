using System;

namespace Tienda
{
    public class Caja
    {
        private static int NumCompra = 0;
        public int Numero { get; set; }
        private decimal Pagando { get; set; }
        private decimal Cambio { get; set; }
        private Carrito carrito;
        private decimal SubTotal { get; set; }
        private decimal Total { get; set; }

        public Caja(int numero)
        {
            Numero = numero;
        }

        public void IngresarCarrito(Carrito carrito)
        {
            this.carrito = carrito;
            SubTotal = 0;
            foreach (Articulo articulo in carrito.Lista)
            {
                SubTotal += articulo.Precio * articulo.Cantidad;
            }
            MostrarTotales();
        }

        private void MostrarTotales()
        {
            decimal IVA = Math.Round(SubTotal * 0.16m, 2);
            Total = Math.Round(SubTotal + IVA, 2);
            Console.WriteLine($"SubTotal: {SubTotal:C2}");
            Console.WriteLine($"IVA: {IVA:C2}");
            Console.WriteLine($"Total: {Total:C2}");
        }

        public void Cobrar()
        {
            Console.WriteLine("Ingrese cantidad a pagar:");
            try
            {
                Pagando = Convert.ToDecimal(Console.ReadLine());
                if (Pagando < Total)
                {
                    Console.WriteLine("Cantidad insuficiente para realizar la compra.");
                    return;
                }
                Cambio = Math.Round(Pagando - Total, 2);
                Console.WriteLine($"Cambio: {Cambio:C2}");
                ImprimirTicket();
            }
            catch (FormatException)
            {
                Console.WriteLine("Cantidad inválida. Intente de nuevo.");
            }
        }

        private void ImprimirTicket()
        {
            NumCompra++;
            Ticket ticket = new Ticket
            {
                Lista = carrito.Lista,
                Total = Total,
                Pagado = Pagando,
                Cambio = Cambio,
                Fecha = DateTime.Now,
                NumCompra = NumCompra,
                IVA = Math.Round(SubTotal * 0.16m, 2)
            };
            ticket.Imprimir();
        }
    }
}