
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

            while (valor >=0 | valor <= 1000)
            {
            string num = Desafio.Extenso.InFull(valor);
            Console.WriteLine("O Valor digitado por extenso é: " + num);
            break;
            }
            Console.ReadLine();
        
        }
    }
}
