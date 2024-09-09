using System;
namespace CSharpCodeReview
{
    public class Calculator
    {

        public int Add(int a, int b)
        {
            // Perform addition
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            // Perform subtraction
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double)a / b;
        }

        //I want to add a Power function to this calculator
        public int Power(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        //I want to add a Modulus function to this calculator
        public int Modulus(int a, int b)
        {
            return a % b;
        }

    }

}
