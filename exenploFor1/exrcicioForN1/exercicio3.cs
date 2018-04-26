using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exrcicioForN1
{
    class exercicio3
    {
        public exercicio3()
        {
            int tamanho = 10;
            for (int i = 0; i <= tamanho; i++)
            {
                for (int c = 0; c <= tamanho; c++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
    }
}
