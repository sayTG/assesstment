using CAssessment2.Services;
using NUnit.Framework;

namespace CorrectionTest
{
    public class Tests
    {
        private CorrectionService _correctionValidation;

        [SetUp]
        public void Setup()
        {
            _correctionValidation = new CorrectionService();
        }

        [TestCase("42", 42)]
        [TestCase("-42", -42)]
        [TestCase("4193 with words",4193)]
        [TestCase("words and 987", 0)]
        [TestCase("-91283472332", int.MinValue)]
        [TestCase("91283472332", int.MaxValue)]
        [TestCase("3.14159", 3)]
        [TestCase("+-12", 0)]
        [TestCase("00000-42a1234",0)]
        [TestCase("  -0012a42",-12)]
        [TestCase("-",0)]
        public void Test1(string command, int expectedResult)
        {
            // Arrange & Act
            var result = _correctionValidation.MyAtoi(command);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}