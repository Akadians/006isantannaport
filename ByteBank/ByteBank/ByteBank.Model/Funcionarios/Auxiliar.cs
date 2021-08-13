using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model.Funcionarios
{
    class Auxiliar : Funcionario
    {    
        public Auxiliar(string cpf) : base (2000, cpf)
        {
            Console.WriteLine();
        }

        public override void AumentarSalario()
        {
            salario *= 1.10;
        }
        public override Double GetBonificacao()
        {            
            return salario * 0.20;
        }
    }
}
