using System;

namespace Aula4_ADS_2NNA
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            // exemplo 1 -------------------

            string clima = "ensolarado" ;

            if(clima == "chuvoso")
            {
                Console.WriteLine("Não saia, esta chovendo.");
            }

            else if (clima == "ensolarado")
            {
                Console.WriteLine("Va brincar la fora.");
            }

            else if (clima == "nevando")
            {
                Console.WriteLine("Va brincar na neve.");
            }

            else 
            {
                Console.WriteLine("não foi possivel determinar o clima.");
            }


            Console.ReadKey();
            */
            //------------------------------------------------------

            /*//exemplo 2 -------------------------------------------

            int numero;
            Console.WriteLine("Digite um número: ");
            numero = Int32.Parse(Console.ReadLine());

            if(numero == 1)
            {
                Console.WriteLine("O número digitado foi o número 1 ");
            }
            else 
            {
                Console.WriteLine("O número digitado não foi o número 1 ");
            }

            Console.ReadKey();
            //---------------------------------------------------------*/

            /*// exemplo 3  ---------------------------------------------

            double n1, n2, m ;
            string msg;

            Console.Write("Digite a 1a. nota: ");
            n1 = Double.Parse(Console.ReadLine());

            Console.Write("Digite a 2a. nota: ");
            n2 = Double.Parse(Console.ReadLine());

            m = (n1 + n2) / 2;
            
            if (m >= 7)
            {
                msg = "passou";
            }
            
            else
            {
                msg = "reprovou";
            }

            msg = (m >= 7) ? "passou" : "reprovou";

            Console.WriteLine("Você {0} com média {1} !", msg, m);

           // Console.WriteLine("Você "+ msg + "com média "+ m);
           //-------------------------------------------*/

            /*
            // exemplo 4  - ----------------------------------------

            string clima = "nublado";

            switch (clima)
            {
                case "chuvoso":
                    Console.WriteLine("Não sai, está chovendo");
                    break;

                case "ensolarado":
                    Console.WriteLine("Va brincar la fora");
                    break;

                case "nublado":
                    Console.WriteLine("está nublado");
                    break;

                default:
                    Console.WriteLine("Clima não determinado");
                    break;
            }
           //------------------------------------------------------- */

            //Exemplo 5 ---------------------------------------

            int mes = DateTime.Today.Month;

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;

                case 2:
                    Console.WriteLine("Fevereiro");
                    break;

                case 9:
                    Console.WriteLine("Setembro");
                    break;

                default:
                    Console.WriteLine("Outro mês");
                    break;
            }

            Console.ReadKey();
        }
    }
}
