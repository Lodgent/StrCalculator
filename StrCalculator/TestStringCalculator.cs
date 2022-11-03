using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StringCalculator
{
    public class Tests
    {
        private StringCalculator stringCalculator;

        [SetUp]
        public void Setup()
        {
            stringCalculator = new StringCalculator();
        }

        [Test]
        public void ReturnZero_WhenEmptyString()
        {
            var result = stringCalculator.Add("");
            Assert.AreEqual(result, 0);
        }
        [Test]
        public void ReturnParsedInt_WhenOneNumber()
        {
            var result = stringCalculator.Add("1");
            Assert.AreEqual(result, 1);
        }
        [Test]
        public void ReturnSum_WhenTwoNumbers()
        {
            var result = stringCalculator.Add("1,2");
            Assert.AreEqual(result, 3);
        }
        [Test]
        public void ReturnSum_WhenSeveralNumbers()
        {
            var result = stringCalculator.Add("1,2,3");
            Assert.AreEqual(result, 6);
        }
        [Test]
        public void ReturnSum_WhenSeveralBigNumbers()
        {
            var result = stringCalculator.Add("1,2,3,4,5,6,7,8");
            Assert.AreEqual(result, 36);
        }
    }
}