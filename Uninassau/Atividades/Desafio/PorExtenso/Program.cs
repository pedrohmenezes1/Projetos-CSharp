
using System;


namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor;

            Console.Write("Digite um valor entre 0 e 999: ");
            valor = Convert.ToInt32(Console.ReadLine());

            string s = Desafio.Extenso.InFull(valor);
            Console.WriteLine("O Valor digitado por extenso é: " + s);  

            Console.ReadLine();
        
        }
    }
}
