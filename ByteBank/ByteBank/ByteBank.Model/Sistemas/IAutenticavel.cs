using System;

namespace ByteBank.Model.Sistemas
{
    interface IAutenticavel
    {
        public bool Autenticar(string Senha);
      
    }
}
