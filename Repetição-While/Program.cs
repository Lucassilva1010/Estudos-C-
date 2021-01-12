using System;

namespace Repetição_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1; // Varivavel Iniciada 

            while (i <= 10) // Estutura de repetição (Enquanto)
            {
                if (i != 5)
                {
                    i++;
                    Console.WriteLine(i);
                    //break;
                    //continue;

                }

                //Aqui se forma todo o bloco para a esturua While (Lembrar sempre de colocar um ponto para parar o looping)
                 Console.WriteLine(i);// Imprimindo a Variavel 
                                       i = i + 5; // Incremento para variavel, e também não entrar em looping
                                      //i++;// Incremento para não entrar em looping 
                break;

               
            }
            
        
        
        
        
        
        
        }




    }
}
