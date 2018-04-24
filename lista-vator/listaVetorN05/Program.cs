using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaVetorN05
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0, soma = 0;
            double[] peso = new double[5];
            Console.WriteLine("escreva seu peso ");
            peso[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("escreva seu peso ");
            peso[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("escreva seu peso ");
            peso[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("escreva seu peso ");
            peso[3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("escreva seu peso ");
            peso[4] = Convert.ToDouble(Console.ReadLine());
            soma = peso[0] + peso[1] + peso[2] + peso[3]+peso[4];
            media = soma / 5;
            Console.WriteLine("media dos pesos: " + media);
            Console.WriteLine("soma dos pasos: "+soma);

        }
    }
}
