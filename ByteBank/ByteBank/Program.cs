using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.IO;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch(Exception)
            {
                Console.WriteLine("Exception Registrado");
            }
            finally
            {
                Console.WriteLine("Execução finalizada. Tecle ENTER para sair");
                Console.ReadLine();
            }
        }
        public static void CarregarContas()
        {
            using (LeitorDeArquivos leitor = new("Teste.txt"))
            {
                leitor.LerProximaLinha();
            }



            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new("contas.txt");

            //    leitor.LerProximaLinha();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção IOException Capturada e tratada");
            //}
            //finally
            //{
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }

        public static void TestandoExceptionsEInnerExceptions()
        {
            GetBonificacao gerenciador = new();

            Designer carlos = new("001.001.001-01");

            carlos.nome = "Carlos Lacerda";

            Console.WriteLine("O salário original é " + carlos.salario);

            carlos.AumentarSalario();

            Console.WriteLine("Novo Salário é " + carlos.salario);

            gerenciador.Registrar(carlos);

            Diretor roberta = new("002.002.002-02");

            roberta.nome = "Roberta Cabrini";

            Console.WriteLine("O salário original é " + roberta.salario);

            gerenciador.Registrar(roberta);

            roberta.AumentarSalario();

            Console.WriteLine("Novo Salário é " + roberta.salario);

            Console.WriteLine();

            Console.WriteLine(carlos.nome);
            Console.WriteLine(carlos.salario);
            Console.WriteLine("Bonificação do funcionário " + carlos.GetBonificacao());

            Console.WriteLine();

            Console.WriteLine(roberta.nome);
            Console.WriteLine(roberta.salario);
            Console.WriteLine("Bonificação do funcionário " + roberta.GetBonificacao());

            Console.WriteLine();

            Console.WriteLine("Total de bonificações " + gerenciador.GetTotalBonificacao());

            Console.WriteLine("Total de Funcionários " + Funcionario.totaldeFuncionarios);

            Console.WriteLine();

            UsarSistema();

            Console.WriteLine();

            Console.WriteLine("Part 4# Start");

            Console.WriteLine();

            // Continuação

            ContaCorrente _001 = new(001, 0001);

            Console.WriteLine(ContaCorrente.taxaOperacao);

            Console.WriteLine();

            try
            {
                ContaCorrente testErro = new(10, 10);
                testErro.Depositar(100);
                Console.WriteLine(testErro.Saldo);
                //testErro.sacar(300);
                //testErro.sacar(500);
                Console.WriteLine(testErro.Saldo);
                Console.WriteLine();
                testErro.Transferir(1000, _001);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine("Seu saldo atual é " + ex.Saldo);
                Console.WriteLine("Você tentou utilizar " + ex.Valorsaque);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.StackTrace);

                ContaCorrente testErro = new(0, 0);
            }

            Console.ReadLine();

        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new();

            Diretor roberta = new("002.002.002-02");

            roberta.nome = "Roberta Cabrini";
            roberta.senha = "123";

            sistemaInterno.Logar(roberta, "123");

            Console.WriteLine();

            ParceiroComercial alagoasSA = new();
            alagoasSA.senha = "1122";

            sistemaInterno.Logar(alagoasSA, "1112");

            Console.WriteLine();

            sistemaInterno.Logar(alagoasSA, "1122");
        }
    }
}
