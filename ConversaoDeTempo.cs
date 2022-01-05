
using System;

namespace dioDesafioTres
{
    class ConversaoDeTempo
    {
    /*
        Desafio
        Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de 
        um determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

        Entrada
        O arquivo de entrada contém um valor inteiro N.

        Saída
        Imprima o tempo lido no arquivo de entrada (segundos), convertido 
        para horas:minutos:segundos, conforme exemplo fornecido.
    */
        static void Main(string[] args)
        {
            var timeInSecond =int.Parse(Console.ReadLine());
            
            var hours = timeInSecond /3600;
            timeInSecond = timeInSecond % 3600;
            var minutes =  timeInSecond /60;
            var seconds = timeInSecond - minutes * 60;
            
            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
