using System;
using ByteBank.Model;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)

        {
            string url = "pagina?argumentos";
            int indiceInterrogacao = url.IndexOf('?');

            url.Substring(indiceInterrogacao + 1);


            Console.ReadLine();
        }
    }
}
