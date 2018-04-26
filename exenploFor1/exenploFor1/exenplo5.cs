using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exenploFor1
{
    class exenplo5
    {
        public exenplo5()
        {
            int[] levelNoL = new int[5];
            for (int i = 0; i < levelNoL.Length; i++)
            {
                Console.WriteLine(  "dijite seu laevel no lol ");
                levelNoL[i] = Convert.ToInt32(Console.ReadLine());
            }
            int somaLevels = 0;
            for (int i = 0; i < levelNoL.Length; i++)
            {
                somaLevels = levelNoL[i] + somaLevels;
            }
            double medialevel = somaLevels / levelNoL.Length;
            Console.WriteLine("media " + medialevel);
        }
    }
}
