using Array;
using System;

namespace Aluno_Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa();
            pessoa.PessoaFalando();
            string nome, s;

            int n1, n2, n3, n4;
            double med;

            Console.WriteLine("Seja bem vido ao progrmas de boletim de notas!");
                      
             
                Console.WriteLine("Digite o Nome do aluno! \n\n");
                nome = Console.ReadLine();
               
                Console.WriteLine("\nSeja bem Vindo!"+nome);
            Console.Clear();



            Console.WriteLine("Obrigado! \n");
            Console.Clear();
               

                Console.WriteLine("\nDigite a Nota 01 de:" +nome);
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Nota 01 de:" + nome);
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Nota 01 de:" + nome);
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Nota 01 de:" + nome);
            n4 = Convert.ToInt32(Console.ReadLine());
            

            med = (n1 + n2 + n3 + n4) / 2;

            if(med >= 7)
            {

                Console.WriteLine("Parabéns," + nome + " Sua media foi de: "+med);
                Console.WriteLine("Parabéns,"+nome+" Você foi Aprovado!");
            }
            else
            {
                Console.WriteLine("Melhore seus estudos! " + nome);
                Console.Clear();
            }

            Console.WriteLine("  ");

            Console.WriteLine("Deseja Continuar testando Alunos?");
                s = Console.ReadLine();
                        
            
            if (s == "sim")
            {
                Console.WriteLine("Seja bem vido ao progrmas de boletim de notas!");



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

                Console.WriteLine("Digite a Nota 01 de:" + nome);
                n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a Nota 01 de:" + nome);
                n3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a Nota 01 de:" + nome);
                n4 = Convert.ToInt32(Console.ReadLine());

                Console.Read();

                med = (n1 + n2 + n3 + n4) / 2;

                if (med >= 7)
                {

                    Console.WriteLine("Parabéns," + nome + " Sua media foi de: " + med);
                    Console.WriteLine("Parabéns," + nome + " Você foi Aprovado!");
                }
                else
                {
                    Console.WriteLine("Melhore seus estudos! " + nome);
                }
            }

            }
        }

          
    }

