using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {

        }

        public OperacaoFinanceiraException(String mensagem) : base(mensagem)
        {

        }

        public OperacaoFinanceiraException(String mensagem, Exception innerException) : base(mensagem, innerException)
        {

        }
    }
}
