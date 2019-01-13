using System;
using HashTable;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHashtable
{

    [TestClass]
    public class UnitTestSimpleHashTable
    {


        [TestMethod]
        public void Modulus_100_10() {

            //arrange
            string[] _array = new string[10];

            // act
            int _actual = 100 % _array.Length;
            int _expected = 0;


            //assert
            Console.WriteLine(_actual);
            Assert.AreEqual(_expected, _actual);


        }



        [TestMethod]
        public void Modulus_201_10()
        {

            //arrange
            string[] _array = new string[10];

            // act
            int _actual = 201 % _array.Length;
            int _expected = 1;


            //assert
            Console.WriteLine(_actual);
            Assert.AreEqual(_expected, _actual);


        }



        [TestMethod]
        public void Modulus_2034531_10()
        {

            //arrange
            string[] _array = new string[10];

            // act
            int _actual = 2034531 % _array.Length;
            int _expected = 1;


            //assert
            Console.WriteLine(_actual);
            Assert.AreEqual(_expected, _actual);

        }



        [TestMethod]
        public void Modulus_2034535438_10()
        {

            //arrange
            string[] _array = new string[10];

            // act
            int _actual = 2034535438 % _array.Length;
            int _expected = 8;


            //assert
            Console.WriteLine(_actual);
            Assert.AreEqual(_expected, _actual);

        }



        [TestMethod]
        public void AddNodeAndFindValue()
        {

            //arrange
            SimpleHashTable _table = new SimpleHashTable();
            _table.Add("foo");
            
            // act
            bool _actual = _table.Find("foo"); 
            bool _expected = true;


            //assert
            Assert.AreEqual(_expected, _actual);

        }



    }
}
