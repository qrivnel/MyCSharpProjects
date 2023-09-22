using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilledNode
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Binary Tree 1
            Node root = new Node();
            Node c1 = new Node();
            Node c2 = new Node();
            Node c3 = new Node();
                                                                    
            root.left = c1;
            root.data = 5;    //FİLLED 
            root.right = c2;
            
            c1.left = null;
            c1.data = 7;      
            c1.right = null;    
            
            c2.left = c3;
            c2.data = 8;
            c2.right = null;
                                                                                                                                             
            c3.left = null;
            c3.data = 9;
            c3.right = null;
            

            //Binary Tree 2
            Node root2 = new Node();
            Node n1 = new Node();
            Node n2 = new Node();
            Node n3 = new Node();
            Node n4 = new Node();
            Node n5 = new Node();
            Node n6 = new Node();
            Node n7 = new Node();
            Node n8 = new Node();
            Node n9 = new Node();

            root2.left = n1;
            root2.data = 8;
            root2.right = n2;

            n1.left = n3;
            n1.data = 4;
            n1.right = n4;

            n2.left = n5;
            n2.data = 12;
            n2.right = n6;

            n3.data = 2;
            n3.right = n7;

            n4.data = 5;
            n4.right = n8;

            n5.data = 9;
            n5.right = n9;

            n6.data = 14;

            n7.data = 3;

            n8.data = 7;

            n9.data = 10;

            Console.WriteLine("İkili Ağaç 1\nDolu düğüm sayısı: " + FindFilledNode(root));
            Console.WriteLine();
            Console.WriteLine("İkili Ağaç 2\nDolu düğüm sayısı: " + FindFilledNode(root2));

            Console.WriteLine("Düğüm sayısı: " + GetNodeCount(root2));

            Console.WriteLine("Ağacın Yüksekliği: " + GetHeight(root2));

            PrintRootValue(root2);

            Console.Write("Yaprakların değerleri: ");

            List<int> array = LeafValues(root2);
            foreach (int arr in array)
                Console.Write(arr + " ");

            int x = 10;
            Console.Write("\n" + x + " değerli düğümün atası: ");
            PrintAncestors(root2, x);

            int y = 5;
            Console.Write("\n" + y + " değerli düğümün kardeşleri: ");
            PrintSiblingValues(root2, y);
            Console.WriteLine();
            int z = 9;
            PrintDepthAndHeight(root2, z);

            Console.ReadKey();
        }

        static int FindFilledNode(Node root)
        {
            if (root == null)
            {  // ağaç boşsa, dolu düğüm yoktur
                return 0;
            }

            // her iki alt düğüm de doluysa, bu düğümü dolu olarak say
            if (root.left != null && root.right != null)
            {
                return 1 + FindFilledNode(root.left) + FindFilledNode(root.right);
            }

            // sol ve sağ alt düğümlerin en az biri boşsa, bu düğüm dolu değildir
            return FindFilledNode(root.left) + FindFilledNode(root.right);
        }

        public static int GetNodeCount(Node root)
        {
            if (root == null)
                return 0;

            return 1 + GetNodeCount(root.left) + GetNodeCount(root.right);
        }

        public static int GetHeight(Node root)
        {
            if (root == null)
                return -1;

            int leftHeight = GetHeight(root.left);
            int rightHeight = GetHeight(root.right);

            return 1 + Math.Max(leftHeight, rightHeight);
        }

        public static void PrintRootValue(Node root)
        {
            Console.WriteLine("Kök düğümün değeri: " + root.data);
        }

        public static List<int> LeafValues(Node root)
        {
            List<int> values = new List<int>();
            LeafValuesHelper(root, values);
            return values;
        }

        public static void LeafValuesHelper(Node node, List<int> values)
        {
            if (node == null)
                return;

            if (node.left == null && node.right == null)
                values.Add(node.data);

            LeafValuesHelper(node.left, values);
            LeafValuesHelper(node.right, values);
        }
        public static void PrintAncestors(Node root, int x)
        {
            if (root == null)
                return;

            if (root.data == x)
                return;

            if ((root.left != null && root.left.data == x) ||
                (root.right != null && root.right.data == x))
            {
                Console.Write(root.data + " ");
            }

            PrintAncestors(root.left, x);
            PrintAncestors(root.right, x);
        }

        public static void PrintSiblingValues(Node root, int y)
        {
            if (root == null || root.left == null || root.right == null)
                return;

            if ((root.left.data == y && root.right != null) ||
                (root.right.data == y && root.left != null))
            {
                if (root.left.data != y)
                    Console.Write(root.left.data + " ");

                if (root.right.data != y)
                    Console.Write(root.right.data + " ");

                return;
            }

            PrintSiblingValues(root.left, y);
            PrintSiblingValues(root.right, y);
        }

        public static void PrintDepthAndHeight(Node root, int z)
        {
            if (root == null)
                return;

            if (root.data == z)
            {
                int depth = GetDepth(root, z);
                int height = GetHeight(root);

                Console.WriteLine("Düğümün derinliği: " + depth);
                Console.WriteLine("Düğümün yüksekliği: " + height);
                return;
            }

            PrintDepthAndHeight(root.left, z);
            PrintDepthAndHeight(root.right, z);
        }

        private static int GetDepth(Node root, int z)
        {
            if (root == null)
                return -1;

            if (root.data == z)
                return 0;

            int leftDepth = GetDepth(root.left, z);

            if (leftDepth != -1)
                return 1 + leftDepth;

            int rightDepth = GetDepth(root.right, z);

            if (rightDepth != -1)
                return 1 + rightDepth;

            return -1;
        }
    }
}
