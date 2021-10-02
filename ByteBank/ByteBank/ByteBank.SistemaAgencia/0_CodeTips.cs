using ByteBank.Model;
using ByteBank.SistemaAgencia.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    partial class program
    {
        static void WriteBuffer(byte[] Buffer, int bytesReaded)
        {
            //var utf8 = new UTF8Encoding();
            var utf8 = Encoding.Default;

            var tex = utf8.GetString(Buffer, 0, bytesReaded);

            Console.Write(tex);

            //  foreach (var myByte in Buffer)
            //  {
            //    Console.WriteLine(myByte);
            //     Console.WriteLine(" ");
            //}
        }

        static void StreamMannager()
        {
            var urlFile = "contas.txt";
            using (var fileFlow = new FileStream(urlFile, FileMode.Open))
            {

                var buffer = new byte[1024];
                var readedByte = -1;

                while (readedByte != 0)
                {
                    readedByte = fileFlow.Read(buffer, 0, 1024);
                    WriteBuffer(buffer, readedByte);
                }
            }
        }
        static void ExtensionMetod()
        {
            List<int> age = new();
            var parceiro = new ParceiroComercial();


            age.Add(11);
            age.Add(25);
            age.AddMore(17, 30, 28, 11);
            age.AddMore(22, 17, 25);
            age.Sort();
            //age.Reverse();
            age.AddMore(58, 29, 26);

            for (int i = 0; i < age.Count; i++)
            {
                Console.WriteLine(age[i]);
            }
        }
        static void DefaultFinder()
        {
            //Buscador de padrões.
            string regularText = "Para entrar em contato sobre vaga de emprego ligue (21) 97232-6937, Isantanna";
            string cellphoneDefault = "[(][0-9]{2}[)] ?[0-9]{4,5}-?[0-9]{4}";

            Match found = Regex.Match(regularText, cellphoneDefault);
            Console.WriteLine(found);
        }

        static void ExpressionFinder()
        {
            //Buscador de expressões.
            string url = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            var valueExtractor = new UrlValueExtractor(url);

            string value = valueExtractor.GetValueParam("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + value);

            string valueOrigin = valueExtractor.GetValueParam("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valueOrigin);
        }

        static void CSVReader ()
        {
            var urlFile = "contas.txt";
            using (var fileFlow = new FileStream(urlFile, FileMode.Open))
            using (var leitor = new StreamReader(fileFlow))
            {

                while (!leitor.EndOfStream)
                {
                    var line = leitor.ReadLine();
                    var contaCorrente = GetString(line);
                    var msg = $"{contaCorrente.titular.nome}: Account Number {contaCorrente.Numero} Agency {contaCorrente.Agencia} Saldo: {contaCorrente.Saldo}.";
                    Console.WriteLine(msg);
                    Console.ReadLine();
                }
            }
        }

        static ContaCorrente GetString(string line)
        {
            string[] campos = line.Split(',');

            var agency = campos[0];
            var num = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var agencyNum = int.Parse(agency);
            var numAccount = int.Parse(num);
            var saldoAtual = double.Parse(saldo);

            var titular = new Cliente();
            titular.nome = nomeTitular;

            var resume = new ContaCorrente(agencyNum, numAccount);
            resume.Depositar(saldoAtual);
            resume.titular = titular;

            return resume;
        }

    }
}
