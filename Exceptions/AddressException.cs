using System;

namespace Exceptions
{
    public class AddressException : ApplicationException
    {
        public string ExMessage { get; set; }
        public AddressException(string message) {
            ExMessage = message;
        }
    }
}
