using ByteBank.Sistemas;
using System;

namespace ByteBank.Funcionarios
{
    abstract class Funcionario
    {
        
        public static int totaldeFuncionarios { get; private set; }        

        public String nome { get; set; }
        public String cpf { get; private set; }
        public Double salario { get; protected set; }

        public Funcionario(double Salario, string CPF)
        {
            totaldeFuncionarios++;
            cpf = CPF;
            salario = Salario;
        }     

        public abstract void AumentarSalario();
        public abstract Double GetBonificacao();
    }
}
