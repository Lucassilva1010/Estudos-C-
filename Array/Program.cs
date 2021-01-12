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
      
            ss[0] = "Lucas ";
            ss[1] = "Antonella ";
            ss[2] = "Lucas ";
            ss[3] = "Anastacia "; 
            ss[3] = "José ";

           foreach(string most in  ss)
            {

                Console.WriteLine(most);
            }

            Console.Read();
                
        }

     

    }

}
