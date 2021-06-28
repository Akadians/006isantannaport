namespace ByteBank
{
    class ContaCorrente
    {
        public static double taxaOperacao { get; private set; }
        public static int totalDeContasCriadas { get; private set; }

        public Cliente titular { get; set; }

        public int Numero { get; set; }

        private int _agencia;
        public int Agencia;

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
            Agencia = agencia;
            Numero = numero;
            taxaOperacao = 30 / totalDeContasCriadas;

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
