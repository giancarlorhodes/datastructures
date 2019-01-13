using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{

    /// <summary>
    /// AUTHOR: Giancarlo Rhodes
    /// DATE: Jan-12-2019
    /// Uses simple hash algorithm
    /// </summary>
    public class SimpleHashTable
    {
        // array of LinkedLists 
        // the LinkedlLists takes care of the collision issue with straight array
        public LinkedList<string>[] _hashArray;

         
        public SimpleHashTable()
        {
            _hashArray = new LinkedList<string>[10];
                
            for (int i = 0; i < _hashArray.Length; i++)
            {
                LinkedList<string> _newLinkedList = new LinkedList<string>();
                _hashArray[i] = _newLinkedList;
            }

        }


        /// <summary>
        /// Adds a node to the linked list
        /// </summary>
        /// <param name="inUnhashedKey"></param>
        /// <returns></returns>
        public int Add(string inKeyUnhashed)
        {
            int _hash, _index;
            HashAndIndex(inKeyUnhashed, out _hash, out _index);

            // need to account for collisions
            if (_hashArray[_index].First == null)
            {
                _hashArray[_index].AddFirst(_hash.ToString());
            }
            else
            {

                _hashArray[_index].AddLast(_hash.ToString());
            }
            return _index;
        }

        /// <summary>
        /// Hash and index the string passed in
        /// </summary>
        /// <param name="inKeyUnhashed"></param>
        /// <param name="_hash"></param>
        /// <param name="_index"></param>
        private void HashAndIndex(string inKeyUnhashed, out int _hash, out int _index)
        {
            _hash = SimpleHash.ConvertStringToHash(inKeyUnhashed);
            _index = _hash % _hashArray.Length;
        }



        /// <summary>
        ///  Removes a node from the linked list
        /// </summary>
        /// <param name="inKeyUnhashed"></param>
        /// <returns></returns>
        public bool Remove(string inKeyUnhashed) {

            int _hash, _index;
            HashAndIndex(inKeyUnhashed, out _hash, out _index);
            bool _isRemoved = false;

            try
            {

                if (_hashArray[_index].Find(_hash.ToString()) != null)
                {
                    _hashArray[_index].Remove(_hash.ToString());
                    _isRemoved = true;
                }
                else {

                    _isRemoved = false;
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }
            finally {
                _isRemoved = false;
            }
            return _isRemoved;
        }

        /// <summary>
        ///  Search the Linked lists bases on index and the key passed in and return true or false
        /// </summary>
        /// <param name="inKeyUnhashed"></param>
        /// <returns></returns>
        public bool Find(string inKeyUnhashed) {

            int _hash, _index;
            HashAndIndex(inKeyUnhashed, out _hash, out _index);
            bool _isFound = false;

            _isFound =  _hashArray[_index].Find(_hash.ToString()) != null ? true : false;

            return _isFound;
        }
    }


}