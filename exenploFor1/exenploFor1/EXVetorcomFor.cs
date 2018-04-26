using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exenploFor1
{
    class EXVetorcomFor
    {
        public EXVetorcomFor()
        {
            string[] mortesdoFilme = new string[5];
            //FORMA OLD
            //mortesDOFILME[0]="TOMI STARK";
            for (int i = 0; i < mortesdoFilme.Length; i++)
            {
                Console.WriteLine("digite o nome de passo que more no filme: ");
                mortesdoFilme[i] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("pessoas cadastradas:");
            for (int i = 0; i < mortesdoFilme.Length; i++)
            {
                Console.WriteLine("nome: " + mortesdoFilme[i]);
            }
        }
    }
}
