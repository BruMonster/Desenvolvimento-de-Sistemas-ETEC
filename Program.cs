using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Escreva sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("\nMeu Nome é " + nome + " e tenho " + idade + " anos");
            Console.ReadKey();
        }
    }
}
