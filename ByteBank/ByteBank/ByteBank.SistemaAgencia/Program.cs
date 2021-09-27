using ByteBank.Model;
using ByteBank.SistemaAgencia.Extensions;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)

        {
            List<int> age = new ();
            var parceiro = new ParceiroComercial();
            

            age.Add(11);
            age.Add(25);
            age.AddMore(17, 30, 28, 11);
            age.AddMore(22, 17, 25);
            age.Sort();
            //age.Reverse();
            age.AddMore(58,29,26);

            for(int i = 0; i < age.Count; i++)
            {
                Console.WriteLine(age[i]);
            }

            Console.ReadLine();
        }

        public void DefaultFinder()
        {
            //Buscador de padrões.
            string regularText = "Para entrar em contato sobre vaga de emprego ligue (21) 97232-6937, Isantanna";
            string cellphoneDefault = "[(][0-9]{2}[)] ?[0-9]{4,5}-?[0-9]{4}";

            Match found = Regex.Match(regularText, cellphoneDefault);
            Console.WriteLine(found);
        }

        public void ExpressionFinder()
        {
            //Buscador de expressões.
            string url = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            var valueExtractor = new UrlValueExtractor(url);

            string value = valueExtractor.GetValueParam("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + value);

            string valueOrigin = valueExtractor.GetValueParam("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valueOrigin);
        }
    }
}
