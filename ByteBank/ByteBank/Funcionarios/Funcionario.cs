using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Funcionario
    {

        public String nome { get; set; }
        public String cpf { get; set; }
        public Double salario { get; set; }

        public virtual Double GetBonificacao()
        {
            return salario * 0.10;
        }
    }
}
