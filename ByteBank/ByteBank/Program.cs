using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GetBonificacao gerenciador = new();            

            Funcionario carlos = new();

            carlos.nome = "Carlos Lacerda";
            carlos.cpf = "001.001.001-01";
            carlos.salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new();

            roberta.nome = "Roberta Cabrini";
            roberta.cpf = "002.002.002-02";
            roberta.salario = 5000;

            gerenciador.Registrar(roberta);
            
            Console.WriteLine(carlos.nome);
            Console.WriteLine(carlos.salario);
            Console.WriteLine("Bonificação do funcionário " + carlos.GetBonificacao());

            Console.WriteLine();
            
            Console.WriteLine(roberta.nome);
            Console.WriteLine(roberta.salario);    
            Console.WriteLine("Bonificação do funcionário " + roberta.GetBonificacao());

            Console.WriteLine();

            Console.WriteLine("Total de bonificações " + gerenciador.GetTotalBonificacao());




            Console.ReadLine();         
        }
    }
}
