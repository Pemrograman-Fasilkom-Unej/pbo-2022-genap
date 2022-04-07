using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumAbstract
{
    internal class GakBisaNgodingException : Exception
    {
        public GakBisaNgodingException()
        {
        }

        public GakBisaNgodingException(string? message) : base(message)
        {
        }

        public GakBisaNgodingException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
