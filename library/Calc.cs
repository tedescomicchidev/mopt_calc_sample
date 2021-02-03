using System;
using System.Diagnostics;
using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;
using MathNet.Numerics.LinearAlgebra;

using Complex = System.Numerics.Complex;

namespace library
{
    public class Calc
    {
        public void Vuln()
        {
            Matrix<Complex> matrix = CreateMatrix.Random<Complex>(10, 10, 100);
            Vector<Complex> vector = matrix.Svd().S;
            Fourier.Forward(vector.AsArray());
            Console.WriteLine(Control.Describe());
            Console.WriteLine($"DC={vector[0].Magnitude}; Low={vector[1].Magnitude}; Hight={vector[5].Magnitude}");
        }
       
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
    }
}
