using System;
using System.Collections.Generic;

namespace Tienda
{
    public class Catalogo
    {
        private static List<Articulo> Inventario { get; set; } = new List<Articulo>();

        static Catalogo()
        {
            LlenarCatalogo();
        }

        private static void LlenarCatalogo()
        {
            Inventario = new List<Articulo>
            {
                new Articulo { Nombre = "Jabón", Precio = 18.9m, ID = 1 },
                new Articulo { Nombre = "Mayonesa", Precio = 45m, ID = 2 },
                new Articulo { Nombre = "Tomate", Precio = 50m, ID = 3 },
                new Articulo { Nombre = "Carne", Precio = 120m, ID = 4 },
                new Articulo { Nombre = "Huevo", Precio = 80m, ID = 5 },
            };
        }

        public static void MostrarCatalogo()
        {
            Console.WriteLine("Catálogo de artículos disponibles:");
            foreach (Articulo art in Inventario)
            {
                Console.WriteLine($"{art.ID} - {art.Nombre} - {art.Precio:C2}");
            }
        }

        public static Articulo BuscarArticuloPorID(int artID)
        {
            return Inventario.Find(x => x.ID == artID);
        }
    }
}