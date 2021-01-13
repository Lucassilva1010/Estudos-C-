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


            // O uso da da String com "S", será um "Objeto String" e não uma Variavel
            List<string> ss = new List<string>(); 
            
            // insereindo valores na Lista
            ss.Add("Lucas");// adicionando valores a cara posição da lista;
            ss.Add("Antonella");
            ss.Add("Anastacia");
            
            int i = 0;

            do
            { // colocando em looping a toda a operação se caso o nome do Indice
              // forverdadeiro;
                Console.WriteLine("......");

                foreach (string c in ss)
                {
                    if ((c == "Lucas") || (c == "Antonella") || (c == "Anastacia"))// Buscando nome inserido na Lista, e acionando comando;
                    {
                        Console.WriteLine("Nomes Aceito!" + c);
                                          }
                    else
                    {
                        Console.WriteLine("Nome não encontrado, ou digitação errada!");
                        Console.WriteLine("Repita a Operação");
                    }
                    // Console.WriteLine(c);
                }
                i++;
                Console.WriteLine("Familia formada!");
            } while (i < 1);

            Console.Read();
        }
    }
}
