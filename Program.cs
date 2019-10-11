using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_8
{
    class Program
    {
        //Andrés Lemus 25/09/2019
        public struct Estudiante
        {
            public string carnet;
            public string nombre;
            public string carrera;
            private decimal cum;

            public void setCum(decimal cum)
            {
                if (cum >= 0 && cum <= 10)
                {
                    this.cum = cum;
                }
            }

            public decimal getCum()
            {
                return cum;
            }
        }

        static void Main(string[] args)
        {
            Estudiante est = new Estudiante();
            Console.WriteLine("Carnet: ");
            est.carnet = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            est.nombre = Console.ReadLine();
            Console.WriteLine("Carrera: ");
            est.carrera = Console.ReadLine();
            Console.WriteLine("CUM: ");
            est.setCum(Convert.ToDecimal(Console.ReadLine()));
            Console.Clear();
            Console.WriteLine("Nombre: " + est.nombre);
            Console.WriteLine("Carnet: " + est.carnet);
            Console.WriteLine("Carrera: " + est.carrera);
            Console.WriteLine("CUM: " + est.getCum());

            Console.ReadKey();
        }
    }
}
