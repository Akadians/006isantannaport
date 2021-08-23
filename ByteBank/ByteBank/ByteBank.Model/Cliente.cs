using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model
{
    /// <summary>
    /// Classe utilizada para adicionar o cliente do Bytebank
    /// </summary>
   public class Cliente
    {
        /// <summary>
        /// Deve-se adicionar Nome completo do cliente.
        /// </summary>
        public String nome;
        /// <summary>
        /// Cadastro de Pessoa Fisica - Deve Conter 11 Digitos
        /// </summary>
        public String cpf;
        /// <summary>
        /// Profissão exercida pelo cliente.
        /// </summary>
        public String profissao;
        /// <summary>
        /// Metodo de comparação das informações de cliente para identificaçao de duplicidades.
        /// </summary>
        /// <param name="obj"> Espe parametro deve conter o cliente alvo da comparação.</param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            Cliente outroCliente = obj as Cliente;

            if(outroCliente == null)
            {
                return false;
            }

            return cpf == outroCliente.cpf;
        }
        /// <summary>
        /// Metodo não implementado.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
