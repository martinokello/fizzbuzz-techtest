using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.FizzBuzzUnitTests
{
    [TestClass]
    public class FizzBuzzTest
    {
        int three;
        int five;

        [TestInitialize()]
        public void Setup()
        {
            three = 3;
            five = 5;
        }

        [TestMethod]
        public void TestFizzBuz_36_Is_Factor_Of_Three()
        {
            var fizzBuzz = new FizzBuzzConcretes.FizzBuzz(36);

            var result = fizzBuzz.IsFactorOf(three);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestFizzBuz_11_Is_Not_Factor_Of_Three()
        {
            var fizzBuzz = new FizzBuzzConcretes.FizzBuzz(11);
            var result = fizzBuzz.IsFactorOf(three);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestFizzBuz_40_Is_Factor_Of_Five()
        {
            var fizzBuzz = new FizzBuzzConcretes.FizzBuzz(40);

            var result = fizzBuzz.IsFactorOf(five);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestFizzBuz_42_Is_Not_Factor_Of_Five()
        {
            var fizzBuzz = new FizzBuzzConcretes.FizzBuzz(42);
            var result = fizzBuzz.IsFactorOf(five);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestFizzBuz_15_Is_A_Factor_Of_Five_And_Three()
        {
            var fizzBuzz = new FizzBuzzConcretes.FizzBuzz(15);
            var result = fizzBuzz.IsFactorOf(three,five);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestFizzBuz_22_Is_Not_A_Factor_Of_Five_And_Three()
        {
            var fizzBuzz = new FizzBuzzConcretes.FizzBuzz(22);

            var result = fizzBuzz.IsFactorOf(three,five);
            Assert.IsFalse(result);
        }
    }
}
