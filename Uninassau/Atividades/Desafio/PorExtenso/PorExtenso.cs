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
                return "Zero";
            else if (valor <= 0 | valor >= 1000)
                return "Um valor não suportado pelo sistema, digite entre 0 e 999";


            string texto = valor.ToString();
            List<string> primeiraLista = new List<string>();
            int section1 = 0;
            bool foiAdicionado = false;

            for (int i = texto.Length - 1; i >= 0; i = i - 3)
            {
                string d1 = texto[i].ToString();
                string d2 = (i - 1 >= 0 ? texto[i - 1].ToString() : "0");
                string d3 = (i - 2 >= 0 ? texto[i - 2].ToString() : "0");
                bool isEmpty = (d1 == "0" && d2 == "0" && d3 == "0");

                if ((d3 == "0")
                && (d2 == "0")
                && d1 == "1")
                {
                    if (section1 == 1)
                    {
                        primeiraLista.Add("Novecentos");
                        section1++;
                        break;
                    }
                }
                else if (!isEmpty)
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
            List<string> segundaLista = new List<string>();

            foreach (string val in primeiraLista)
                if (val != string.Empty)
                    segundaLista.Add(val);

            for (int i = segundaLista.Count - 1; i >= 0; i--)
            {
                string val = segundaLista[i];
                result.Append(val);

                if (i - 1 >= 0)
                {
                    string proxValor = segundaLista[i - 1];

                    /*Verificando se i != 0 para 
                    não colocar espaço no fim da string*/

                    if (proxValor != "," && i != 0)
                        result.Append(' ');
                }
            }

            return result.ToString();
        }

        private class Numero
        {
            private int digito;

            public int Digit
            {
                get { return digito; }
            }

            private string texto;

            public string Texto
            {
                get { return texto; }
            }

            public Numero(int digito, string texto)
            {
                if (digito < 0 || digito > 9)
                    throw new ArgumentException("digito é inválido " + digito);

                if (texto == null)
                    throw new ArgumentException("o texto é nulo");

                this.digito = digito;
                this.texto = texto;
            }

            public override string ToString()
            {
                return texto + "-" + digito;
            }
        }


        private static readonly Numero[] decimal1 = new Numero[] { new Numero(1,"Um"  ),
                                                                   new Numero(2,"Dois"),
                                                                   new Numero(3,"Três"),
                                                                   new Numero(4,"Quatro"),
                                                                   new Numero(5,"Cinco"),
                                                                   new Numero(6,"Seis"),
                                                                   new Numero(7,"Sete"),
                                                                   new Numero(8,"Oito"),
                                                                   new Numero(9,"Nove")
                                                                 };

        private static readonly Numero[] depoisDez = new Numero[] { new Numero(1,"Onze"),
                                                                    new Numero(2,"Doze"),
                                                                    new Numero(3,"Treze"),
                                                                    new Numero(4,"Quatorze"),
                                                                    new Numero(5,"Quinze"),
                                                                    new Numero(6,"Dezeseis"),
                                                                    new Numero(7,"Dezesete"),
                                                                    new Numero(8,"Dezoito"),
                                                                    new Numero(9,"Dezenove")
                                                                 };

        private static readonly Numero[] decimal2 = new Numero[] { new Numero(1,"Dez"),
                                                                   new Numero(2,"Vinte"),
                                                                   new Numero(3,"Trinta"),
                                                                   new Numero(4,"Quarenta"),
                                                                   new Numero(5,"Cinquenta"),
                                                                   new Numero(6,"Sessenta"),
                                                                   new Numero(7,"Setenta"),
                                                                   new Numero(8,"Oitenta"),
                                                                   new Numero(9,"Noventa")
                                                                 };

        private static readonly Numero[] decimal3 = new Numero[] { new Numero(1,"Cento"),
                                                                   new Numero(2,"Duzentos"),
                                                                   new Numero(3,"Trezentos"),
                                                                   new Numero(4,"Quatrocentos"),
                                                                   new Numero(5,"Quinhentos"),
                                                                   new Numero(6,"Seiscentos"),
                                                                   new Numero(7,"Setecentos"),
                                                                   new Numero(8,"Oitocentos"),
                                                                   new Numero(9,"Novecentos")
                                                                 };

        private const int DECIMAL1 = 0;

        private const int DPS_DEZ = 1;

        private const int DECIMAL2 = 2;

        private const int DECIMAL3 = 3;

        private static readonly Numero[][] decimals = new Numero[][]{  
                                                                    decimal1,
                                                                    depoisDez,
                                                                    decimal2,
                                                                    decimal3 
                                                                    };

        private static Numero EncontrarNumero(int dec, int digito)
        {
            if (dec < 0 || dec > 3)
                throw new ArgumentException("Digite um número entre 0 e 999: " + dec);

            if (digito < 1 || digito > 9)
                throw new ArgumentException("Digite um número entre 0 e 999: " + digito);

            Numero[] array = decimals[dec];

            foreach (Numero n in array)
            {
                if (digito == n.Digit)
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

            public static readonly Section empty = new Section(0, "");

            public static readonly Section novecentos = new Section(1, "Novecentos");

            private Section(int sectionValue, string texto)
            {
                if (sectionValue < 0)
                    throw new ArgumentException("O valor da seção é inválido: " + sectionValue);

                if (sectionValue > 1)
                    throw new ArgumentException("O valor da seção tem um valor não suportado : " + sectionValue);

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
            Numero numero1 = (d1 != "0" ? EncontrarNumero(DECIMAL1, Convert.ToInt32(d1)) : null);
            Numero depoisDez = (d1 != "0" ? EncontrarNumero(DPS_DEZ, Convert.ToInt32(d1)) : null);
            Numero numero2 = (d2 != "0" ? EncontrarNumero(DECIMAL2, Convert.ToInt32(d2)) : null);
            Numero numero3 = (d3 != "0" ? EncontrarNumero(DECIMAL3, Convert.ToInt32(d3)) : null);

            if (d2 == "1")
            {
                if (numero3 == null)
                    return (depoisDez != null ? depoisDez.Texto : numero2.Texto);
                else
                {
                    return numero3.Texto
                        + " e " + (depoisDez != null ? depoisDez.Texto : numero2.Texto);
                }
            }
            else
            {
                if (d1 == "0"
                 && d2 == "0"
                 && d3 == "1")
                {
                    return "Cem";
                }
                else
                {
                    if (d3 != "0")
                    {
                        if (numero2 != null && numero1 != null)
                        {
                            return numero3.Texto
                         + " e " + numero2.Texto
                         + " e " + numero1.Texto;
                        }
                        else if (numero2 != null)
                        {
                            return numero3.Texto
                         + " e " + numero2.Texto;

                        }
                        else if (numero1 != null)
                        {
                            return numero3.Texto
                         + " e " + numero1.Texto;
                        }
                        else
                            return numero3.Texto;
                    }
                    else if (d2 != "0")
                    {
                        if (numero1 != null)
                        {
                            return numero2.Texto
                         + " e " + numero1.Texto;
                        }
                        else
                            return numero2.Texto;
                    }
                    else if (numero1 != null)
                        return numero1.Texto;
                }
            }

            return string.Empty;
        }
    }
}
