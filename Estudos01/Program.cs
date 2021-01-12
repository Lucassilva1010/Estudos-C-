using System;

namespace Estudos01 //Nome do Projeto 
{
    class Program//Classe do Projeto
    {
        static void Main(string[] args) // Metodo Principal defifindo por o MAIN
        {                               // Pq se usa sempre [] ARGS

            Console.WriteLine("Hello World!"); // 1 Opção de impressão em telas (Console)
            //Console.Read(); //Para a apresentação sem encerrar 

            //Operações de condicional simples 

           // int  a = 10; // Variavel Statica   (Pode ser usado as 2 Tipagens apresentadas)
            var a = 100; // Varivavel Dinamica 
            if(a == 10)//Condição de teste logico.  (Se caso tiver apenas 1 comando para resultados, pode ser utilizada sem {})
            {
                Console.WriteLine("A é igual a 10");
            }
            else if (a==100) // COndição é ativa se caso a primeira não for verdadeira
            {
                Console.WriteLine("A é igual a 100");
            }else // essa condição entra em ação, caso as demais não seja verdadeiras
            {
                Console.WriteLine("Numero diferente de 10 e 100!");
            }
            Console.Read();// Congelando a impressão na tela!
        }
    }
}
