using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensions
{
    public static class ListExtensions
    {
        public static void AddMore<T>(this List<T> intList, params T[] itens)
        {
            foreach (T item in itens)
            {
                intList.Add(item);
            }
        }
    }
}
