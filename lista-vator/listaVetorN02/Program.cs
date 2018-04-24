using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaVetorN02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            Console.WriteLine("dijite nome de 10 pessoas");
            nome[0] = Console.ReadLine();
            nome[1] = Console.ReadLine();
            nome[2] = Console.ReadLine();
            nome[3] = Console.ReadLine();
            nome[4] = Console.ReadLine();
            nome[5] = Console.ReadLine();
            nome[6] = Console.ReadLine();
            nome[7] = Console.ReadLine();
            nome[8] = Console.ReadLine();
            nome[9] = Console.ReadLine();

            Console.WriteLine( "1º nome "+nome[0]);
            Console.WriteLine("2º nome "+nome[1]);
            Console.WriteLine("3º nome "+nome[2]);
            Console.WriteLine("4º nome "+nome[3]);
            Console.WriteLine("5º nome "+nome[4]);
            Console.WriteLine("6º nome " + nome[5]);
            Console.WriteLine("7º nome " + nome[6]);
            Console.WriteLine("8º nome " + nome[7]);
            Console.WriteLine("9º nome " + nome[8]);
            Console.WriteLine("10º nome "+nome[9]);


        }
    }
}
