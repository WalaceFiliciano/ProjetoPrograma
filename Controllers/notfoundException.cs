using System;
using System.Runtime.Serialization;

namespace SalesWebMvc.Controllers
{
    [Serializable]
    internal class notfoundException : Exception
    {
        public notfoundException()
        {
        }

        public notfoundException(string message) : base(message)
        {
        }

        public notfoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected notfoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}