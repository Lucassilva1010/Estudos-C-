using System;

namespace Recursiva_NotasAluno
{
    class Program
    {
                  
        static void Main(string[] args)
        {
            
            string s;

            do
            {

                Console.WriteLine("Bemvindo ao programa de Notas de Aluno\n");
                notas();

                Console.WriteLine("\n\nDeseja continuar testando?");
                s = Console.ReadLine();

            } while ((s != "n") && (s != "não"));
        }

        // Toda a Esturura, usando a variavel sendo Inicializada
        //   string s = ""; 
        //    while((s !="n")&& (s != "não"))
        //    {

        //    Console.WriteLine("Bemvindo ao programa de Notas de Aluno\n");
        //    notas();

        //        Console.WriteLine("\n\nDeseja continuar testando?");
        //        s = Console.ReadLine();
        //    }
        //}


        public static void notas()
        {
            string nome, s;
            int n1, n2, n3, n4;
            double med;
            Console.WriteLine("Digite o Nome do aluno!");
            nome = Console.ReadLine();
            Console.WriteLine("   ");
            Console.WriteLine("   ");
            Console.WriteLine("Seja bem Vindo!" + nome);
            Console.Clear();

            Console.WriteLine("Obrigado!");
            Console.Clear();
            Console.WriteLine("   ");

            Console.WriteLine("Digite a Nota 01 de:" + nome);
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Nota 02 de:" + nome);
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Nota 03 de:" + nome);
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Nota 04 de:" + nome);
            n4 = Convert.ToInt32(Console.ReadLine());
            med = (n1 + n2 + n3 + n4) / 4;

            if (med >= 7)
            {

                Console.WriteLine("Parabéns," + nome + " Sua media foi de: " + med);
                Console.WriteLine("Parabéns," + nome + " Você foi Aprovado!");
            }
            else
            {
                Console.WriteLine("Melhore seus estudos! " + nome);
                Console.Clear();
            }
        }


    }
}
