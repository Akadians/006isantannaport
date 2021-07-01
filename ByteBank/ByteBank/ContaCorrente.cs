using System;

namespace ByteBank
{
    class ContaCorrente
    {
        public static double taxaOperacao { get; private set; }
        public static int totalDeContasCriadas { get; private set; }

        public Cliente titular { get; set; }


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
            //taxaOperacao = 30 / totalDeContasCriadas;

            totalDeContasCriadas++;
        }

        public bool sacar(double valor)
        {
            if (this.Saldo < valor)
            {
                return false;
            }

            this.Saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.Saldo < valor)
            {
                return false;
            }

            this.Saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
