using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model
{
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string passTrue, string passTry)
        {
            return passTrue == passTry;
        }

    }
}
