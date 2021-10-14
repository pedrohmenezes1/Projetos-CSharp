using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    /*--01
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

    /*--02
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


    /*--03
        class Program
        {
        static void Main(string[] args)
        {
            double numero = 0;
            Console.WriteLine("Escreva um número: ");
            numero = double.Parse(Console.ReadLine());

            if( numero > 0 )
            {
                double raiz_quadrada = Math.Sqrt(numero);

                Console.WriteLine("A Raiz quadrada de " + numero + " é:\n " + raiz_quadrada);

                Console.WriteLine("\nPressione qualquer tecla para sair...");
            
                Console.ReadKey();
                
            }

            else 
            {
                double pot = Math.Pow(num, 2);
                Console.WriteLine("O Quadrado do valor digitado é:" + numero);
            }
            
        }
        }
    */
    /*  Aula 4
        class Program
        {
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Escreva um número: ");
            num = int.Parse(Console.ReadLine());

            if(num % 2 == 0 )
            {
                Console.WriteLine("Número Par");
            }
            else
            {
                Console.WriteLine("Número impar");
            }
        }
        }
    */
      //Aula 4    
    /*   class Program 
        {
            static void Main(string[] args) 
            {
                string opcaoUsuario = ObterOpcaoUsuario();

                while (opcaoUsuario.ToUpper() != "X")
			    {
				switch (opcaoUsuario)
				{
					
                    case "1":
						NumeroCrescente();
						break;
					case "2":
						NumeroDecrescente();
                        break;
                    case "C":
						Console.Clear();
						break;
                    case "":
						Console.WriteLine("Digite uma das opções abaixo: ");
						break;        
                    default:
						Console.WriteLine("Digite uma opção: ");
						break;
                }
                    opcaoUsuario = ObterOpcaoUsuario();    
                }
                    Console.WriteLine("Obrigado por utilizar nossos serviços.");           
        
            }
            private static void NumeroCrescente()
            {
                int num = 0;

                List<int> listar = new List<int>();
 
                while (num <= 2)
                   {
                    Console.WriteLine("Digite seu " + (num + 1) + "º número");
                    listar.Add(int.Parse(Console.ReadLine()));
 
                    num++;
                    }
            
                    listar.Sort();
 
                    Console.WriteLine();
                    Console.WriteLine("Os números digitados na ordem crescente são:");
 
                foreach (int termo in listar) 
                {
                    Console.WriteLine(termo);
                }
            }
            private static void NumeroDecrescente()
            {
                int num = 0;

                List<int> listar = new List<int>();
 
                while (num <= 2)
                   {
                    Console.WriteLine("Digite seu " + (num + 1) + "º número");
                    listar.Add(int.Parse(Console.ReadLine()));
 
                    num++;
                    }
            
                    listar.Sort();
                    listar.Reverse();
 
                    Console.WriteLine();
                    Console.WriteLine("Os números digitados na ordem decrescente são:");
 
                foreach (int termo in listar) 
                {
                    Console.WriteLine(termo);
                }
            }
            private static string ObterOpcaoUsuario()
            {
                Console.WriteLine();
			    Console.WriteLine("===========================================");
			    Console.WriteLine("Informe a opção desejada:");

                Console.WriteLine("1- Listar números crescentes");
			    Console.WriteLine("2- Listar números decrescentes");
			    Console.WriteLine("C- Limpar tela");
			    Console.WriteLine("X- Sair");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine().ToUpper();
			    Console.WriteLine();
			    return opcaoUsuario;



            }

        }
    */
    /*
        class Classe 
        {
                static void Main(string[] args) 
        {
                    const double pi= 3.1415;
                    double raio = 0;

                    Console.Write("Digite o Raio: ");
                    raio = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("A área do círculo (" + "Pi* " + raio + ") = "  + (pi * (raio * raio)).ToString("0.00"));
        }
        }
    */

    /*
        class Classe 
        {
                static void Main(string[] args) 
        {
            int nasc = 0;
            int ano = DateTime.Now.Year;

            Console.Write("Escreva o seu ano de nacimento: ");
            nasc = Convert.ToInt32(Console.ReadLine());

            nasc = ano - nasc;
            Console.WriteLine("Você tem: " + nasc + " Anos" );
            Console.Write("No próximo ano você terá  : " + (nasc+1) + " Anos");
        }
        }
    */

    /*--06
        class Classe 
        {
                static void Main(string[] args) 
        {
            double precoFabrica;
            double percLucro;
            double impost;
            double precoFinal;

            Console.WriteLine("Digite o preço de fábrica: " );
            precoFabrica = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o percentual do lucro: " );
            percLucro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do imposto: " );
            impost = Convert.ToInt32(Console.ReadLine());

            percLucro = percLucro * precoFabrica/100;
            impost  = precoFabrica * impost/100;
            precoFinal = precoFabrica + impost + percLucro;

            Console.WriteLine("1- O valor do imposto é: " + impost );
            Console.WriteLine("2- O do lucro é: " + percLucro );
            Console.WriteLine("3- O preço final do veículo é: " + precoFinal );
        }
        }   
    */
    /*--07
        class Classe 
        {
                static void Main(string[] args) 
        {
            float x, z, degraus;
        

            Console.WriteLine("Digite altura do degrau em centimetros: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite altura que deseja alcançar em metros: ");
            z = Convert.ToInt32(Console.ReadLine());

            degraus = ( z * 100 )  / x;

            Console.WriteLine("Você deverá subir: " + degraus + " degraus para alcançar seu objetivo.");


        }
        }
    */
    /*--08    
            class Classe 
        {
                static void Main(string[] args) 
        {
            double nHorasTrab, hrTrab, salMin, salBruto, salRec, imp;

            Console.Write("Digite o número de horas trabalhadas: ");
            nHorasTrab = double.Parse(Console.ReadLine());

            Console.Write("Digite o salário mínimo: R$ ");
            salMin = double.Parse(Console.ReadLine());

            hrTrab = salMin  / 10;
            salBruto = nHorasTrab * hrTrab;
            imp = salBruto * 3 / 100 ;
            salRec = salBruto - imp;
       
            Console.WriteLine("O salário bruto é de: R$ " + salBruto.ToString(".00"));
            Console.WriteLine("Desconto é de: R$ " + imp);
            Console.WriteLine("O salário a receber será de: R$ " + salRec);
        }
        }    
    */

    /*--09
        class Classe 
        {
            static void Main(string[] args) 
        {
            int opcao = 3;

            Console.WriteLine("Digite um número da opção: ");
            Console.WriteLine("Opção 1 = 1 ");
            Console.WriteLine("Opção 2 = 2 ");
            Console.WriteLine("Opção 3 = 3 ");
            Console.WriteLine("Opção 4 = 4 ");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                Console.WriteLine("Parabéns você ganhou um PC");
                break;
                case 2:
                Console.WriteLine("Parabéns você ganhou um Xbox");
                break;
                case 3:
                Console.WriteLine("Parabéns você ganhou um PS4");
                break;
                case 4:
                Console.WriteLine("Parabéns você ganhou um celular");
                break;
                default:
                Console.WriteLine("Digite uma opção: ");
				break; 
            }
        }
        }
    */

    public class TestaLancaMoeda

{
	public static void main( String[] args )
	{
		Random entrada = new Random();
		int lancarMoeda = new int();

		Console.Write( "Escolha uma opção: \n\n1: Lançar Moeda.\n2: Sair.\n" );
		lancarMoeda = entrada.Next();

		while( lancarMoeda == 1 ) // lança moedas até eu escolher Sair
		{

			// Pergunta novamente se quero sair ou lançar a moeda
			Console.Write( "Escolha uma opção: \n\n1: Lançar Moeda.\n2: Sair.\n" );
			lancarMoeda = entrada.Next();
		}	
	}
}
}
