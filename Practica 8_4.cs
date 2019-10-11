using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_8
{
    class Practica_8_4
    {
        //Andres Lemus 25/09/2019

        public enum TipoDePago
        {
            Efectivo = 1, TarjetaDebito = 2, TarjetaCredito = 3
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Metodo de Pago");
            Console.WriteLine();
            Console.WriteLine("[1] Efectivo");
            Console.WriteLine("[2] Tarjeta de Debito");
            Console.WriteLine("[3] Tarjeta de Credito");
            Console.Write("Metodo de pago que desea utilizar: ");
            int tipo = Convert.ToInt32(Console.ReadLine());
            switch (tipo)
            {

            }
        }
    }
}
