using ByteBank.Model.Sistemas;
using System;

namespace ByteBank.Model.Funcionarios
{
    class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine();
        }

        public override void AumentarSalario()
        {
            salario *= 1.15;
        }
        public override Double GetBonificacao()
        {
            return salario *= 0.5;
        }
    }
}
