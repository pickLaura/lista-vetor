using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaVeorsN04
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[4];
            string[] materia = new string[4];

            Console.WriteLine("digite 4 notas ");
            notas[0] = Convert.ToDouble(Console.ReadLine());
            notas[1] = Convert.ToDouble(Console.ReadLine());
            notas[2] = Convert.ToDouble(Console.ReadLine());
            notas[3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("dijite 4 materias ");
            materia[0] = Console.ReadLine();
            materia[1] = Console.ReadLine();
            materia[2] = Console.ReadLine();
            materia[3] = Console.ReadLine();

            Console.WriteLine("notas e materias: " + notas[0] + " " + materia[0]);
            Console.WriteLine("notas e materias: " + notas[1] + " " + materia[1]);
            Console.WriteLine("notas e materias: " + notas[2] + " " + materia[2]);
            Console.WriteLine("notas e materias: " + notas[3] + " " + materia[3]);

            

        }
    }
}
