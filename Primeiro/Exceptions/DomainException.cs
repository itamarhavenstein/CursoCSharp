using System;

namespace Primeiro.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) {}
    }
}