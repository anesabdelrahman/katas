using System;
using System.IO;
using Katas.Integers;
using NUnit.Framework;

namespace Tests.Katas.Integers
{
    [TestFixture]
    public class PrintingStepsTest
    {
        private PrintingSteps sut;
        private StringWriter sutWriter;
        [SetUp]
        public void Setup()
        {
            sutWriter = new StringWriter();
            Console.SetOut(sutWriter);
            sut = new PrintingSteps();
        }

        [Test]
        public void Test_OneStatement()
        {
            sut.Print(1);
            Assert.AreEqual("#\r\n", sutWriter.ToString());
        }

        [Test]
        public void Test_TwoStatement()
        {
            sut.Print(2);
            Assert.AreEqual("# \r\n##\r\n", sutWriter.ToString());
        }

        [Test]
        public void Test_ThreeStatement()
        {
            sut.Print(3);
            Assert.AreEqual("#  \r\n## \r\n###\r\n", sutWriter.ToString());
        }

        [Test]
        public void Test_FourStatement()
        {
            sut.Print(4);
            Assert.AreEqual("#   \r\n##  \r\n### \r\n####\r\n", sutWriter.ToString());
        }
    }
}
