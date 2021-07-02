using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get;  }
        public double Valorsaque { get; }
        public SaldoInsuficienteException()
        {

        }
        public SaldoInsuficienteException(double saldo, double valorDoSaque) : this ("Tentativa de saque do valor de " + valorDoSaque + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo;
            Valorsaque = valorDoSaque;
        }
        public SaldoInsuficienteException(String mensagem) : base (mensagem)
        {

        }

        public SaldoInsuficienteException(String mensagem, Exception innerException) : base(mensagem, innerException)
        {

        }
    }
}
