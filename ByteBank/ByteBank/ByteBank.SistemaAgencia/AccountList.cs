using ByteBank.Model;
using System;

namespace ByteBank.SistemaAgencia
{
    public class AccountList
    {
        private ContaCorrente[] _itens;        
        private int _nextPosition;

        public int Tamanho
        {
            get
            {
                return _nextPosition;
            }
        }

        public AccountList(int _numeroDeContas = 1)
        {
            _itens = new ContaCorrente[_numeroDeContas];
            _nextPosition = 0;
        }
        public void Add(ContaCorrente item)

        {
            CapCheck(_nextPosition + 1);

            _itens[_nextPosition] = item;
            
            _nextPosition++;
            Console.WriteLine(_nextPosition);
        }

        private void CapCheck(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            ContaCorrente[] newArray = new ContaCorrente[tamanhoNecessario];

            for(int i = 0; i < _itens.Length; i++)
            {
                newArray[i] = _itens[i];
            }

            _itens = newArray;
        }

        public void Remove(ContaCorrente item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _nextPosition - 1; i++)
            {
                ContaCorrente itemAtual = _itens[i];

                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _nextPosition; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _nextPosition--;
            _itens[_nextPosition] = null;
        }

        public ContaCorrente GetitemIndex(int indice)
        {
            if (indice < 0 || indice >= _nextPosition)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }

        public ContaCorrente this[int indice]
        {
            get
            {
                return GetitemIndex(indice);
            }
        }
    }
}
