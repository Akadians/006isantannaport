using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class ParceiroComercial : IAutenticavel
    {

        public String senha;
        public bool Autenticar(string Senha)
        {
            return senha == Senha;
        }
    }
}
