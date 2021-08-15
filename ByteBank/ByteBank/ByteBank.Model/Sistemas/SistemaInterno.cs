using ByteBank.Model.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model.Sistemas
{
    class SistemaInterno
    {
        /// <summary>
        /// Sistema de acesso restrito a somente alguns funcionários e parceiros comerciais.
        /// </summary>
        /// <param name="funcionario"> Nome do funcionário que detém a permissão para acessar o sistema.</param>
        /// <param name="senha"> Senha atribuida ao funcionário no momento de seu cadastro.</param>
        /// <returns></returns>
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioautenticado = funcionario.Autenticar(senha);

            if(usuarioautenticado)
            {
                Console.WriteLine("Bem vindo " + funcionario);
                return true;
            }
            else
            {
                Console.WriteLine("Você não está autorizado a acessar e/ou senha incorreta");
                return false;
            }
        }

    }
}
