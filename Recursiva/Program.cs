using System;
using System.IO;

namespace Recursiva
{
    class Program
    {
        static void Main(string[] args)
        {

            string numero;
            int i;
            Console.WriteLine("Digite um numero:");
            i = Convert.ToInt32(Console.ReadLine());

            looping(i);



            LerArq(@"C:\TESTE\lucas00.txt");
            //LerArq(1);

            Console.WriteLine("Digite um numero:");
            numero=Console.ReadLine();

            TransformarNumero(numero);

        }

        public static void looping(int a)// Fução recursiva, passando os parametros direto do metodo;
        {
            Console.WriteLine(a);// imprimindo a variavel;
            if (a < 20)// teste de menor que na variavel 
            {
                looping(a + 1);// atribuição de uma varaivael recusiva; 
                // Pedi para Rafael explicar melhor essa função;

            }
        }


        //Função recursiva, passando valores por parâmetros 
         private static void LerArq(string numArq)
        //private static void LerArq(int caminho)
        // Função declarada para funcionar apenas 
        //na classe local
        // Utilizar nomes de variavel nos parâmetros como CamelCase
        {
            string arcaminho = @"C:\TESTE\lucas00.txt";
           // if (File.Exists(arcaminho))
           // {
                //Inicializando a Variavel com o local do Arquivo (Sempre colocar o local do araquivo correto)
                //sempre "concatenar com o seu tipo" 
               // string aar = @"C:\TESTE\lucas00" + arcaminho + ".txt";
                {
                //Nesse Instância, é necessario baixar as bibliotecas corretas, como a (FILE.OpemText)
                //O Using é ...... 
                using (StreamReader arquivo = File.OpenText(arcaminho)) 
                {
                    string linha;
                    // Laço para ler todos os textos dentro dos arquivos
                    // A Variavel "Arquivo está carregada com o valor passado de "numArq"
                    //O ReadLine vai lendo linha a linha
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        //imprimido a varivavel responsvel por todo o carregamento  
                        Console.WriteLine(linha);
                    }
                    
                }

                }

            }

    
    public  static  void TransformarNumero(string n)
    {
        
        int Inter = Convert.ToInt32(n);
        Console.WriteLine(Inter);




    }
        }

    }
