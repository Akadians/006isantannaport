using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model.Funcionarios
{
    /// <summary>
    /// Funcionário com cargo de designer, Designer Gráfico.
    /// </summary>
    public class Designer : Funcionario
    {
        /// <summary>
        /// Designer Gráfico, salário base R$ 3000,00.
        /// </summary>
        /// <param name="cpf">Cadastro de Pessoa Fisica - Deve Conter 11 Digitos</param>
        public Designer(string cpf) : base (3000, cpf)
        {
            Console.WriteLine();
        }
        /// <summary>
        /// Aumento salarial anual padrão ByteBank, Fator de aumento 11%.
        /// </summary>
        public override void AumentarSalario()
        {
            salario *= 1.11;
        }
        /// <summary>
        /// Bonificação anual do funcionário, base salário + 17%.
        /// </summary>
        /// <returns></returns>
        internal protected override Double GetBonificacao()
        {            
            return salario * 0.17;
        }
    }
}
