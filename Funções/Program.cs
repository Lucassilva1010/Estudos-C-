using System;

namespace Funções
{
    class Program
    {
        // Criando Funções em todo o Programa

        /// Todas as Funções ou Metodos que Utilizam o STATIC, utilizam o "CONSOLE.", em ses CODIGOS. 
        static void Main(string[] args)
        {

            /// Metodo Principal, que é definido por: MAIN
            /// Esse é o Metodo de interação com os Usuarios, daqui vai tudo impresso 
            Console.WriteLine("Hello World!");
           Nomes();// Função de String para Imprimir nomes

            int teste = Soma();// criação de uma Variavel do Objeto "Fução", soma;
            Console.WriteLine(teste);// Função Estatica de somar numéros (está sendo repassada por 
            //parametro, por apenas somar e não ter função de impressão na sua função)
            Console.WriteLine(Soma());// Função Estatica de somar numéros (Impressa direto como
            //Objeto)


            Tabuada();// Função Publica e Void, para Imprimir a Tabuada

            Arrei();// função publica de array, retornando no CONSOLE.Writeline
           

            Console.Read();// Pausa na Apresentação; 
        }
        public static int Soma()// Função e Inteiro retornando algum numéro Inteiro
        {
            int a=1;
            int b=2;
            int s = a + b;
            return (s);

        }

        static string Nomes()// Função não Publica, que retornar valor de String 
        {
            string n;
            Console.WriteLine("\nQual o SEU NOME?\n ");
            n = Console.ReadLine();
            return (n);
        }

        public static void Tabuada(){// Função Statica que não retorna valores, representada por VOID
            int num;

            Console.WriteLine("Qual o Numero que vc deseja saber a tabuada?");
            num = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < 10; i++)// variavel criada dentro da condição e sendo encrementada

            {
                // Recebendo o numero do teclado, e sendo concatenada por o 
                //valor do laço de repetição FOR
                Console.WriteLine(num +"x" + i+" =" + (num*i));

            }

          }
        public static void Arrei()
        {
            string[] nomes = new string[1];
           
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite  " +i+ "  nomes:");
                nomes[i]= Console.ReadLine();
            }
            foreach (var n in nomes)
            {

                 Console.WriteLine("Os Nomes dentro do Arrey são: " +n);
                
            }
            //return (n);
        }

    }
}
