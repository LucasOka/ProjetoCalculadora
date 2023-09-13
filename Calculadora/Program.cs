using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exibir = false;
            // Fila primeiro entrar/primeiro sair
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            // Array usado para saber operações faltantes
            Operacoes [] memOp;
            // Fila primeiro entrar/ ultimo sair 
            Stack<long> filaDeResultadosFinais = new Stack<long>();
            // adicionar as informações ma fila de operação 
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });                       
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });
            // memoriza o tamanho da fila
            int numeroDeOperacoes = filaOperacoes.Count;
            // Array que será usado para inverter os resultados para ser armazenados na fila
            long[] memResultado = new long[filaOperacoes.Count];  
            Calculadora calculadora = new Calculadora();
            Exibicao exibicao = new Exibicao();
            while (filaOperacoes.Count > 0)
            {               
                // Variavél operação recebe o primeiro elemento da fila e o remove em seguida 
                Operacoes operacao = filaOperacoes.Dequeue();
                // Existe essa condição para exibir as operações a partir da segunda
                if (exibir)
                {
                    // Copia para o Array que será usado no método de exibição
                    memOp = filaOperacoes.ToArray();
                    exibicao.Exibir(memOp,filaOperacoes.Count);
                }
                calculadora.calcular(operacao);
                // guarda no Array de inverter para ser usado futuramente 
                memResultado[filaOperacoes.Count] = operacao.resultado;
                exibir = true;                
                Console.WriteLine("Exibindo operação completa");
                // imprime a operação completa 
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);               
            }
            // Coloca os resultados na fila nova 
            for (int i = 0; i <numeroDeOperacoes; i++) filaDeResultadosFinais.Push(memResultado[i]);
            Console.WriteLine("Resultados finais");
            while (filaDeResultadosFinais.Count > 0)
            {
                // Exibe os resultados finais 
               long resultadoFinais = filaDeResultadosFinais.Pop();
               Console.WriteLine(resultadoFinais);
            }
           
           
           
        }
    }
}
