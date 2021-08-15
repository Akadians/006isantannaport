using System;

namespace ByteBank.Model
{
    /// <summary>
    /// Classe que define o comportamento padrão de uma conta corrente no banco ByteBank.
    /// </summary>
    public class ContaCorrente
    {
        /// <summary>
        /// Taxa padrão cobrada em cima de cada operação realizada na conta corrente.
        /// </summary>
        public static double taxaOperacao { get; private set; }
        /// <summary>
        /// Contador de contas criadas no Bytebank.
        /// </summary>
        public static int totalDeContasCriadas { get; private set; }

        /// <summary>
        /// Atribuição de titular da conta.
        /// </summary>
        public Cliente titular { get; set; }

        /// <summary>
        /// Marcador estatistico de operação de saque negados.
        /// </summary>
        public int contadorSaquesNegados { get; private set; }
        /// <summary>
        /// Marcador estatistico de operação de transferencias negados.
        /// </summary>
        public int contadortransferenciasNegados { get; private set; }

        /// <summary>
        /// Numero atribuido da conta.
        /// </summary>
        public int Numero { get; }
        /// <summary>
        /// Agencia de origem da conta.
        /// </summary>
        public int Agencia { get; }
       
        private double _saldo = 100;
        /// <summary>
        /// Valor que representa o montante disponivél na conta.
        /// </summary>
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }
        /// <summary>
        /// Cria uma instancia de conta corrente com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia"> Representa o valor da propriedade <see cref="Agencia"/> e deve ser > 0.</param>
        /// <param name="numero"> Representa o valor da propriedade <see cref="Numero"/> e deve ser > 0.</param>
        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("Agencia deve ser maior que 0.", nameof(agencia));
            }
            if (numero <= 0)
            {
                throw new ArgumentException("Numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;
            totalDeContasCriadas++;
            taxaOperacao = 30 / totalDeContasCriadas;
        }
        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>.
        /// </summary>
        /// <exception cref="ArgumentException"> Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/></exception>
        /// <exception cref="SaldoInsuficienteException"> Exceção lançada quando o valor de <paramref name="valor"/> é maior que o valor da propriedade <see cref="Saldo"/>.</exception>
        /// <param name="valor">Representa o valor do saque, deve ser > 0 e menor que <see cref="Saldo"/></param>
        public void sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException(" Valor Inválido para o saque: " + nameof(valor));
            }
            if (this.Saldo < valor)
            {
                contadorSaquesNegados++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            this.Saldo -= valor;            
        }
        /// <summary>
        /// Realiza o deposito e atualiza o valor da propriedade <see cref="Saldo"/>
        /// </summary>
        /// <param name="valor">Representa o valor do depósito, deve ser > 0 e menor que <see cref="Saldo"/></param>
        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
        /// <summary>
        /// Realiza uma transferencia de valores entre contas e atualiza o valor da propriedade <see cref="Saldo"/> de ambas as contas.
        /// </summary>
        /// <exception cref="ArgumentException">Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/></exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o valor de <paramref name="valor"/> é maior que o valor da propriedade <see cref="Saldo"/>.</exception>
        /// <param name="valor">Representa o valor da transferencia, deve ser > 0 e menor que <see cref="Saldo"/></param>
        /// <param name="contaDestino">Conta corrente destino para a transferencia de valores</param>
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException(" Valor Inválido para a transferencia: " + nameof(valor));
            }

            try
            {
                sacar(valor);
            }
            catch(SaldoInsuficienteException ex)
            {                
                contadortransferenciasNegados++;
                throw new OperacaoFinanceiraException("Operação não autorizada", ex);
            }
            
            contaDestino.Depositar(valor);            
        }
    }
}
