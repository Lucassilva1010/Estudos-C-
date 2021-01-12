using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Criando uma Lista de String no C#
            /// Criar uma lista em C#, sempre é preciso ADD a DLL de nome: Colletions..Generic;

            List<String> ss = new List<string>();
            // insereindo valores na Lista
            ss.Add("lucas");// adicionando valores a cara posição da lista;
            ss.Add("Antonella");
            ss.Add("Anastacia");

           // Por que não se pode Imprimir a variavel de referencia direta da Lista? 


            foreach(String c in ss)
            {
                Console.WriteLine(c);
            }

            Console.Read();
        }
    }
}
