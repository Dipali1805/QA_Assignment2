using NUnit.Framework;
using NUnit.Framework.Internal;
using TriangleSolver;
namespace Assignment2
{

    [TestFixture]
    public class Class1
    {

        [Test]
        public void ValidEquilateralTriangle_Input6and6and6_OutputvalidEquilateralTriangle()
        {
            // Arrange
            int firstSide = 6;
            int secondSide = 6;
            int thirdSide = 6;

            string expected = "The triangle is valid and is an EQUILATERAL";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidIsoscelesTriangle_Input5and5and6_OutputValidIsoscelesTrianle()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 6;

            string expected = "The triangle is valid and is an ISOSCELES";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidIsoscelesTraiangle_Input1and5and5_OutputValidIsoscelesTriangle()
        {
            // Arrange
            int firstSide = 1;
            int secondSide = 5;
            int thirdSide = 5;

            string expected = "The triangle is valid and is an ISOSCELES";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidIsoscelesTriangle_Input6and3and3_OutputValidIsoscelesTriangle()
        {
            // Arrange
            int firstSide = 6;
            int secondSide = 3;
            int thirdSide = 6;

            string expected = "The triangle is valid and is an ISOSCELES";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidScaleneTriangle_Input5and6and9_OutputValidScaleneTriangle()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 6;
            int thirdSide = 9;

            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidScaleneTriangle_Input8and9and12_OutputValidScaleneTriangle()
        {
            // Arrange
            int firstSide = 8;
            int secondSide = 9;
            int thirdSide = 12;

            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidScaleneTriangle_Input9and5and11_OutputValidScaleneTriangle()
        {
            // Arrange
            int firstSide = 9;
            int secondSide = 5;
            int thirdSide = 11;

            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidScaleneTriangle_Input7and10and14_OutputValidScaleneTriangle()
        {
            // Arrange
            int firstSide = 7;
            int secondSide = 10;
            int thirdSide = 14;

            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidScaleneTriangle_Input4and13and15_OutputValidScaleneTriangle()
        {
            // Arrange
            int firstSide = 4;
            int secondSide = 13;
            int thirdSide = 15;

            string expected = "The triangle is valid and is a SCALENE";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void VerifyingZeroLengthForOneSide_Input0and58and72_OuputVerifyingZeroLengthForOneSide()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 58;
            int thirdSide = 72;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void VerifyingZeroLengthForOneSide_Input4and0and8_OuputVerifyingZeroLengthForOneSide()
        {
            // Arrange
            int firstSide = 4;
            int secondSide = 0;
            int thirdSide = 8;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void VerifyingZeroLengthForOneSide_Input3and9and0_OuputVerifyingZeroLengthForOneSide()
        {
            // Arrange
            int firstSide = 3;
            int secondSide = 9;
            int thirdSide = 0;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, result);
        }





    }
}