using System.Text;

namespace System
{
    public static class ExceptionExtensions
    {
        public static string GetFullErrorMessage(this Exception exception)
        {
            var sbMessage = new StringBuilder(exception.Message);

            var innerException = exception.InnerException;
            while (innerException != null)
            {
                sbMessage.AppendLine();
                sbMessage.Append(innerException.Message);
                innerException = innerException.InnerException;
            }
            return sbMessage.ToString();
        }
    }
}
