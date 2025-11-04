using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculatorOOP
{
    public class Calculator // Calculator class to perform basic arithmetic operations
    {
        // Addition 
        // Substraction
        // Multiplication
        // Devision



        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // remember exception handling for division by zero

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }

    }
}
