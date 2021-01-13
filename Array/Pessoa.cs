using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public class Pessoa
    {
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        public void PessoaFalando()
        {
            Console.WriteLine("Olá Mundo!");
        }
        

    }
}
