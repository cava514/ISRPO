using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork2
{
    class NegativeNumberException : Exception
    {
        public int Value { get; set; }
        public NegativeNumberException(string message, int value) : base(message)
        {
            value = Value;
        }
    }
}
