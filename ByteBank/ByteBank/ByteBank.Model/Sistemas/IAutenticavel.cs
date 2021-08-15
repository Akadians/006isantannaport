using System;

namespace ByteBank.Model.Sistemas
{
    /// <summary>
    /// Interface que atribui uma subclasse ao funcionário com direito a autenticar-se e entrar no sistema interno.
    /// </summary>
    interface IAutenticavel
    {
        public bool Autenticar(string Senha);      
    }
}
