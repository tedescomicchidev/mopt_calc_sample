using System;

namespace library
{
    public class Calc
    {
        public int Add(int a, int b) 
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b) 
        {
            return a * b;
        }

        public int Divide(int a, int b) 
        {
            try {
                return(a / b);
            }
            catch (DivideByZeroException) {
                Console.WriteLine("Division of {0} by zero.", a);
            }
            return(-1);
        }
    }
}
