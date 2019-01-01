using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLinkedList
{
    public class LinkedListNode<G>
    {

        public G Value { get; set; }

        public LinkedListNode(G inValue)
        {

            Value = inValue;

        }

        public LinkedListNode<G> Next { get; set; }


    }
}
