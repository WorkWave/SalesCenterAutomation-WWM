using System;
using System.Runtime.Serialization;

namespace WorkWave.PestPac.TA.Steps
{
    [Serializable]
    internal class PendingStepException : Exception
    {
        public PendingStepException()
        {
        }

        public PendingStepException(string message) : base(message)
        {
        }

        public PendingStepException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PendingStepException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}