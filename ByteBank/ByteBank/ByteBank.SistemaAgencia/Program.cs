using System;
using System.IO;
using System.Text;

namespace ByteBank.SistemaAgencia
{
    partial class program
    {
        static void Main(string[] args)
        {
            UsingConsole();

            Console.WriteLine("End");
            Console.ReadLine();
        }
        static void FileCreate()
        {
            var NewFileURL = "exportedAccount.csv";

            using (var fileFlow = new FileStream(NewFileURL, FileMode.Create))
            {
                var contaString = "01,78,4343.40,Alberto Martins";
                var encodingVar = Encoding.UTF8;
                var bytes = encodingVar.GetBytes(contaString);

                fileFlow.Write(bytes, 0, bytes.Length);
            }
        }

        static void FileCreateWithWriter()
        {
            var NewFileURL = "exportedAccount.csv";

            using (var fileFlow = new FileStream(NewFileURL, FileMode.Create))
            using (var writer = new StreamWriter(fileFlow))
            {
                writer.Write("01,78,4343.40,Alberto Martins");
            }
        }

        static void BinaryFileCreate()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var writer = new BinaryWriter(fs))
            {
                writer.Write(001);
                writer.Write(79);
                writer.Write(2545.20);
                writer.Write("Rafael Sant'Anna");
            }
        }

        static void ConsoleStreamUse()
        {

            using (var fileFlow = Console.OpenStandardInput())
            using (var fs = new FileStream("Teste.txt", FileMode.Create))
            {
                var buffer = new byte[1024];

                while (true)
                {
                    var bytesReaded = fileFlow.Read(buffer, 0, 1024);
                    fs.Write(buffer, 0, bytesReaded);
                    fs.Flush();

                    Console.WriteLine($"Numero: {bytesReaded}");
                }
            }
        }

        static void UsingConsole ()
        {
            var file = Console.ReadLine();
            var fileOpen = $"{file}.txt";
            var lines = File.ReadAllLines(fileOpen);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}

