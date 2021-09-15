using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    /*01
    class Program
    {        
            static void Main(string[] args)
        {
            float fahrenheit = 0;
            float celsius = 0;
            
            Console.WriteLine("Escreva a temperatura em Celsius: ");
            celsius = float.Parse(Console.ReadLine());

            //Calculo
            fahrenheit = (float) 9 / 5 * (celsius + 32);

            Console.WriteLine("Temperatura convertida em Fahrenheit é: " + fahrenheit + "°F");

            Console.ReadLine();
        }    
    }   
    */

    /*02
        class Program
        {
            static void Main(string[] args)
        {
            double salario = 0;
            double valorHr = 0;
            int nAulas = 0;
            double inss1 = 0.75 , inss2 = 0.90 , inss3 = 0.120 , inss4 = 0.140;

            Console.WriteLine("Digite o valor da hora aula: ");
            valorHr = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de aulas dadas: ");
            nAulas = int.Parse(Console.ReadLine());

            salario = valorHr * nAulas;

            if (salario <= 1100)
            {
                salario = inss1 * salario ;
            }
            else if (salario >= 1100.01 && salario <= 2203.48)
            {
                salario = inss2 * salario;
            }
            else if (salario >= 2203.49 && salario <= 3305.22)
            {
                salario = inss3 * salario;
            }
            else
            {
                salario = inss4 * salario;
            }
            Console.WriteLine("Seu salário líquido com desconto do INSS é: " + salario + " Reais");

        }
    
        }
    */

    //03


}
