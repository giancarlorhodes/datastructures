using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLinkedList
{
    public class LinkedList<G>  : ICollection<G>    {

        public LinkedListNode<G> Head { get; set; }


        public LinkedListNode<G> Tail { get; set; }

        #region Add

        public void AddFirst(G inValue) {

            throw new NotImplementedException();

        }

        public void AddFirst(LinkedListNode<G> inNode)
        {
            throw new NotImplementedException();
        }


        public void AddLast(G inValue)
        {

            throw new NotImplementedException();

        }

        public void AddLast(LinkedListNode<G> inNode)
        {
            throw new NotImplementedException();
        }


        #endregion



        #region Remove


        public void RemoveFirst(G inValue)
        {

            throw new NotImplementedException();

        }

        public void RemoveFirst(LinkedListNode<G> inNode)
        {
            throw new NotImplementedException();
        }


        public void RemoveLast(G inValue)
        {

            throw new NotImplementedException();

        }

        public void RemoveLast(LinkedListNode<G> inNode)
        {
            throw new NotImplementedException();
        }


        #endregion


        #region ICollection
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(G item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(G item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(G[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<G> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(G item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion



    }
}
