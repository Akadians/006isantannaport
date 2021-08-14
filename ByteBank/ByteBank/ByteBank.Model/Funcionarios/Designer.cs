using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model.Funcionarios
{
    public class Designer : Funcionario
    {    
        public Designer(string cpf) : base (3000, cpf)
        {
            Console.WriteLine();
        }

        public override void AumentarSalario()
        {
            salario *= 1.11;
        }
        internal protected override Double GetBonificacao()
        {            
            return salario * 0.17;
        }
    }
}
