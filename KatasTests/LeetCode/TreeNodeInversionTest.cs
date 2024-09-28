using NUnit.Framework;

namespace Tests.LeetCode
{
    [TestFixture]
    public class TreeNodeInversionTest
    {
        [Test]
        public void Test()
        {
            // Arrange: Create a tree with just one node.
            TreeNode root = new TreeNode(1);
            var sut = new TreeNodeInversion();

            // Act: Invert the tree.
            var result = sut.InvertTree(root);

            // Assert: Since it's a single node, the result should be the same node.
            Assert.AreEqual(1, result.Value);
            Assert.IsNull(result.Left);
            Assert.IsNull(result.Right);
        }

        [Test]
        public void InvertTree_TwoLevelTree_InvertsCorrectly()
        {
            // Arrange: Create a binary tree:
            //      1
            //     / \
            //    2   3
            TreeNode root = new TreeNode(1, new TreeNode(2), new TreeNode(3));

            var sut = new TreeNodeInversion();

            // Act: Invert the tree.
            var result = sut.InvertTree(root);

            // Assert: The tree should be inverted to:
            //      1
            //     / \
            //    3   2
            Assert.AreEqual(1, result.Value);
            Assert.AreEqual(3, result.Left.Value);
            Assert.AreEqual(2, result.Right.Value);
        }

        [Test]
        public void InvertTree_MoreComplexTree_InvertsCorrectly()
        {
            // Arrange: Create a more complex binary tree:
            //        1
            //       / \
            //      2   3
            //     /     \
            //    4       5
            TreeNode root = new TreeNode(1,
                new TreeNode(2, new TreeNode(4), null),
                new TreeNode(3, null, new TreeNode(5)));

            var sut = new TreeNodeInversion();

            // Act: Invert the tree.
            var result = sut.InvertTree(root);

            // Assert: The tree should be inverted to:
            //        1
            //       / \
            //      3   2
            //     /     \
            //    5       4
            Assert.AreEqual(1, result.Value);
            Assert.AreEqual(3, result.Left.Value);
            Assert.AreEqual(2, result.Right.Value);

            Assert.AreEqual(5, result.Left.Left.Value);
            Assert.IsNull(result.Left.Right);

            Assert.AreEqual(4, result.Right.Right.Value);
            Assert.IsNull(result.Right.Left);
        }

        [Test]
        public void InvertTree_CompleteBinaryTree_InvertsCorrectly()
        {
            // Arrange: Create the binary tree:
            //        4
            //      /   \
            //     2     7
            //    / \   / \
            //   1   3 6   9
            TreeNode root = new TreeNode(4,
                new TreeNode(2, new TreeNode(1), new TreeNode(3)),
                new TreeNode(7, new TreeNode(6), new TreeNode(9))
            );

            var sut = new TreeNodeInversion();

            // Act: Invert the tree.
            var result = sut.InvertTree(root);

            // Assert: The tree should be inverted to:
            //        4
            //      /   \
            //     7     2
            //    / \   / \
            //   9   6 3   1
            Assert.AreEqual(4, result.Value);
            Assert.AreEqual(7, result.Left.Value);
            Assert.AreEqual(2, result.Right.Value);

            Assert.AreEqual(9, result.Left.Left.Value);
            Assert.AreEqual(6, result.Left.Right.Value);

            Assert.AreEqual(3, result.Right.Left.Value);
            Assert.AreEqual(1, result.Right.Right.Value);
        }


        [Test]
        public void InvertTree_EmptyTree_ReturnsNull()
        {
            // Arrange: Empty tree (null root)
            TreeNode root = null;

            var sut = new TreeNodeInversion();

            // Act: Invert the tree.
            var result = sut.InvertTree(root);

            // Assert: Should return null for an empty tree.
            Assert.IsNull(result);
        }
    }

    
}
