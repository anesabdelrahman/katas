﻿using System.Linq;
using Katas.Strings;
using NUnit.Framework;

namespace Tests.Katas.Strings
{
    [TestFixture]
    public class KillerGarageDoorTest
    {
        private KillerGarageDoor _objectUnderTest;

        [SetUp]
        public void Setup()
        {
            _objectUnderTest = new KillerGarageDoor();
        }

        [Test]
        public void NormalOperation_ShouldOpenCompletelyAndStayOpen_Random()
        {
            var input = "P...." + new string(Enumerable.Repeat('.', 10).ToArray());
            var expected = "12345" + new string(Enumerable.Repeat('5', 10).ToArray());

            var actual = _objectUnderTest.ProcessEvents(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NormalOperation_ShouldOpenCompletelyAndStayOpenThenClose()
        {
            var actual = _objectUnderTest.ProcessEvents("P......P......");
            Assert.AreEqual("12345554321000", actual);
        }

        [Test]
        public void Pause_ShouldStartOpeningAndPauseOnSecondPress()
        {
            var actual = _objectUnderTest.ProcessEvents("P.P..");
            Assert.AreEqual("12222", actual);
        }

        [Test]
        public void Pause_ShouldResumeOpeningOnThirdPress()
        {
            var actual = _objectUnderTest.ProcessEvents("P.P.P....");
            Assert.AreEqual("122234555", actual);
        }

        [Test]
        public void Obstacle_ShouldReverseWhileOpening()
        {
            var actual = _objectUnderTest.ProcessEvents("P.O....");
            Assert.AreEqual("1210000", actual);
        }

        [Test]
        public void ObstacleAndPause_ShouldReverseWhileOpeningAndAllowPause()
        {
            var actual = _objectUnderTest.ProcessEvents("P..OP..P..");
            Assert.AreEqual("1232222100", actual);
        }

        [Test]
        public void Example_ShouldStartOpeningAndReverseWhenObstacle()
        {
            var actual = _objectUnderTest.ProcessEvents("..P...O.....");
            Assert.AreEqual("001234321000", actual);
        }
    }
}


