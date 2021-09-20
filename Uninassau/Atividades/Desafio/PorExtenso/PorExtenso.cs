using System;
using System.Collections.Generic;
using System.Text;


namespace Desafio
{
    public class Extenso
    {
        public static string InFull(int valor)
        {
            if (valor == 0)
                return "zero";
            else if (valor <= 0 | valor >= 1000)
            return "Um valor não suportado pelo sistema, digite entre 0 e 999";
                

            string texto = valor.ToString();
            List<string> primeiraLista = new List<string>();
            int section1 = 0;
            bool foiAdicionado = false;

            for (int i = texto.Length - 1; i >= 0; i = i - 3)
            {
                string d1 = texto[i].ToString();
                string d2 = ( i - 1 >= 0 ? texto[i - 1].ToString() : "0");
                string d3 = ( i - 2 >= 0 ? texto[i - 2].ToString() : "0");
                bool isEmpty = (d1 == "0" && d2 == "0" && d3 == "0");

                if ((d3 == "0" ) 
                && ( d2 == "0" ) 
                &&   d1 == "1" )
                {
                    if (section1 == 1)
                    {
                        primeiraLista.Add("novecentos");
                        section1++;
                        break;
                    }
                }
                else if ( ! isEmpty )
                {
                    Section section = sections[section1];
                    primeiraLista.Add(section.Texto);
                }

                //armazena três dígitos
                string ext = Ext(d3, d2, d1);
                primeiraLista.Add(ext);
                bool lastTime = i == 0 || i == 1 || i == 2;

                if (!lastTime && !isEmpty && !foiAdicionado)
                {
                    primeiraLista.Add("e");
                    foiAdicionado = true;
                }
                else if (!lastTime && !isEmpty)
                    primeiraLista.Add(",");
                
                section1++;
            }

            StringBuilder result = new StringBuilder();
            List<string> secondList = new List<string>();

            foreach (string val in primeiraLista)
                if (val != string.Empty)
                    secondList.Add(val);

            for (int i = secondList.Count - 1; i >= 0; i--)
            {
                string val = secondList[i];
                result.Append(val);

                if (i - 1 >= 0)
                {
                    string nextVal = secondList[i - 1];

                    /*Verificando se i != 0 para 
                    não colocar espaço no fim da string*/

                    if ( nextVal != "," && i != 0 )
                        result.Append(' ');
                }
            }

            return result.ToString();
        }

        private class Number
        {
            private int digit;

            public int Digit
            {
                get { return digit; }
            }

            private string texto;

            public string Texto
            {
                get { return texto; }
            }

            public Number(int digit, string texto)
            {
                if (digit < 0 || digit > 9)
                    throw new ArgumentException("digit is invalid " + digit);

                if (texto == null)
                    throw new ArgumentException("text is null");

                this.digit = digit;
                this.texto = texto;
            }

            public override string ToString()
            {
                return texto + "-" + digit;
            }
        }


        private static readonly Number[] decimal1 = new Number[] { new Number(1,"um"  ),
                                                                   new Number(2,"dois"),
                                                                   new Number(3,"três"),
                                                                   new Number(4,"quatro"),
                                                                   new Number(5,"cinco"),
                                                                   new Number(6,"seis"),
                                                                   new Number(7,"sete"),
                                                                   new Number(8,"oito"),
                                                                   new Number(9,"nove")
                                                                 };

        private static readonly Number[] afterTen = new Number[] { new Number(1,"onze"), 
                                                                   new Number(2,"doze"),
                                                                   new Number(3,"treze"),
                                                                   new Number(4,"quatorze"),
                                                                   new Number(5,"quinze"),
                                                                   new Number(6,"dezeseis"),
                                                                   new Number(7,"dezesete"),
                                                                   new Number(8,"dezoito"),
                                                                   new Number(9,"dezenove")
                                                                 };

        private static readonly Number[] decimal2 = new Number[] { new Number(1,"dez"),
                                                                   new Number(2,"vinte"), 
                                                                   new Number(3,"trinta"), 
                                                                   new Number(4,"quarenta"), 
                                                                   new Number(5,"cinquenta"), 
                                                                   new Number(6,"sessenta"), 
                                                                   new Number(7,"setenta"), 
                                                                   new Number(8,"oitenta"), 
                                                                   new Number(9,"noventa")
                                                                 };

        private static readonly Number[] decimal3 = new Number[] { new Number(1,"cento"),
                                                                   new Number(2,"duzentos"),
                                                                   new Number(3,"trezentos"),
                                                                   new Number(4,"quatrocentos"),
                                                                   new Number(5,"quinhentos"),
                                                                   new Number(6,"seiscentos"),
                                                                   new Number(7,"setecentos"),
                                                                   new Number(8,"oitocentos"),
                                                                   new Number(9,"novecentos")
                                                                 };

        private const int DECIMAL1 = 0;

        private const int AFTER_TEN = 1;

        private const int DECIMAL2 = 2;
        
        private const int DECIMAL3 = 3;

        private static readonly Number[][] decimals = new Number[][] { decimal1, 
                                                                       afterTen, 
                                                                       decimal2, 
                                                                       decimal3 };
    
        private static Number FindNumber(int dec, int digit)
        {
            if (dec < 0 || dec > 3)
                throw new ArgumentException("digite um número entre 0 e 999: " + dec );

            if (digit < 1 || digit > 9)
                throw new ArgumentException("digite um número entre 0 e 999: " + digit);

            Number[] array = decimals[dec];

            foreach (Number n in array)
            {
                if (digit == n.Digit)
                    return n;
            }

            throw new Exception("Erro interno");
        }

        private class Section
        {
            private int sectionValue;

            public int SectionValue
            {
                get { return sectionValue; }
            }

            private string texto;

            public string Texto
            {
                get { return texto; }
            }

            public static readonly Section empty       = new Section(0, "");

            public static readonly Section novecentos    = new Section(1, "novecentos");

            private Section(int sectionValue, string texto)
            {
                if (sectionValue < 0)
                    throw new ArgumentException("sectionValue is invalid:" + sectionValue);

                if (sectionValue > 6)
                    throw new ArgumentException("sectionValue has an unsupported valor :" + sectionValue);

                this.sectionValue = sectionValue;
                this.texto = texto;
            }

            public override string ToString()
            {
                return texto + "-" + sectionValue;
            }
        }

        private static readonly Section[] sections = new Section[] {Section.empty, 
                                                                    Section.novecentos                                                                                                   
                                                                   };

        private static string Ext(string d3, string d2, string d1)
        {
            Number number1  = ( d1 != "0" ? FindNumber(DECIMAL1,  Convert.ToInt32(d1)) : null);
            Number afterTen = ( d1 != "0" ? FindNumber(AFTER_TEN, Convert.ToInt32(d1)) : null);
            Number number2  = ( d2 != "0" ? FindNumber(DECIMAL2,  Convert.ToInt32(d2)) : null);
            Number number3  = ( d3 != "0" ? FindNumber(DECIMAL3,  Convert.ToInt32(d3)) : null);

            if (d2 == "1")
            {
                if (number3 == null)
                    return (afterTen != null ? afterTen.Texto : number2.Texto);
                else
                {
                    return number3.Texto
                        + " e " + ( afterTen != null ? afterTen.Texto :  number2.Texto);
                }
            }
            else
            {
                if (d1 == "0"
                 && d2 == "0"
                 && d3 == "1")
                {
                    return "cem";
                }
                else
                {
                    if (d3 != "0")
                    {
                        if (number2 != null && number1 != null)
                        {
                            return number3.Texto
                         + " e " + number2.Texto
                         + " e " + number1.Texto;
                        }
                        else if (number2 != null)
                        {
                            return number3.Texto
                         + " e " + number2.Texto;

                        }
                        else if (number1 != null)
                        {
                            return number3.Texto
                         + " e " + number1.Texto;
                        }
                        else
                            return number3.Texto;
                    }
                    else if (d2 != "0")
                    {
                        if (number1 != null)
                        {
                            return number2.Texto
                         + " e " + number1.Texto;
                        }
                        else
                            return number2.Texto;
                    }
                    else if ( number1 != null )
                        return number1.Texto;
                }
            }

            return string.Empty;
        }
    }
}
