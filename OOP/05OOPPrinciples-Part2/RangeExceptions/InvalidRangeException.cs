namespace RangeExceptions
{
    using System;
    using System.Linq;

    public class InvalidRangeException<T> : ApplicationException 

    {
        public InvalidRangeException(string message):base (message)
        {
            
        }

        public InvalidRangeException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        public int CompareTo<T>(T other) 
        {
            return 1;
        }
    }
}
