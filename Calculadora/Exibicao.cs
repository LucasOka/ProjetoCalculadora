using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Exibicao
    {
        // método criado para exibir a quantidade de operações que falta 
        public void Exibir(Operacoes[] memOp,int numMax)
        {
            Console.WriteLine("Operações faltantes");
            for (int i = 0; i < numMax; i++) Console.WriteLine("{0} {1} {2}", memOp[i].valorA, memOp[i].operador, memOp[i].valorB);
        }
    }
}
