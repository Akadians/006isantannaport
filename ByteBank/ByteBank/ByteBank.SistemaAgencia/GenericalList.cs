using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class GenericalList<T>
    {

        private T[] _itens;
        private int _nextPosition;

        public int Tamanho
        {
            get
            {
                return _nextPosition;
            }
        }

        public GenericalList(int _numeroDeObjetos = 1)
        {
            _itens = new T[_numeroDeObjetos];
            _nextPosition = 0;
        }
        public void Add(T item)

        {
            CapCheck(_nextPosition + 1);

            _itens[_nextPosition] = item;

            _nextPosition++;
            Console.WriteLine(_nextPosition);
        }

        public void AddMultiple(params T[] itens)
        {
            foreach (T conta in itens)
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

            T[] newArray = new T[tamanhoNecessario];

            for (int i = 0; i < _itens.Length; i++)
            {
                newArray[i] = _itens[i];
            }

            _itens = newArray;
        }

        public void Remove(T item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _nextPosition - 1; i++)
            {
                T itemAtual = _itens[i];

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
            //_itens[_nextPosition] = null;
        }

        public T GetitemIndex(int indice)
        {
            if (indice < 0 || indice >= _nextPosition)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }

        public T this[int indice]
        {
            get
            {
                return GetitemIndex(indice);
            }
        }
    }
}
