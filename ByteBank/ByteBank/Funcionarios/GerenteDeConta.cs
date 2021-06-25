using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class GerenteDeConta : FuncionarioAutenticavel 
    {    
        public GerenteDeConta(string cpf) : base (4000, cpf)
        {
            Console.WriteLine();
        }

        public override void AumentarSalario()
        {
            salario *= 1.05;
        }
        public override Double GetBonificacao()
        {            
            return salario * 0.25;
        }
    }
}
