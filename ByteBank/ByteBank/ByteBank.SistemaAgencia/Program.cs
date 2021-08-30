using ByteBank.Model;
using System;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)

        {
            AccountList Contas = new AccountList();

            Contas.Add(new ContaCorrente(001, 1001));
            Contas.Add(new ContaCorrente(001, 1002));
            Contas.Add(new ContaCorrente(001, 1003));
            Contas.Add(new ContaCorrente(001, 1004));
            Contas.Add(new ContaCorrente(001, 1005));
            Contas.Add(new ContaCorrente(001, 1006));
            Contas.Add(new ContaCorrente(001, 1007));


            //for (int i = 0; i < Contas.Length; i++)
            //{
            //    Console.WriteLine($"Conta {i} {Contas[i].Numero}");
            //}

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
            UrlValueExtractor valueExtractor = new UrlValueExtractor(url);

            string value = valueExtractor.GetValueParam("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + value);

            string valueOrigin = valueExtractor.GetValueParam("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valueOrigin);
        }
    }
}
