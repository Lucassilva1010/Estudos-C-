using System;

namespace Case_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            var mes = 1; // Dleclaração da variavel DInamica 

            Console.WriteLine("Digite a sua Mes de Nacimento Numericamente: ");
            mes = Convert.ToInt32 (Console.ReadLine());

            switch (mes)// metodo para seleção (Esse metodo também é conhecido como DESVIO)
            {
                case 1: // Ação para verifiar se é o que se pede na condição 
                    // Local para imprimir mensagens ou metodos para ações 

                    Console.WriteLine("Janeiro");
                    break; // Encerra a ação se caso for a ação desejada.
                case 2: // Ação para verifiar se é o que se pede na condição 
                    // Local para imprimir mensagens ou metodos para ações 

                    Console.WriteLine("Fevereiro ");
                    break; // Encerra a ação se caso for a ação desejada.


                case 3:

                    Console.WriteLine("Março");

                    break;
                case 4:

                    Console.WriteLine("Abril");

                    break;
                case 5:

                    Console.WriteLine("Maio");

                    break;
                case 6:

                    Console.WriteLine("junho");

                    break;
                case 7:

                    Console.WriteLine("Julho");

                    break;
                case 8:

                    Console.WriteLine("Agosto ");

                    break;
                case 9:

                    Console.WriteLine("Setembro");

                    break;

                case 10:

                    Console.WriteLine("Outubro");

                    break;
                case 11:

                    Console.WriteLine("Novembro");

                    break;
                case 12:

                    Console.WriteLine("Dezembro");

                    break;

                default: // Utilizado para definir um padrão, ou até mesmo uma limitação
                    // Precisamos sempre colocar o Default no final dos Switch, pois ele vai limitar o padrão.
                    Console.WriteLine("Esse Mês não existe no nosso calendario!");
                   
                    break;

            }
        }
    }
}
