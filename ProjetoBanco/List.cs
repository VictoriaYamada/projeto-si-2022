using System;

namespace ProjetoBanco
{
    internal class List<T>
    {
        public static implicit operator List<T>(object v)
        {
            throw new NotImplementedException();
        }
    }
}