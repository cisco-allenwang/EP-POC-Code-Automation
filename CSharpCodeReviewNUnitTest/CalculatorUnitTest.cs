namespace CSharpCodeReviewNUnitTest;

using CSharpCodeReview;
using NUnit.Framework;

[TestFixture]
    public class CalculatorUnitTest
    {
       
        [Test]
        public void TestAdd()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 10;
            int b = 5;

            // Act
            int result = calculator.Add(a, b);

            // Assert
           Assert.That(result, Is.EqualTo(15));

        }

        // [Test]
        // public void TestSubtract()
        // {
        //     // Arrange
        //     var calculator = new Calculator();
        //     int a = 10;
        //     int b = 5;

        //     // Act
        //     int result = calculator.Subtract(a, b);

        //     // Assert
        //     Assert.That(result, Is.EqualTo(5));
        // }

        
        [Test]
        public void TestDivide()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 10;
            int b = 5;

            // Act
            var result = calculator.Divide(a,b);

            // Assert
            Assert.That(result, Is.EqualTo(2.0));
        }

        // Add testing cases for Calculator.cs
        
        [Test]
        public void TestSubtract()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 10;
            int b = 5;
        
            // Act
            int result = calculator.Subtract(a, b);
        
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        
        [Test]
        public void TestMultiply()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 10;
            int b = 5;
        
            // Act
            int result = calculator.Multiply(a, b);
        
            // Assert
            Assert.That(result, Is.EqualTo(50));
        }
        
        [Test]
        public void TestPower()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 2;
            int b = 3;
        
            // Act
            double result = calculator.Power(a, b);
        
            // Assert
            Assert.That(result, Is.EqualTo(8.0));
        }
        
        [Test]
        public void TestFactorial()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5;
        
            // Act
            int result = calculator.Factorial(a);
        
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
    }

    