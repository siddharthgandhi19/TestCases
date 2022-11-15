using FindMaximumNumber;
using NUnit.Framework;

namespace FindMaxNumTest
{
    public class Tests
    {
        FindMaxNum maxNum = new FindMaxNum();
        
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFistMax()
        {
            int result = maxNum.FindMaxInteger(15, 5, 10);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = maxNum.FindMaxInteger(5, 15, 10);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = maxNum.FindMaxInteger(5, 10, 15);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void GivenMaxFirstNumFloat_WhenAnalysed_ShouldReturnFistMax()
        {
            float result = maxNum.FindMaxFloat(15.02f, 5.01f, 10.1f);
            Assert.AreEqual(15.02f, result);
        }
        [Test]
        public void GivenMaxSecondNumFloat_WhenAnalysed_ShouldReturnSecondMax()
        {
            float result = maxNum.FindMaxFloat(5.01f, 15.02f, 10.1f);
            Assert.AreEqual(15.02f, result);
        }
        [Test]
        public void GivenMaxThirdNumFloat_WhenAnalysed_ShouldReturnThirdMax()
        {
            float result = maxNum.FindMaxFloat(5.01f, 10.1f, 15.02f);
            Assert.AreEqual(15.02f, result);
        }
    }
}