﻿using System;
using library;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calc();
                    
            Console.WriteLine(string.Format("Hello World! {0} / {1} / {2} / {3}", calc.Add(2, 2), calc.Multiply(2,3), calc.Divide(9,3), calc.Square(9)));
        }
    }
}