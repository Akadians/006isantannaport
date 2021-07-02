using System;

namespace ByteBank
{
    class ContaCorrente
    {
        public static double taxaOperacao { get; private set; }
        public static int totalDeContasCriadas { get; private set; }

        public Cliente titular { get; set; }

        public int contadorSaquesNegados { get; private set; }
        public int contadortransferenciasNegados { get; private set; }
        public int Numero { get; }
        public int Agencia { get; }
       
        private double _saldo = 100;
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

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

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
