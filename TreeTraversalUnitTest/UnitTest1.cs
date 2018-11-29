using NUnit.Framework;
using System;
using System.IO;
using TreeTraversal;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test_PrintInOrder()
        {

            using (StringWriter sw = new StringWriter())
            {
               
                string test = "4 3 5 1 2 ";
                //Arrange 
                var tree = new BinaryTree();
                tree.root = new Node(1);
                tree.root.left = new Node(3);
                tree.root.right = new Node(2);
                tree.root.left.left = new Node(4);
                tree.root.left.right = new Node(5);
                //Act
                Console.SetOut(sw);
                Program.printInorder(tree.root);
                //Assert
                Assert.AreEqual(test,sw.ToString());
            }
        }
    }
}