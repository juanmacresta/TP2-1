using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Usuario");
            Console.WriteLine("2- Personas");
            Console.WriteLine("3- Especialidades");
            Console.WriteLine("4- Materia");
            Console.WriteLine("5- Comision");
            Console.WriteLine("6- Curso");
            Console.Write("Elija opcion: ");
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
               new Usuarios().Menu();
            }
            else if (op == 2)
            {
                new Personas1().Menu();
            }
            else if (op == 3)
            {
                new Especialidades().Menu();
            }
            else if (op == 4)
            {
                new Materias().Menu();
            }
            else if (op == 5)
            {
                new Comisiones().Menu();
            }
            else if (op == 6)
            {
                new Cursos().Menu();
            }
        }
    }
}
