using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model
{
    /// <summary>
    /// Sistema auxiliar responsável pela verificação dos dados de acesso ao sistema interno.
    /// </summary>
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string passTrue, string passTry)
        {
            return passTrue == passTry;
        }

    }
}
