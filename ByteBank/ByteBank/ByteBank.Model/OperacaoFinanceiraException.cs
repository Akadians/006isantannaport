using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model
{
    /// <summary>
    /// Exception gerada para problemas ocorridos nas operações financeiras.
    /// </summary>
    public class OperacaoFinanceiraException : Exception
    {
        /// <summary>
        /// Implementação padrão.
        /// </summary>
        public OperacaoFinanceiraException()
        {

        }
        /// <summary>
        /// Implementação descricional.
        /// </summary>
        /// <param name="mensagem">Deve conter mensagem que descreva a ocorrencia do erro e seu motivo.</param>
        public OperacaoFinanceiraException(String mensagem) : base(mensagem)
        {

        }

        /// <summary>
        /// Implementação descricional com tratamento interno.
        /// </summary>
        /// <param name="mensagem">Deve conter mensagem que descreva a ocorrencia do erro e seu motivo.</param>
        /// <param name="innerException">Deve indicar o nome da InnerException que tratará a exception.</param>
        public OperacaoFinanceiraException(String mensagem, Exception innerException) : base(mensagem, innerException)
        {

        }
    }
}
