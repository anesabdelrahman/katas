using Katas;
using NUnit.Framework;

namespace KatasTests
{
    [TestFixture]
    public class QueueWeaveTest
    {
        private QueueWeave sut;

        [SetUp]
        public void Setup()
        {
            sut = new QueueWeave();
        }

        [Test]
        public void Test_Queue_Operations()
        {
            var firstQueue = new Queue();
            firstQueue.Add(1);
            firstQueue.Add(2);
            
            Assert.AreEqual(1, firstQueue.Peek());
            Assert.AreEqual(1, firstQueue.Peek());
            Assert.AreEqual(1, firstQueue.Remove());
            Assert.AreEqual(2, firstQueue.Remove());
        }

        [Test]
        public void Test_Queues_Weaving()
        {
            var firstQueue = new Queue();
            var secondQueue = new Queue();
            
            firstQueue.Add(1);
            firstQueue.Add(2);
            firstQueue.Add(3);
            firstQueue.Add(4);
            secondQueue.Add("One");
            secondQueue.Add("Two");
            secondQueue.Add("Three");
            secondQueue.Add("Four");

            var result = sut.Weave(firstQueue, secondQueue);

            Assert.AreEqual(1, result.Remove());
            Assert.AreEqual("One", result.Remove());
            Assert.AreEqual(2, result.Remove());
            Assert.AreEqual("Two", result.Remove());
            Assert.AreEqual(3, result.Remove());
            Assert.AreEqual("Three", result.Remove());
            Assert.AreEqual(4, result.Remove());
            Assert.AreEqual("Four", result.Remove());
            Assert.AreEqual(null, result.Remove());
        }
    }
}
