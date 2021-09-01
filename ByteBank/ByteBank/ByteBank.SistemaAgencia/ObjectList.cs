using System;

namespace ByteBank.SistemaAgencia
{
    class ObjectList
    {

        private Object[] _itens;
        private int _nextPosition;

        public int Tamanho
        {
            get
            {
                return _nextPosition;
            }
        }

        public ObjectList(int _numeroDeObjetos = 1)
        {
            _itens = new Object[_numeroDeObjetos];
            _nextPosition = 0;
        }
        public void Add(Object item)

        {
            CapCheck(_nextPosition + 1);

            _itens[_nextPosition] = item;

            _nextPosition++;
            Console.WriteLine(_nextPosition);
        }

        public void AddMultiple(params Object[] itens)
        {
            foreach (Object conta in itens)
            {
                Add(conta);
            }
        }

        private void CapCheck(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            Object[] newArray = new Object[tamanhoNecessario];

            for (int i = 0; i < _itens.Length; i++)
            {
                newArray[i] = _itens[i];
            }

            _itens = newArray;
        }

        public void Remove(Object item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _nextPosition - 1; i++)
            {
                Object itemAtual = _itens[i];

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

        public Object GetitemIndex(int indice)
        {
            if (indice < 0 || indice >= _nextPosition)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }

        public Object this[int indice]
        {
            get
            {
                return GetitemIndex(indice);
            }
        }
    }
}

