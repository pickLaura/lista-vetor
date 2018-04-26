using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exrcicioForN1
{
    class exercicio2
    {
        public exercicio2()
        { 
            int numero = 0;
            int tabuada=0;
           
            for (int i = 1; i <= 100; i++){

                for (numero = 0; numero <= 100; numero++)
                {
                    tabuada = i * numero;
                    Console.WriteLine(i+"*"+numero+"="+tabuada);
                }
            }
        }
    }
}
