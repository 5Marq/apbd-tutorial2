using System;

namespace tutorial2
{
    public class OverfillException : System.Exception
    {
        public OverfillException(string message) : base(message)
        {
        }
    }
}