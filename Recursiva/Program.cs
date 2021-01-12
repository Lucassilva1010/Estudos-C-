using System;

namespace Recursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            looping(1);    
        }

        public static void looping(int a)// Fução recursiva, passando os parametros direto do metodo;
        {
            Console.WriteLine(a);// imprimindo a variavel;
            if (a < 3)// teste de menor que na variavel 
            {
                looping(a + 1);// atribuição de uma varaivael recusiva; 
                // Pedi para Rafael explicar melhor essa função;

            }
        }

    }
}
