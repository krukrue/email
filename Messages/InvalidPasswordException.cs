using System.Runtime.Serialization;

namespace Messages
{
    [Serializable]
    public class InvalidPasswordException : Exception
    {
        readonly public string error;
        public InvalidPasswordException()
        {
        }
        public InvalidPasswordException(string Message, string text, string password)
        {
            error = $"{Message}, {text}, {password}";
        }

        public InvalidPasswordException(string message) : base(message)
        {
        }

        public InvalidPasswordException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidPasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}