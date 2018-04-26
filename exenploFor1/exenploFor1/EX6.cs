using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exenploFor1
{
    class EX6
    {
        public EX6()
        {
            Console.WriteLine("digite qua ntidade de registros que deja cadastrar ");
            int quantidadeZ=Convert .ToInt32(Console.ReadLine());

            string[]fazenda =new string[quantidadeZ];
            int[] quantidade = new int[quantidadeZ];

            for(int i=0;i<fazenda.Length;i++){
                Console.WriteLine("nome fazenda ");
                fazenda[i]=Console.ReadLine();
                Console.WriteLine("quantidade de suinos ");
                quantidade[i]=Convert.ToInt32(Console.ReadLine());
            }
        
            //fazenda com maior numero de suinoa
            int  menorquantidadeS=int.MinValue;
            string fazendamaior="";
            if(int i=0;i<menorquantidadeS.Length;i++){
            if(quantidade[i]>menorquantidadeS){
                menorquantidadeS=quantidade[i];
                fazendamaior=fazenda[i];
            }
            }
        
            Console.WriteLine("fazenda com maior quantidade de suinos "+
             fazendamaior+"contem"+menorquantidadeS);
            //fazenda com menor numero
            string menorNome="";
            for(int i=0;i<100;i++){
                if(i%2==0){
                    menorNome=menorNome+"a";
                }
                else{
                    menorNome=menorNome+"e";
                }
            }
            for(int i=0;i<fazenda.Length;i++){
                if(fazenda[i].Length<menorNome.Length){
                    menorNome=fazenda[i];
                }
            }
            Console.WriteLine("fazenda com menor nome "+menorNome);
        }
    }
}
