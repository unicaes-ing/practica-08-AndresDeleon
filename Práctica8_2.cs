using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_8
{
    class Práctica8_2
    {
        //Andrés Lemus 25/09/2019

        public struct Producto
        {
            public string nombre;
            private int cantidad;
            private decimal precio;

            public void setCantidad(int cantidad)
            {
                if (cantidad > 0)
                {
                    this.cantidad = cantidad;
                }
            }

            public int getCantidad()
            {
                return cantidad;
            }

            public void setPrecio(decimal precio)
            {
                if (precio > 0)
                {
                    this.precio = precio;
                }
            }

            public decimal getPrecio()
            {
                return precio * 1.13m * cantidad;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Cantidad de productos: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Producto[] prd = new Producto[p];
            for (int i = 0; i < p; i++)
            {
                Console.Clear();
                Console.WriteLine("Producto #" + (i + 1));
                Console.WriteLine("===========================================");
                Console.Write("Nombre: ");
                prd[i].nombre = Console.ReadLine();
                Console.Write("Cantidad: ");
                prd[i].setCantidad(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Precio: $");
                prd[i].setPrecio(Convert.ToDecimal(Console.ReadLine()));
            }
            Console.Clear();
            int n = 0;
            foreach (var producto in prd)
            {
                Console.WriteLine("Producto #" + (n + 1));
                Console.WriteLine("===========================================");
                Console.WriteLine("Nombre: " + prd[n].nombre);
                Console.WriteLine("Cantidad: " + prd[n].getCantidad());
                Console.WriteLine("Precio (+IVA): " + prd[n].getPrecio().ToString("C2"));
                Console.WriteLine();
                n++;
            }
            Console.ReadKey();
        }
    }
}
