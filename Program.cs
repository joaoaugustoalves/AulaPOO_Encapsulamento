using System;
using Encapsulamento.Classe;

namespace Encapsulamento 
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();

            m.NomeTitular = "Carlos Eduardo Tsukamoto";

            m.Bandeira = "MasterCard";

            

            m.Numero = "12345678";   // Aqui foi utilizado o set

            Console.WriteLine(m.Numero); // Aqui foi utilizado oo Get

        }
    }
}
