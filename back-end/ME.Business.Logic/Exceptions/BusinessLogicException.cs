using System;

namespace ME.Business.Logic.Exceptions
{
    public class BusinessLogicException : Exception
    {
        public BusinessLogicException(string message) : base(message)
        {
                
        }
    }
}
