using System;
using System.Runtime.Serialization;

namespace WorkWave.PestPac.TA.Steps
{
    [Serializable]
    internal class PendingException : Exception
    {
        public PendingException()
        {
        }

        public PendingException(string message) : base(message)
        {
        }

        public PendingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PendingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}