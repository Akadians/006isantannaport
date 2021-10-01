using System;
using System.IO;

namespace ByteBank.SistemaAgencia
{
    partial class program
    {
        static void Main(string[] args)

        {
            var urlFile = "contas.txt";
            using (var fileFlow = new FileStream(urlFile, FileMode.Open))
            using (var leitor = new StreamReader(fileFlow))
            {

                while (!leitor.EndOfStream)
                {
                    var line = leitor.ReadLine();
                    Console.WriteLine(line);
                    Console.ReadLine();
                }
            }


            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
