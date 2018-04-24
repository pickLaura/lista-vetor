using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_vator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numero = new int[16];
            
    
            Console.WriteLine("dijite 16 numeros");
            Console.WriteLine("dijite um numero");
            numero[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dijite outro numero");
            numero[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dijite outro numero");
            numero[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dijite outro numero");
            numero[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dijite outro numero");
            numero[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dijite outro numero");
            numero[5] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dijite outro numero");
            numero[6] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dijite outro numero");
            numero[7] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dijite outro numero");
            numero[8] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dijite outro numero");
            numero[9] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dijite outro numero");
            numero[10] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dijite outro numero");
            numero[11] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dijite outro numero");
            numero[12] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dijite outro numero");
            numero[13] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dijite outro numero");
            numero[14] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dijite outro numero");
            numero[15] = Convert.ToInt32(Console.ReadLine());


           int soma = numero[0] + numero[1] + numero[2] + numero[3] + numero[4] + numero[5] + numero[6] + numero[7] + numero[8] + numero[9] + numero[10] + numero[11] +
                 numero[12] + numero[13] + numero[14] + numero[15];
            Console.WriteLine("soma de todos os numeros: " + soma); 
        }
    }
}
