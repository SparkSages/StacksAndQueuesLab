namespace StacksAndQueuesTest
{
    [TestClass]
    public class UnitTestStack
    {

        [TestMethod]
        public void TestPushIncreasesCount()
        {
            // Arrange
            IStack<int> stack = new MyStack<int>();

            // Action
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Assert
            Assert.AreEqual(stack.Count, 3);
        }

        [TestMethod]
        public void TestPopDecreasesCount()
        {
            // Arrange
            IStack<int> stack = new MyStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Action
            stack.Pop();
            stack.Pop();
            stack.Pop();

            // Assert
            Assert.AreEqual(stack.Count, 0);
        }

        [TestMethod]
        public void TestPeekShowsTopItemWithoutRemoval()
        {
            // Arrange
            IStack<int> stack = new MyStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Action
            var p = stack.Peek();

            // Assert
            Assert.AreEqual(p, 3);
            Assert.AreEqual(stack.Count, 3);
        }

        [TestMethod]
        public void TestPopRemovesLastItem()
        {
            // Arrange
            IStack<int> stack = new MyStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(2);

            // Action
            var p = stack.Pop();

            // Assert
            Assert.AreEqual(p, 2);
            Assert.AreEqual(stack.Count, 3);
        }

        [TestMethod]
        public void TestPopRemovesAllItems()
        {
            // Arrange
            IStack<int> stack = new MyStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(2);

            // Action
            var p4 = stack.Pop();
            var p3 = stack.Pop();
            var p2 = stack.Pop();
            var p1 = stack.Pop();

            // Assert
            Assert.AreEqual(p4, 2);
            Assert.AreEqual(p3, 3);
            Assert.AreEqual(p2, 2);
            Assert.AreEqual(p1, 1);
            Assert.AreEqual(0, stack.Count);
        }
    }
}