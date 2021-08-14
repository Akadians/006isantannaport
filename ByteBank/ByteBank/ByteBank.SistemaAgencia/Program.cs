using System;
using ByteBank.Model;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)

        {
            DateTime dataFimPagamento = new DateTime(2021, 9, 01);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            ContaCorrente Carlos = new(123, 12);
            Console.WriteLine(mensagem);

            Console.ReadLine();
        }

        static string GetTime (TimeSpan time)
        {
            
            
            return time.Days + " dias";
        }
    }
}
