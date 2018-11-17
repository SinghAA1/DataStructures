using NUnit.Framework;
using System;
namespace Stacks
{
    [TestFixture]
    public class StackTest
    {
        [Test]
        public void Test_Empty_Stack()
        {
            Stack<int> stack = new Stack<int>();
            Assert.Throws<StackUnderflowException>(() => stack.Pop());
        }

        [Test]
        public void Test_Basic_Stack_Implementation()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(12);
            stack.Push(23);
            Assert.AreEqual(23, stack.Pop());
            Assert.AreEqual(12, stack.Pop());
            Assert.IsTrue(stack.IsEmpty());
        }
    }
}
