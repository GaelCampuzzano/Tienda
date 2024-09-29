using System;

namespace Tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool realizarOtraCompra = true;

            while (realizarOtraCompra)
            {
                Carrito carrito = new Carrito();
                bool agregarMasArticulos = true;

                while (agregarMasArticulos)
                {
                    Console.WriteLine("Selecciona el artículo:");
                    Catalogo.MostrarCatalogo();

                    try
                    {
                        int artID = Convert.ToInt32(Console.ReadLine());
                        Articulo articuloSeleccionado = Catalogo.BuscarArticuloPorID(artID);

                        if (articuloSeleccionado != null)
                        {
                            Console.WriteLine("Ingresa la cantidad del artículo:");
                            articuloSeleccionado.Cantidad = Convert.ToInt32(Console.ReadLine());

                            carrito.AgregarAlCarrito(articuloSeleccionado);
                        }
                        else
                        {
                            Console.WriteLine("Artículo no encontrado.");
                        }

                        Console.WriteLine("¿Deseas agregar otro artículo? (s/n)");
                        string respuesta = Console.ReadLine();
                        agregarMasArticulos = respuesta.ToLower() == "s";
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                    }
                }

                Caja caja = new Caja(1); // El número de caja puede cambiar si lo deseas
                caja.IngresarCarrito(carrito);
                caja.Cobrar();

                Console.WriteLine("¿Deseas realizar otra compra? (s/n)");
                string otraCompraRespuesta = Console.ReadLine();
                realizarOtraCompra = otraCompraRespuesta.ToLower() == "s";
            }

            Console.WriteLine("Gracias por usar nuestro sistema de tienda.");
            Console.ReadLine();
        }
    }
}