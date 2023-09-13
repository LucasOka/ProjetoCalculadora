using System;
namespace Calculadora
{
    public class Calculadora
    {
        
        public Operacoes calcular(Operacoes operacao)
        {
            // Verifica qual o operador escolhido
            switch(operacao.operador)
            {
                case '+': operacao.resultado= soma(operacao);break;
                case '-': operacao.resultado = subtracao(operacao);break;
                case '*': operacao.resultado = multiplicacao(operacao);break;
                case '/': operacao.resultado = divisao(operacao);break;
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        // operação de soma
        public long soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        // operação de subtração 
        public long subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        // operação de multiplicação 
        public long multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        // operação de divisão 
        public long divisao(Operacoes operacao)
        {
            return operacao.valorA / operacao.valorB;
        }
       
    }
}
