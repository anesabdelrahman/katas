﻿using System;
using System.IO;
using Katas;
using NUnit.Framework;

namespace KatasTests.Katas
{
    [TestFixture]
    public class PrintingPyramidTest
    {
        private PrintingPyramid sut;
        private StringWriter sutWriter;
        [SetUp]
        public void Setup()
        {
            sutWriter = new StringWriter();
            Console.SetOut(sutWriter);
            sut = new PrintingPyramid();
        }

        [Test]
        public void Test_OnePyramid()
        {
            sut.Print(1);
            Assert.AreEqual("#\r\n", sutWriter.ToString());
        }

        [Test]
        public void Test_TwoPyramids()
        {
            sut.Print(2);
            Assert.AreEqual(" # \r\n###\r\n", sutWriter.ToString());
        }

        [Test]
        public void Test_ThreePyramids()
        {
            sut.Print(3);
            Assert.AreEqual("  #  \r\n ### \r\n#####\r\n", sutWriter.ToString());
        }

        [Test]
        public void Test_FourPyramids()
        {
            sut.Print(4);
            Assert.AreEqual("   #   \r\n  ###  \r\n ##### \r\n#######\r\n", sutWriter.ToString());
        }
    }
}
