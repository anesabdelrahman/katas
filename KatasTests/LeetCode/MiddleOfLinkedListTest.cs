using Katas.LeetCode;
using NUnit.Framework;

namespace Tests.LeetCode
{
    [TestFixture]
    public class MiddleOfLinkedListTest
    {
        /// <summary>
        //Given the head of a singly linked list, return the middle node of the linked list.
        //    If there are two middle nodes, return the second middle node.
        //    Example 1:
        //Input: head = [1, 2, 3, 4, 5]
        //Output: [3,4,5]
        //Explanation: The middle node of the list is node 3.
        //Example 2:
        //Input: head = [1, 2, 3, 4, 5, 6]
        //Output: [4,5,6]
        //Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.
        //    Constraints:

        //The number of nodes in the list is in the range [1, 100].
        //    1 <= Node.val <= 100
         /// </summary>

         [Test]
        [TestCase(new[] {1}, new[] {1})]
        [TestCase(new[] {1, 2, 3, 4, 5}, new[] {3, 4, 5})]
        [TestCase(new[] {1, 2, 3, 4, 5, 6}, new[] {4, 5, 6})]
        public void Test(int[] input, int[] expected)
        {
            var linkedList = new LinkedList();
            var expLinkedList = new LinkedList();
            foreach (var item in input)
            {
                linkedList.Insert(item);
            }
            foreach (var item in expected)
            {
                expLinkedList.Insert(item);
            }
            var sut = new MiddleOfLinkedList();
            var result = sut.MiddleNode(linkedList);
            Assert.IsTrue(linkedList.AreNodesEqual(result, expLinkedList.Head));
        }
    }

    
}
