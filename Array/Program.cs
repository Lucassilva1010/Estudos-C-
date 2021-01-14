using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usando as 2 tipagens de Variaveis 
            /// 1 - Tipagem estatica 
            /// 2 - Tipagem Diamica
            string[] ss = new string[5];// Estatica 
            var nome = new string[5];// Dinamica

            // Setando o meu Arry
            for (int i = 0; i < ss.Length; i++)// Adicionando valor ao meu Array
                //o valor de "SS", é passado para Length(analisador de possição)
                //O laço vai se repetir até o valor total o Indice do Array
            {
                Console.WriteLine("Digite o Nome: \n");
                ss[i] = Console.ReadLine();
            }
          
           foreach(string most in  ss)
            {

                Console.WriteLine(most);
            }

            Console.Read();
                
        }

     

    }

}
