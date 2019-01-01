using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    class Program
    {
        static void Main(string[] args)
        {

            // +----------+----------+
            // |    3     |    null  + 
            // +----------|----------+
            Node first = new Node { Value = 3 };
            //PrintNode(first);

            // +----------+----------+      +----------+----------+
            // |    3     |    null  +      |    6     |    null  + 
            // +----------|----------+      +----------|----------+
            Node second = new Node { Value = 6 };

            // +----------+----------+      +----------+----------+
            // |    3     |    *-----+----->|    6     |    null  + 
            // +----------|----------+      +----------|----------+
            first.Next = second;
            //PrintNode(second);


            // +----------+----------+      +----------+----------+     +----------+----------+
            // |    3     |    *-----+----->|    6     |    null  +     |    9     |    null  +  
            // +----------|----------+      +----------|----------+     +----------|----------+
            Node third = new Node { Value = 9 };

            // +----------+----------+      +----------+----------+     +----------+----------+
            // |    3     |    *-----+----->|    6     |     *----+---->|    9     |    null  +  
            // +----------|----------+      +----------|----------+     +----------|----------+
            second.Next = third;
            //PrintNode(third);

            PrintAllNodes(first);

            Console.ReadKey();
        }

        private static void PrintAllNodes(Node inNode) {

            while (inNode != null)
            {
                PrintNode(inNode);
                inNode = inNode.Next;
            }

        }


        static void PrintNode(Node inNode)
        {

            Console.WriteLine("Node value is: " + inNode.Value);            
            Console.WriteLine();
        }

        /// <summary>
        /// 
        /// </summary>
        private class NodeList
        {

            public Node[] ListOfNodes { get; set; }





        }

        private class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }


            public Node() { }

            public Node(int inValue)
            {
                Value = inValue;
            }


            public Node(int inValue, Node inNode) : this(inValue)
            {
                Next = inNode;
            }

        }


    }


    

}
