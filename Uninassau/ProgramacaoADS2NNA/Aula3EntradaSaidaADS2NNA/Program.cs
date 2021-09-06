using System;

namespace Aula3EntradaSaidaADS2NNA
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            bool maiorIdade;

            Console.WriteLine("Qual o seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual é a sua idade? ");
            idade = int.Parse(Console.ReadLine());

            maiorIdade = idade >= 18;


            Console.WriteLine("Seu nome é: {0} e sua idade: {1} anos\n é maior de idade? {2}", nome, idade, maiorIdade);

            Console.ReadKey();
        }
    }
}
