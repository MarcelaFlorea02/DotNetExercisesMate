using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorsAndExceptions
{
    class Temperature
    {
        public int temp;

        public void DisplayTemperature()
        {
            if (temp != 0)
                Console.WriteLine(temp);
            else
                throw new TempIsZeroException("Temperatura este 0!!!");
        }
    }

    class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {
        }
    }
}
