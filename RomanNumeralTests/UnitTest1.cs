using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralConverter;
using System;

namespace RomanNumeralTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NumberOneWillProduceAnI()
        {
            string expected = "I";
            string actual = NumberConverter.ConvertFromNumber(1);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void NumberTwoWillProduceAnII()
        {
            string expected = "II";
            string actual = NumberConverter.ConvertFromNumber(2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NumberThreeWillProduceAnIII()
        {
            string expected = "III";
            string actual = NumberConverter.ConvertFromNumber(3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberFourWillProduceIV()
        {
            string expected = "IV";
            string actual = NumberConverter.ConvertFromNumber(4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberFiveWillProduceV()
        {
            string expected = "V";
            string actual = NumberConverter.ConvertFromNumber(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberSixWillProduceVI()
        {
            string expected = "VI";
            string actual = NumberConverter.ConvertFromNumber(6);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberSevenWillProduceVII()
        {
            string expected = "VII";
            string actual = NumberConverter.ConvertFromNumber(7);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void NumberEightWillProduceVIII()
        {
            string expected = "VIII";
            string actual = NumberConverter.ConvertFromNumber(8);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberNineWillProduceIX()
        {
            string expected = "IX";
            string actual = NumberConverter.ConvertFromNumber(9);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberTenWillProduceX()
        {
            string expected = "X";
            string actual = NumberConverter.ConvertFromNumber(10);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberElevelWillProduceXI()
        {
            string expected = "XI";
            string actual = NumberConverter.ConvertFromNumber(11);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberThirteenWillProduceXIII()
        {
            string expected = "XIII";
            string actual = NumberConverter.ConvertFromNumber(13);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberFourteenWillProduceXIV()
        {
            string expected = "XIV";
            string actual = NumberConverter.ConvertFromNumber(14);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberFifteenWillProduceXV()
        {
            string expected = "XV";
            string actual = NumberConverter.ConvertFromNumber(15);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberEighteenWillProduceXVII()
        {
            string expected = "XVIII";
            string actual = NumberConverter.ConvertFromNumber(18);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberNinteenWillProduceXIX()
        {
            string expected = "XIX";
            string actual = NumberConverter.ConvertFromNumber(19);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberTwentyWillProduceXX()
        {
            string expected = "XX";
            string actual = NumberConverter.ConvertFromNumber(20);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberThirtyTwoWillProduceXXXII()
        {
            string expected = "XXXII";
            string actual = NumberConverter.ConvertFromNumber(32);
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void NumberThirtyFourWillProduceXXXIV()
        {
            string expected = "XXXIV";
            string actual = NumberConverter.ConvertFromNumber(34);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberThirtyEightWillProduceXXXVIII()
        {
            string expected = "XXXVIII";
            string actual = NumberConverter.ConvertFromNumber(38);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberThirtyNineWillProduceXXXIX()
        {
            string expected = "XXXIX";
            string actual = NumberConverter.ConvertFromNumber(39);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NumberOver39ThrowsExecption()
        {
            NumberConverter.ConvertFromNumber(40);
        }


    }
}
