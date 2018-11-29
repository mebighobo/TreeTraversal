using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{

    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(3);
            tree.root.right = new Node(2);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            printInorder(tree.root);
            Console.WriteLine();
            //printPreOrder(tree.root);


            //Recursive 
            //printPreorder2(tree.root);
            //Console.WriteLine();
            //printInorder2(tree.root);
            //Console.WriteLine();
            //printPostorder2(tree.root);

            Console.ReadLine();


        }

        public static void printInorder(Node root)
        {
            if(root == null)
            {
                return;
            }

            Stack<Node> s = new Stack<Node>();
            Node currentNode = root;

            while (currentNode != null)
            {
                s.Push(currentNode);
                currentNode = currentNode.left;

                while(currentNode == null && s.Count > 0)
                {
                    currentNode = s.Pop();
                    Console.Write(currentNode.data + " ");
                    currentNode = currentNode.right;
                }

            }
        }

        public static void printPreOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Queue<Node> q = new Queue<Node>();
            Node currentNode = root;

            while(currentNode != null )
            {
                if (!q.Contains(currentNode))
                {
                    q.Enqueue(currentNode);
                    currentNode = currentNode.left;
                }
                else
                {
                    currentNode = currentNode.left;
                }

                while (currentNode == null && q.Count > 0)
                {

                    currentNode = q.Dequeue();
                    Console.Write(currentNode.data + " ");
                    if (currentNode.left == null)
                    {
                        currentNode = currentNode.left.right;
                    }
                }
            }
        }


        public static void printInorder2(Node node)
        {
            if (node == null)
            {
                return;
            }
            
            printPreorder2(node.left);
            Console.Write(node.data + " ");
            printPreorder2(node.right);
        }


            public static void printPreorder2(Node node)
        {
            if(node == null)
            {
                return;
            }
            Console.Write(node.data + " ");
            printPreorder2(node.left);
            printPreorder2(node.right);

        }

        public static void printPostorder2(Node node)
        {
            if (node == null)
            {
                return;
            }

            printPostorder2(node.left);
            printPostorder2(node.right);
            Console.Write(node.data + " ");
        }
    }


    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }

    public class BinaryTree
    {
        public Node root;
     
        public BinaryTree()
        {
           
        }
    }
}

