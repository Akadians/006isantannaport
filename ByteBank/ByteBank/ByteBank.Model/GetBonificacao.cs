using ByteBank.Model.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model
{
    /// <summary>
    /// Metodo que adiciona bonificação anual para os funcionários Bytebank, política de incentivo Bytebank.
    /// </summary>
    public class GetBonificacao
    {
        private double totalBonificacao;

        /// <summary>
        /// Registro contábil das bonificações geradas.
        /// </summary>
        /// <param name="funcionario"></param>
        public void Registrar (Funcionario funcionario)
        {
            totalBonificacao += funcionario.GetBonificacao();
        }

        /// <summary>
        /// Sistema de acesso a informação total de bonificações.
        /// </summary>
        /// <returns></returns>
        public double GetTotalBonificacao()
        {
            return totalBonificacao;
        }


    }
}
