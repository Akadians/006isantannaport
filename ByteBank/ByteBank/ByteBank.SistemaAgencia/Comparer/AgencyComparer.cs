using ByteBank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparer
{
    class AgencyComparer : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if (x == null)
            {
                return 1;
            }    
            else if(y == null)
            {
                return -1;
            }
            else if( x == y)
            {
                return 0;
            }
            return x.Agencia.CompareTo(y.Agencia);
        }
    }
}
