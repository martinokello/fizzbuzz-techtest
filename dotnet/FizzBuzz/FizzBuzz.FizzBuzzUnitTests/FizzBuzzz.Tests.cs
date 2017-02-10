using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.FizzBuzzUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        int three = -1;
        int five = -1;

        [TestInitialize]
        void Setup()
        {
            three = 3;
            five = 5;
        }

        [TestMethod]
        public void TestFizzBuz_36_Is_Factor_Of_Three()
        {
            var FizzBuzz = new FizzBuzzConcretes.FizzBuzz(36);

            var result = FizzBuzz.IsFactorOf(three);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestFizzBuz_11_Is_Not_Factor_Of_Three()
        {
            var FizzBuzz = new FizzBuzzConcretes.FizzBuzz(11);
            var result = FizzBuzz.IsFactorOf(three);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestFizzBuz_40_Is_Factor_Of_Five()
        {
            var FizzBuzz = new FizzBuzzConcretes.FizzBuzz(40);

            var result = FizzBuzz.IsFactorOf(five);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestFizzBuz_42_Is_Not_Factor_Of_Five()
        {
            var FizzBuzz = new FizzBuzzConcretes.FizzBuzz(42);
            var result = FizzBuzz.IsFactorOf(five);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestFizzBuz_15_Is_A_Factor_Of_Five_And_Three()
        {
            var FizzBuzz = new FizzBuzzConcretes.FizzBuzz(15);
            var result = FizzBuzz.IsFactorOf(three,five);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestFizzBuz_22_Is_Not_A_Factor_Of_Five_And_Three()
        {
            var FizzBuzz = new FizzBuzzConcretes.FizzBuzz(22);

            var result = FizzBuzz.IsFactorOf(three,five);
            Assert.IsFalse(result);
        }
    }
}
