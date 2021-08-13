using ByteBank.Model.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Model
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
