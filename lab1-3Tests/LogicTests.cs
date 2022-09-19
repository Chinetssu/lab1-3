using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppOnlyDigit;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOnlyDigit.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void ConvertTestNormal()
        {
            var exp = "123+5-128+66";
            var result = Logic.Convert(exp);
            Assert.AreEqual(66, result);
        }

        [TestMethod()]
        public void ConvertTestZero()
        {
            var exp = "123+5-128+66-55-11+0";
            var result = Logic.Convert(exp);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void ConvertTestOnlyNegative()
        {
            var exp = "-23-37-46";
            var result = Logic.Convert(exp);
            Assert.AreEqual(-106, result);
        }

        [TestMethod()]
        public void ConvertTestBadRow()
        {
            var exp = "-23    -37 -   4 6";
            var result = Logic.Convert(exp);
            Assert.AreEqual(-106, result);
        }

        [TestMethod()]
        public void ConvertTestWorstRow()
        {
            var exp = "12 一冊 3    **   #! +5-1=2   8+ 五6 ﺞ = ﺞ6-55-11+0";
            var result = Logic.Convert(exp);
            Assert.AreEqual(0, result);
        }
    }
}