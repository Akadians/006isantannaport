using ByteBank.Model.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model.Funcionarios
{
    /// <summary>
    /// Funcionário de médio escalão, Gerente de Conta.
    /// </summary>
    public class GerenteDeConta : FuncionarioAutenticavel 
    {
        /// <summary>
        /// Gerente de Conta, salário base R$ 4000,00.
        /// </summary>
        /// <param name="cpf">Cadastro de Pessoa Fisica - Deve Conter 11 Digitos</param>
        public GerenteDeConta(string cpf) : base (4000, cpf)
        {
            Console.WriteLine();
        }
        /// <summary>
        /// Aumento salarial anual padrão ByteBank, Fator de aumento 05%.
        /// </summary>
        public override void AumentarSalario()
        {
            salario *= 1.05;
        }
        /// <summary>
        /// Bonificação anual do funcionário, base salário + 25%.
        /// </summary>
        /// <returns></returns>
        internal protected override Double GetBonificacao()
        {            
            return salario * 0.25;
        }
    }
}
