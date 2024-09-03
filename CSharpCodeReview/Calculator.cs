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

        //add a power function
        public int Power(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        //add a factorial function

        public int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("n must be a non-negative integer.");
            }

            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;  //return result     
        }


    }

}
