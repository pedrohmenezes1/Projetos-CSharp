/*
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Aulas_CSharp
{
    class Program//Escopo Global//
    {
               
            string meutexto = "HelloWorld!";
            int segundaGuerraMundial = 1942;
            float velocidadeF1 = 294.48f;
            bool segundaGuerraMundial2 = true;
            const float PI = 3.14f;

        --Variáveis--
            Int - números negativos e inteiros
            Float - números decimais ==> Double = número reais
            Bool - True ou False
            String - "Texto"
            Char - 'Caracter'
            Var = Váriavel não alterável
            Dynamic = Váriavel alterável
        --Variáveis--

        --Constantes--
            const int
            const float
            const bool
            const string
            const char

            Console.WriteLine (meutexto);
            Console.WriteLine (segundaGuerraMundial);
            Console.WriteLine (velocidadeF1);
            Console.WriteLine (segundaGuerraMundial2);

            velocidadeF1 = 340.20f;
            Console.WriteLine (velocidadeF1);
            
            string nome = "";
            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine ();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);

            Console.ReadLine ();
        --Constantes--

        --Calculos
            int numerosoma = 20+20;
            int numeromult = 20*20;
            float numerodiv = 5/2f;
            int teste = (2 + 2) * 10; //Prioridade de calculo dentro dos parênteses//

            Console.WriteLine(numerosoma);
            Console.WriteLine(numeromult);
            Console.WriteLine(numerodiv);
            Console.WriteLine(teste);
        --Calculos
        
        --Condição
            10>2 = True
            2>= 250 = False
            < menor que, > maior que, >= maior que igual, <= menor que igual, == igual a, != diferente de.
            If = SE, Else= Se não, Else If=
            &&(E ou AND) e ││(OU/OR) 
            --COND1 && COND2 =>TRUE OR FALSE
            TRUE && TRUE = TRUE
            TRUE && FALSE = FALSE
            FALSE && FALSE = FALSE
            FALSE && TRUE = FALSE--
            --COND1  ││ COND2 => TRUE OR FALSE
            TRUE ││ TRUE = TRUE
            TRUE ││ FALSE = TRUE
            FALSE ││ TRUE = TRUE
            FALSE ││ FALSE = FALSE--

            int a = 10;
            int b = 20;
            int c = 10;

            if (a > b && a < c)    //SE
            {
                Console.WriteLine("É verdade!");
            }
            else if (a >= b)
            {
                Console.WriteLine("Executou Else if"); //Caso o anterior for false
            }
            else         //SE NÃO
            {
                Console.WriteLine("É mentira!");
        --Condição
    
        --Programinha idade

            Console.WriteLine("Digite Sua Idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma Criança!");
            }
            else if (idade >=12 && idade <=18)
            {
                Console.WriteLine("Você é um Adolescente!");
            }
            else if (idade >=19 && idade <=60)
            {
                Console.WriteLine("Você é um Adulto!");
            }
            else
            {
                Console.WriteLine("Você é um Idoso!");                     
            }
        --Programinha idade
    


        --Funções 
            Produto("Produto: ");
            GerarPreco(5);
            GerarPreco(10);
            GerarPreco(15);
            GerarPreco(-5);
            GerarPreco(-50);
            GerarPreco(25);
        static void Produto(string nome)
        {
            Console.Write(nome );
            Console.WriteLine("Abacaxi");
        }
        static void GerarPreco(int preco)
        {
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor Final:" + valorFinal);
        }
        --Funções

    
        --Retorno
            void = sem retorno

            int soma1 = Somar(1, 2, 3);
            int soma2 = Somar(10, 20, 30);
            int soma3 = Somar(50, 100, 150);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);

        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
        --Retorno    
        }
        
        --Array
            string produto1 = "Sea of Thieves";
            string produto2 = "League of Legends";
            string produto3 = "Fifa";
            string produto4 = "NFS";
            string produto5 = "New World";

            string[] produtos = new string[5] {
                "Sea of Thieves", 
                "League of Legends", 
                "Fifa", 
                "Need For Speed", 
                "New World"
                };

            int[] valores = {10, 20 , 30, 40, 50};
            Console.WriteLine(produtos[1]);

        --Array

        --Conversão implícita

        static void Main(string[] args);

            int x = 10;
            double y;
            y = x;

            Console.WriteLine("Valor de x: {0}", x);   
            Console.WriteLine("Valor de y: {0}", y);  

            Console.ReadKey();

        --Conversão implícita

        --Conversão explícita

        static void Main(string[] args);

            double x = 10.5;
            int y;
            y = (int)x;

            Console.WriteLine("Valor de x: {0}", x);   
            Console.WriteLine("Valor de y: {0}", y);  

            Console.ReadKey();  

        --Conversão explícita

        --Conversão com classes auxiliares // Convert / Parse //

        static void Main(string[] args);

            double x = 10.5;
            int y;
            y = Convert.ToInt32(x);

            Console.WriteLine("Valor de x: {0}", x);   
            Console.WriteLine("Valor de y: {0}", y);  

            Console.ReadKey();

        --    

        static void Main(string[] args);

            int x;

            Console.WriteLine("Digite um número: );   
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor de X: {0}", x ); 

            Console.ReadKey();
        --Conversão com classes auxiliares
    
        --Switch //Trabalha com igualdade ==
            string cor = "Azul";

            switch(cor)
            {
            case "Vermelho":
            Console.WriteLine("Sua cor favorita é vermelho!");
            break;
            case "Amarelo":
            Console.WriteLine("Sua cor favorita é amarelo!");
            break;
            case "Azul":
            Console.WriteLine("Sua cor favorita é azul!");
            break;    
            default://Caso não esteja no case
            Console.WriteLine("Sua cor favorita eu não sei!")
            break;      
            }
        --Switch //Trabalha com igualdade ==
    
        --Enum
        enum Cor
        {
            Azul, Verde, Amarelo, Vermelho
        }
        static void Main(string[] args)
        {
            Cor corFavorita = Cor.Vermelho;
            Cor corFavoritaPedro = Cor.Azul;

            Console.WriteLine((int)corFavorita); // Com Conversão
            Console.WriteLine(corFavoritaPedro);
            Console.WriteLine((Cor)2); //Com conversão de enum
        }
        --Enum
        
        --Enum + Switch

        enum Cor { Azul, Verde, Amarelo, Vermelho }
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }

        static void Main(string[] args) 
        {
            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            Console.WriteLine(opcaoSelecionada);

            switch(opcaoSelecionada)
            {
                case Opcao.Criar:
                Console.WriteLine("Você quer criar algo!");
                break;
                case Opcao.Deletar:
                Console.WriteLine("Você quer deletar algo!");
                break;
                case Opcao.Editar:
                Console.WriteLine("Você quer editar algo!");
                break;
                case Opcao.Listar:
                Console.WriteLine("Você quer listar algo!");
                break;
                case Opcao.Atualizar:
                Console.WriteLine("Você quer atualizar algo!");
                break;
                default:
                Console.WriteLine("Opção não encontrada!");
                break;    
            }
        }    
        --Enum + Switch
        
        --While //Enquanto for verdade faça:
        static void Main(string[] args)
        {
            int contador = 0;
            while(contador < 10)
            {
                Console.WriteLine(contador);
                Console.WriteLine("Rodando While");
                //contador = contador + 1;
                //contador += 1;
                contador ++;

            }
                Console.WriteLine("Fim do código!");
        }
        --While
    
        --Do While //Por mais que seja false executa ao menos uma vez
        static void Main(string[] args)
        {
            int contador2 = 0;
            do
            {
                Console.WriteLine(contador2);
                contador2 ++;
            }
            while (contador2 < 20);
            {
                 Console.WriteLine(contador2);
            }
        }    
        --Do While //Por mais que seja false executa ao menos uma vez

        //--Foreach // Estrutura de repetição
        static void Main(string[] args)
        {
            string[] palavras = { "Pedro", "Victor", "Jose", "Guilherme", "Maria", "Paula" };

            foreach (string palavra in palavras)
            {
                Console.WriteLine(palavra);
            }
        }
        //--Foreach
        
        //--For // Estrutura de repetição //Length
        static void Main(string[] args)
        {
            string[] palavras = { "Pedro", "Victor", "Jose", "Guilherme", "Maria", "Paula", "Joao" };

            for(int contador = 0; contador < palavras.Length ; contador++)
            {
                Console.WriteLine(contador);
                Console.WriteLine(palavras[contador]);

            }
            Console.WriteLine("=========================================");
            for(int contador2 = palavras.Length-1; contador2 >= 0; contador2--)
            {
                Console.WriteLine(contador2);
                Console.WriteLine(palavras[contador2]);
            }
        }
        //--For // Estrutura de repetição //Length
    
        //--Escopo //class Program//
        static void Main(string[] args)
        {
            
        }
        static void escopos()
        {
        }
        //--Escopo //class Program//
    
    
    }
}
    */