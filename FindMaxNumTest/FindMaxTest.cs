using FindMaximumNumber;
using NUnit.Framework;
using System;

namespace FindMaxNumTest
{
    public class Tests
    {
        FindMaxNum maxNum = new FindMaxNum();
        FindMaxGeneric<int> generic1 = new FindMaxGeneric<int>();
        FindMaxGeneric<float> generic2 = new FindMaxGeneric<float>();
        FindMaxGeneric<string> generic3 = new FindMaxGeneric<string>();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFistMax()
        {
            int result = generic1.FindMax(15, 5, 10);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = generic1.FindMax(5, 15, 10);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = generic1.FindMax(5, 10, 15);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void GivenMaxFirstNumFloat_WhenAnalysed_ShouldReturnFistMax()
        {
            float result = generic2.FindMax(15.02f, 5.01f, 10.1f);
            Assert.AreEqual(15.02f, result);
        }
        [Test]
        public void GivenMaxSecondNumFloat_WhenAnalysed_ShouldReturnSecondMax()
        {
            float result = generic2.FindMax(5.01f, 15.02f, 10.1f);
            Assert.AreEqual(15.02f, result);
        }
        [Test]
        public void GivenMaxThirdNumFloat_WhenAnalysed_ShouldReturnThirdMax()
        {
            float result = generic2.FindMax(5.01f, 10.1f, 15.02f);
            Assert.AreEqual(15.02f, result);
        }
        [Test]
        public void GivenMaxFirstNumString_WhenAnalysed_ShouldReturnFistMax()
        {
            string result = generic3.FindMax("Peach","Apple", "Banana");
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenMaxSecondNumString_WhenAnalysed_ShouldReturnSecondMax()
        {
            string result = generic3.FindMax( "Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", result);
        }
        [Test]
        public void GivenMaxThirdNumString_WhenAnalysed_ShouldReturnThirdMax()
        {
            string result = generic3.FindMax("Apple", "Banana" , "Peach");
            Assert.AreEqual("Peach", result);
        }
    }
}