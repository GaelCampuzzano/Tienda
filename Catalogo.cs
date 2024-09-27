using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Catalogo
    {
        private static List<Articulo> Inventario { get; set; }

        private static void LlenarCatalogo()
        {
            Inventario = new List<Articulo>
            {
                new Articulo {Nombre = "Jabon", Precio = 18.9f, ID = 1},
                new Articulo {Nombre = "Mayonesa", Precio = 45f, ID = 2},
                new Articulo {Nombre = "Tomate", Precio = 50f, ID = 3},
                new Articulo {Nombre = "Carne", Precio = 120f, ID = 4},
                new Articulo {Nombre = "Huevo", Precio = 80f, ID = 5},
            };
        }

        public static void MostrarCatalogo()
        {
            LlenarCatalogo();
            foreach (Articulo art in Inventario)
            {
                Console.WriteLine($"{art.ID} - {art.Nombre} - {art.Precio}\n");
            }
        }

        public static Articulo BuscarArticulosPorID(int artID)
        {
            return Inventario.Find(x => x.ID.Equals(artID));
        }
    }
}