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

        //I want to add Modulus and Power function for this calculator class, and also create the unit testing cases for them
        public int Modulus(int a, int b)
        {
            return a % b;
        }
        public int Power(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        

    }

}
