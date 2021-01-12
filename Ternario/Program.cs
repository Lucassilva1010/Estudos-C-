using System;

namespace Ternario
{
    class Program
    {
        static void Main(string[] args)
        {
            // O ternario pode ser Administrado diretamente da variavel, ou podemos criar IF's, 
            //o que sairia do padrão ternario, pois ele é usado para simplificar CODIGOS
            string test = "Teste"; // Variavel Inicializada;
            int a = 1;
            // criando  ternario 

            string teste = (a == 1 ? "A igual a 1!": "A é diferente de 1!");// Estrutura Ternario, codigo simples

            Console.WriteLine("O valor de A é: "+teste);

            
        }
    }
}
