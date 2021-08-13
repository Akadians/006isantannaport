using ByteBank.Model.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model.Funcionarios
{
    abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public String senha;
        public FuncionarioAutenticavel (double salario, string cpf) : base(salario, cpf)
        {

        }
        public bool Autenticar(string Senha)
        {
            return senha == Senha;
        }
    }
}
