﻿namespace UFMG.Apresentacao.Exceptions

{
    public sealed class NotFoundException : Exception
    {
        public NotFoundException() { }

        public NotFoundException(string mensage) : base(mensage) { }
    }
}
