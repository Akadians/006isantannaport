using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Diretor : Funcionario
    {    

        public override Double GetBonificacao()
        {            
            return salario + base.GetBonificacao();
        }
    }
}
