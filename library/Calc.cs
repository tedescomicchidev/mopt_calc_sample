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

        public int Square(int a) 
        {
            return a * a;
        }

        public int Exponent(int lower, int power)
        {
            // Special cases  
            if (power == 0 || lower == 1)
                return 1;
            else if (lower == 0)
                return 0;
            else if (power < 0) //throw new ArgumentOutOfRangeException(nameof(power));  
                return (-1);

            // General case: math 
            int result = lower;
            for (int i = 1; i < power; ++i)      
                result *= lower; 

            return result;  
        }
    }
}
