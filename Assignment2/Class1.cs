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






    }
}