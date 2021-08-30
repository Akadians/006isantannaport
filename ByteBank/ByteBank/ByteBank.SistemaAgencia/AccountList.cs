using ByteBank.Model;
using System;

namespace ByteBank.SistemaAgencia
{
    public class AccountList
    {
        private ContaCorrente[] _itens;
        private int _numeroDeContas;
        private int _nextPosition;

        public AccountList()
        {
            _itens = new ContaCorrente[_numeroDeContas];
        }
        public void Add(ContaCorrente item)

        {
            if (_nextPosition <= _numeroDeContas)
            {
                _numeroDeContas++;
                
                Console.WriteLine("Aumento de posição");

                return;
            }
            else
            {
                _itens[_nextPosition] = item;
                _nextPosition++;
            }
        }

    }
}
