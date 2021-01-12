using System;

namespace Para_For
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string ss;

             Console.WriteLine("Vc deseja executar i programa?");
            ss = Console.ReadLine();
            
            while (ss == "s")
            {
                teste();
                Console.WriteLine("Deseja rodar novamente?");
                ss=Console.ReadLine();
                //Console.Read();// Pausando a Impressão na tela

            }


            Console.WriteLine("Obrigado!"); 

        }

        private static void teste()
        {
            for (int n = 0; n < 15; n++)//Função para (Todos os comando são administrado dentro do seu comando()) 
            {
                Console.WriteLine("Hello World!" + n);
            }
            string[] i = { "Lucas ", "Antonela ", "Anastacia" };
            foreach (string op in i)// função simplificada para o FOR (PARA)
            {

                Console.WriteLine("O que tem dentro do meu Arrey é:  " + op);
            }
        }
    }
}
