using ByteBank.Model.Sistemas;
using System;

namespace ByteBank.Model.Funcionarios
{
    /// <summary>
    /// Grupo de funcionário, necessário especificação de cargo para criação.
    /// </summary>
    public abstract class Funcionario
    {
        /// <summary>
        /// Contador de colaboradores do ByteBank.
        /// </summary>
        public static int totaldeFuncionarios { get; private set; }        
        /// <summary>
        /// Deve conter nome completo do funcionário.
        /// </summary>
        public String nome { get; set; }
        /// <summary>
        /// Cadastro de Pessoa Fisica - Deve Conter 11 Digitos
        /// </summary>
        public String cpf { get; private set; }
        /// <summary>
        /// Salário é definido pelo seu cargo no Bytebank.
        /// </summary>
        public Double salario { get; protected set; }
        /// <summary>
        /// Criação de cargo novo no Bytebank.
        /// </summary>
        /// <param name="Salario">Salário é definido pelo seu cargo no Bytebank.</param>
        /// <param name="CPF">Cadastro de Pessoa Fisica - Deve Conter 11 Digitos</param>
        public Funcionario(double Salario, string CPF)
        {
            totaldeFuncionarios++;
            cpf = CPF;
            salario = Salario;
        }     

        /// <summary>
        /// Aumento de salário anual automático, política de incentivo Bytebank.
        /// </summary>
        public abstract void AumentarSalario();
        /// <summary>
        /// Bonificação Anual data junto do 13° salário, política de incentivo Bytebank.
        /// </summary>
        /// <returns></returns>
        internal protected abstract Double GetBonificacao();
    }
}
