using System;
using System.Text.RegularExpressions;
using ByteBank.Model;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)

        {
            //Buscador de expressões.
            string url = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            UrlValueExtractor valueExtractor = new UrlValueExtractor(url);

            string value = valueExtractor.GetValueParam("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + value);
            
            string valueOrigin = valueExtractor.GetValueParam("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valueOrigin);

            //Buscador de padrões.
            string regularText = "Para entrar em contato sobre vaga de emprego ligue (21) 97232-6937, Isantanna";
            string cellphoneDefault = "[(][0-9]{2}[)] ?[0-9]{4,5}-?[0-9]{4}";

            Match found = Regex.Match(regularText, cellphoneDefault);
            Console.WriteLine(found);


            ContaCorrente account = new ContaCorrente(001,0003);

            Console.WriteLine(account.Agencia);

            Console.ReadLine();
        }
    }
}
