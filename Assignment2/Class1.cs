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

       



    }
}