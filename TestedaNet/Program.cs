using System;

namespace TestedaNet
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = 0;
            int teclado = 0;
            string sair = "s";
            
            Console.WriteLine("Programa para verificar se o numero é par ou impar!");

            while (sair == "s")
            {
                Console.Clear();

                Console.WriteLine("Digite o numero para testagem! ");
                n = Convert.ToInt32(Console.ReadLine()); // comando para converter e receber comando do teclado

                teclado =n % 2; // atribuindo Resto de uma divisão em uma variavael 

                if (teclado == 0)// testando o resultado da divisão, para saber se ela é igual ao 0;
                {
                    Console.WriteLine("Numero par!");
                }
                else
                {
                    Console.WriteLine("Numero Impar!");
                }
                Console.WriteLine("Deseja testar outro numero? s/n");
                sair = Console.ReadLine(); // Encerra o comando do teclado; 

            }
            
        }
    }
}
