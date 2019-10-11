using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_8
{
    class Practica8_3
    {
        //Andres Lemus 25/09/2019
        public struct Materia
        {
            public string nombre;
            private decimal nota;

            public void setNota(decimal nota)
            {
                if (nota >= 0 && nota <= 10)
                {
                    this.nota = nota;
                }
            }

            public decimal getNota()
            {
                return nota;
            }

            public void Resultado(decimal nota)
            {
                if (nota >= 7)
                {
                    Console.WriteLine("Aprobado");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }
        }

        public struct Alumnos
        {
            public string carnet;
            public string nombre;
            public string carrera;
            public Materia materia1;
            public Materia materia2;
            public Materia materia3;
            public Materia materia4;


        }
        static void Main(string[] args)
        {
            Console.Write("Cantidad de alumnos: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Alumnos[] alm = new Alumnos[a];
            for (int j = 0; j < alm.Length; j++)
            {
                Console.WriteLine("Alumno #" + (j + 1));
                Console.WriteLine();
                Materia datMateria = new Materia();
                Console.WriteLine("Nombre Materia #: " + (j + 1));
                datMateria.nombre = Console.ReadLine();
                Console.WriteLine("Nota Materia #: " + (j + 1));
                datMateria.setNota(Convert.ToDecimal(Console.ReadLine()));
                if (datMateria.getNota >= 7)
                {

                }
            }
        }
    }
}
