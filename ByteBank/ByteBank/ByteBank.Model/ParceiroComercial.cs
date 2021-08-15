using ByteBank.Model.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model
{
    /// <summary>
    /// Metodo de cadastro de parceiros comerciais com permissão de acessar o sistema interno.
    /// </summary>
    public class ParceiroComercial : IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new();

        /// <summary>
        /// Senha que deve ser cadastrada para o uso no acesso posteriormente.
        /// </summary>
        public string Pass { get; set; }
        /// <summary>
        /// Metodo utilizado para acessar o sistema interno.
        /// </summary>
        /// <param name="senha"> Senha préviamente registrada no cadastro do parceiro que deve ser usada para acessar o sistema interno.</param>
        /// <returns></returns>
        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(senha, Pass);
        }
    }
}
