namespace StacksAndQueuesTest
{
    [TestClass]
    public class UnitTestQueue
    {
        [TestMethod]
        public void TestEnqueueIncreasesCount()
        {
            // Arrange
            IQueue<int> queue = new MyQueue<int>();

            // Action
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Assert
            Assert.AreEqual(queue.Count, 3);
        }

        [TestMethod]
        public void TestDequeueDecreasesCount()
        {
            // Arrange
            IQueue<int> queue = new MyQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Action
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            // Assert
            Assert.AreEqual(queue.Count, 0);
        }

        [TestMethod]
        public void TestPeekShowsFirstItemWithoutRemoval()
        {
            // Arrange
            IQueue<int> queue = new MyQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Action
            var p = queue.Peek();

            // Assert
            Assert.AreEqual(p, 1);
            Assert.AreEqual(queue.Count, 3);
        }

        [TestMethod]
        public void TestDequeueRemovesFirstItem()
        {
            // Arrange
            IQueue<int> queue = new MyQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Action
            var p = queue.Dequeue();

            // Assert
            Assert.AreEqual(p, 1);
            Assert.AreEqual(queue.Count, 2);
        }

        [TestMethod]
        public void TestDequeueRemovesAllItems()
        {
            // Arrange
            IQueue<int> queue = new MyQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(2);

            // Action
            var p1 = queue.Dequeue();
            var p2 = queue.Dequeue();
            var p3 = queue.Dequeue();
            var p4 = queue.Dequeue();

            // Assert
            Assert.AreEqual(p1, 1);
            Assert.AreEqual(p2, 2);
            Assert.AreEqual(p3, 3);
            Assert.AreEqual(p4, 2);
            Assert.AreEqual(queue.Count, 0);
        }
    }
}