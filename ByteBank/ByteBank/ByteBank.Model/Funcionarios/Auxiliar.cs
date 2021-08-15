using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model.Funcionarios
{
    /// <summary>
    /// Funcionário com cargo administrativo, Auxiliar Administrativo.
    /// </summary>
    public class Auxiliar : Funcionario
    {   
        /// <summary>
        /// Auxiliar Administrativo, Salário base R$ 2000,00.
        /// </summary>
        /// <param name="cpf">Cadastro de Pessoa Fisica - Deve Conter 11 Digitos</param>
        public Auxiliar(string cpf) : base (2000, cpf)
        {
            Console.WriteLine();
        }

        /// <summary>
        /// Aumento salarial anual padrão ByteBank, Fator de aumento 10%.
        /// </summary>
        public override void AumentarSalario()
        {
            salario *= 1.10;
        }
        /// <summary>
        /// Bonificação anual do funcionário, base salário + 20%.
        /// </summary>
        /// <returns></returns>
        internal protected override Double GetBonificacao()
        {            
            return salario * 0.20;
        }
    }
}
