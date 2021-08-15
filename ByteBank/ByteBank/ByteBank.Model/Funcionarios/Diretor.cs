using ByteBank.Model.Sistemas;
using System;

namespace ByteBank.Model.Funcionarios
{
    /// <summary>
    /// Funcionário de alto escalão, Diretor.
    /// </summary>
    public class Diretor : FuncionarioAutenticavel
    {
        /// <summary>
        /// Diretor, salário base R$ 5000,00.
        /// </summary>
        /// <param name="cpf">Cadastro de Pessoa Fisica - Deve Conter 11 Digitos</param>
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine();
        }

        /// <summary>
        /// Aumento salarial anual padrão ByteBank, Fator de aumento 15%.
        /// </summary>
        public override void AumentarSalario()
        {
            salario *= 1.15;
        }
        /// <summary>
        /// Bonificação anual do funcionário, base salário + 50%.
        /// </summary>
        /// <returns></returns>
        internal protected override Double GetBonificacao()
        {
            return salario *= 0.5;
        }
    }
}
