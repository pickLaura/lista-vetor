using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaVetorN03
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] preso = new double[7];
            string[] produdo = new string[7];
            Console.WriteLine("digite o preso de 7 produtos: ");

            preso[0] = Convert.ToDouble(Console.ReadLine());
            preso[1] = Convert.ToDouble(Console.ReadLine());
            preso[2] = Convert.ToDouble(Console.ReadLine());
            preso[3] = Convert.ToDouble(Console.ReadLine());
            preso[4] = Convert.ToDouble(Console.ReadLine());
            preso[5] = Convert.ToDouble(Console.ReadLine());
            preso[6] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("dijite 7 produtos");

            produdo[0] = Console.ReadLine();
            produdo[1] = Console.ReadLine();
            produdo[2] = Console.ReadLine();
            produdo[3] = Console.ReadLine();
            produdo[4] = Console.ReadLine();
            produdo[5] = Console.ReadLine();
            produdo[6] = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("1º Produtos e presos: " + preso[0] +","+ produdo[0]);
            Console.WriteLine("2º Produtos e presos :" + preso[1] +"," +produdo[1]);
            Console.WriteLine("3º Produtos e presos: " + preso[2] +"," +produdo[2]);
            Console.WriteLine("4º Produtos e presos: " + preso[3] +"," +produdo[3]);
            Console.WriteLine("5º Produtos e presos :" + preso[4] +"," +produdo[4]);
            Console.WriteLine("6º Produtos e presos :" + preso[5] +"," +produdo[5]);
            Console.WriteLine("7º Produtos e presos: " + preso[6] +"," +produdo[6]);
            
        }
    }
}
