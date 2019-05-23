using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace CalculatorTest
{
    public class Class1
    {
        [TestFixture]
        class CalcTests
        {
            [Test]
            public void GetAddition_Input3point4and5point6_Returns9point0()
            {
                //Arrange 
                double
                number1 = 4.4;
                double
                number2 = 5.6;
                double
                expectedResult = number1 + number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input2point4and5point6_Returns8point0()
            {
                //Arrange 
                double
                number1 = 2.4;
                double
                number2 = 5.6;
                double
                expectedResult = number1 + number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetAddition_Input4point4and5point6_Returns10point0()
            {
                //Arrange 
                double
                number1 = 4.4;
                double
                number2 = 5.6;
                double
                expectedResult = number1 + number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtract_Input5point0and2point0_Returns3point0()
            {
                //Arrange 
                double
                number1 = 6;
                double
                number2 = 2;
                double
                expectedResult = number1 - number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtract_Input4point0and2point0_Returns2point0()
            {
                //Arrange 
                double
                number1 = 4;
                double
                number2 = 2;
                double
                expectedResult = number1 - number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetSubtract_Input6point0and2point0_Returns4point0()
            {
                //Arrange 
                double
                number1 = 6;
                double
                number2 = 2;
                double
                expectedResult = number1 - number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetSubtraction();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiply_Input5point0and2point0_Returns10point0()
            {
                //Arrange 
                double
                number1 = 5;
                double
                number2 = 2;
                double
                expectedResult = number1 * number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiply_Input9point0and2point0_Returns18point0()
            {
                //Arrange 
                double
                number1 =10;
                double
                number2 = 2;
                double
                expectedResult = number1 * number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetMultiply_Input7point0and2point0_Returns14point0()
            {
                //Arrange 
                double
                number1 = 7;
                double
                number2 = 2;
                double
                expectedResult = number1 * number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetMultiplication();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input10point0and2point0_Returns5point0()
            {
                //Arrange 
                double
                number1 =10;
                double
                number2 = 2;
                double
                expectedResult = number1 / number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input30point0and2point0_Returns15point0()
            {
                //Arrange 
                double
                number1 = 50;
                double
                number2 = 2;
                double
                expectedResult = number1 / number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void GetDivision_Input10point4and2point6_Returns4point0()
            {
                //Arrange 
                double
                number1 = 10.4;
                double
                number2 = 2.6;
                double
                expectedResult = number1 / number2;
                Calc
                testCalc = new
                Calc(number1, number2);
                //Act 
                double
                actualResult = testCalc.GetDivision();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);
            }
        }
    }
}
