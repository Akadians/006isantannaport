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

    }
}
