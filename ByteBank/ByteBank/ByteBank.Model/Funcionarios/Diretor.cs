using ByteBank.Model.Sistemas;
using System;

namespace ByteBank.Model.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine();
        }

        public override void AumentarSalario()
        {
            salario *= 1.15;
        }
        internal protected override Double GetBonificacao()
        {
            return salario *= 0.5;
        }
    }
}
