using System;

namespace Ternario
{
    class Program
    {
        public const int SAIDA_PRO = 1;// Declaração de uma variavel Constante 
        static void Main(string[] args)
        {


            while (true)// Laço para entrar em Looping 
            {
             // mostrando na tela uma mensagem de entrada para o usuario 
             // Sempre que concatenar uma variavel no meio da mensagem,
             //irá aparecer o resultado da mesma
                Console.WriteLine("Digite" +SAIDA_PRO+" Para sair do Programa.");
                int ss = int.Parse(Console.ReadLine());//variavel para receber dados do teclado
                // Variavel sendo convertida para o valor String, atraves do comando Console.READLINE
                    if (SAIDA_PRO == ss)//Analisando a enttrada do teclado 
                {
                    break;// Encerrando o programa
                }
                else// entrando no programa caso o usuario deseje
                {


            // O ternario pode ser Administrado diretamente da variavel, ou podemos criar IF's, 
            //o que sairia do padrão ternario, pois ele é usado para simplificar CODIGOS
           // string test = "Teste"; // Variavel Inicializada;
            int a = 1;
            // criando  ternario 

            string teste = (a == 1 ? "A igual a 1!": "A é diferente de 1!");// Estrutura Ternario, codigo simples

            Console.WriteLine("O valor de A é: "+teste);
            }

                }
            
        }
    }
}
