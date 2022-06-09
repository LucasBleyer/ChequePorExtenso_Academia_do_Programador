using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso.Test
{
    public class Actions
    {
        Dictionary<decimal, string> numeros = new Dictionary<decimal, string>();


        public Actions()
        {
            numeros.Add(1, "Um");
            numeros.Add(2, "Dois");
            numeros.Add(3, "Três");
            numeros.Add(4, "Quatro");
            numeros.Add(5, "Cinco");
            numeros.Add(6, "Seis");
            numeros.Add(7, "Sete");
            numeros.Add(8, "Oito");
            numeros.Add(9, "Nove");
            numeros.Add(10, "Dez");
            numeros.Add(11, "Onze");
            numeros.Add(12, "Doze");
            numeros.Add(13, "Treze");
            numeros.Add(14, "Quatorze");
            numeros.Add(15, "Quinze");
            numeros.Add(16, "Dezesseis");
            numeros.Add(17, "Dezessete");
            numeros.Add(18, "Dezoito");
            numeros.Add(19, "Dezenove");
            numeros.Add(20, "Vinte");
            numeros.Add(30, "Trinta");
            numeros.Add(40, "Quarenta");
            numeros.Add(50, "Cinquenta");
            numeros.Add(60, "Sessenta");
            numeros.Add(70, "Setenta");
            numeros.Add(80, "Oitenta");
            numeros.Add(90, "Noventa");
            numeros.Add(100, "Cento");
            numeros.Add(200, "Duzentos");
            numeros.Add(300, "Trezentos");
            numeros.Add(400, "Quatrocentos");
            numeros.Add(500, "Quinhentos");
            numeros.Add(600, "Seiscentos");
            numeros.Add(700, "Setecentos");
            numeros.Add(800, "Oitocentos");
            numeros.Add(900, "Novecentos");
            numeros.Add(1000, "Mil");
            numeros.Add(10000, "Milhão");



        }


        public string Converter(decimal numero)
        {
            decimal centavos = (numero % 1) * 100;
            numero = Math.Truncate(numero);

            string numeroPorExtenso = "";
            string numeroString = numero.ToString();
            string centavosString = centavos.ToString();
           


            if (numero != 1)
            {

                if (numero >= 1000)
                    GetUnidadeMilhar(ref numero, ref numeroPorExtenso, ref numeroString);
  

                if (numero == 100)
                {
                    numeroPorExtenso += "Cem";
                    numero -= 100;
                }

                if (numero > 100)
                    GetCentena(ref numero, ref numeroPorExtenso, ref numeroString);
                
  
                if (numero > 20)
                    GetDezenaMaiorQue20(ref numero, ref numeroPorExtenso, numeroString);
                

                if (numero != 0)
                    numeroPorExtenso += numeros[numero];


                numeroPorExtenso += " Reais";

            }
            else
            numeroPorExtenso = "Um Real";

           /////////Centavos //////////

            if (centavos != 0) {

                numeroPorExtenso += " e ";

                    if(centavos > 20)
                    {
                        GetDezenaMaiorQue20(ref centavos, ref numeroPorExtenso, centavosString);
                    }
                
                    if(numero != 0)
                    numeroPorExtenso += numeros[numero];
                
                return numeroPorExtenso + " Centavos";

                }

            else 
                return numeroPorExtenso;
        }

        private void GetDezenaMaiorQue20(ref decimal numero, ref string numeroPorExtenso, string numeroString)
        {
            int dezena = Int32.Parse(numeroString.Substring(0, 1));
            dezena = dezena * 10;

            if (dezena != 0)
            {

                numeroPorExtenso += numeros[dezena];

                numero -= dezena;
            }

            if(numero != 0)
            numeroPorExtenso += " e ";
        }

        private void GetCentena(ref decimal numero, ref string numeroPorExtenso, ref string numeroString)
        {
            //Pega centena
            int centena = Int32.Parse(numeroString.Substring(0, 1));
            centena = centena * 100;

            numeroPorExtenso += numeros[centena];

            numero -= centena;

            numeroPorExtenso += " e ";

            numeroString = numero.ToString();
        }

        private void GetUnidadeMilhar(ref decimal numero, ref string numeroPorExtenso, ref string numeroString)
        {
            //Pega Unidade de milhar
            int unidadeMilhar = Int32.Parse(numeroString.Substring(0, 1));
            numeroPorExtenso += numeros[unidadeMilhar] + " Mil";


            numero -= unidadeMilhar * 1000;

            if (numeros.ContainsKey(numero))
                numeroPorExtenso += " e ";
            else
                numeroPorExtenso += " ";

            numeroString = numero.ToString();
        }
    }
}
