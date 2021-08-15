using ByteBank.Model.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model.Funcionarios
{
    /// <summary>
    /// Cargo aditivo com permissão de acessar o Sistema Interno.
    /// </summary>
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        /// <summary>
        /// Senha de acesso do funcionário.
        /// </summary>
        public String Pass;
        /// <summary>
        /// Cargo aditivo de confiança, funcionário com permissão de acessar o sistema interno.
        /// </summary>
        /// <param name="salario">Remuneração mensal do funcionário.</param>
        /// <param name="cpf">Cadastro de Pessoa Fisica - Deve Conter 11 Dígitos</param>
        public FuncionarioAutenticavel (double salario, string cpf) : base(salario, cpf)
        {

        }
        /// <summary>
        /// Metodo de autenticação de acesso ao sistema interno.
        /// </summary>
        /// <param name="senha">Senha pré-definida pelo funcionário.</param>
        /// <returns></returns>
        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(senha, Pass);
        }
    }
}
