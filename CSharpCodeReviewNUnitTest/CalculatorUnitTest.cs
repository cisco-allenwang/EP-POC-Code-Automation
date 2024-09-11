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

[Test]
public void TestPower_NegativeBase()
{
    // Arrange
    var calculator = new Calculator();
    int baseNum = -2;
    int exponent = 3;

    // Act
    var result = calculator.Power(baseNum, exponent);

    // Assert
    Assert.That(result, Is.EqualTo(-8));
}
        //add the unit test for power fuction
        //add the unit test for modulo function
        //add the unit test for multiply function

        


        
    }

    