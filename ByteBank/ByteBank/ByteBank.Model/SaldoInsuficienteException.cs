using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model
{
    /// <summary>
    /// Exception resultante de falta de saldo para realizar a operação solicitada.
    /// </summary>
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        /// <summary>
        /// Montante financeiro guardado na conta acessada.
        /// </summary>
        public double Saldo { get;  }
        /// <summary>
        /// Valor requisitado para ser deduzido do <see cref="Saldo"/>.
        /// </summary>
        public double Valorsaque { get; }
        /// <summary>
        /// Implementação Padrão.
        /// </summary>
        public SaldoInsuficienteException()
        {

        }
        /// <summary>
        /// Implementação descricional completa para saque.
        /// </summary>
        /// <param name="saldo"> Informa o valor do <see cref="Saldo"/> atual da conta.</param>
        /// <param name="valorDoSaque">Informa o valor de <see cref="Valorsaque"/> requisitado na transação.</param>
        public SaldoInsuficienteException(double saldo, double valorDoSaque) : this ($"Tentativa de saque do valor de {valorDoSaque} em uma conta com saldo de {saldo}")
        {
            Saldo = saldo;
            Valorsaque = valorDoSaque;
        }
        /// <summary>
        /// Implementação descricional.
        /// </summary>
        /// <param name="mensagem"> Deve conter mensagem de referencia para a ocorrencia da exception.</param>
        public SaldoInsuficienteException(String mensagem) : base (mensagem)
        {

        }
        /// <summary>
        /// Implementação descricional com tratamento interno.
        /// </summary>
        /// <param name="mensagem">Deve conter mensagem que descreva a ocorrencia do erro e seu motivo.</param>
        /// <param name="innerException">Deve indicar o nome da InnerException que tratará a exception.</param>
        public SaldoInsuficienteException(String mensagem, Exception innerException) : base(mensagem, innerException)
        {

        }
    }
}
