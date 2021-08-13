using ByteBank.Model.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model
{
    
    class GetBonificacao
    {
        private double totalBonificacao;

        public void Registrar (Funcionario funcionario)
        {
            totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return totalBonificacao;
        }


    }
}
