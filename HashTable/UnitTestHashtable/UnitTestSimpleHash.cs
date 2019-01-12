using System;
using HashTable;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestHashing
{
    [TestClass]
    public class UnitTestSimpleHash

    {
        [TestMethod]
        public void GetHashFor_foo()
        {
            // arrange
            string _s = "foo";
            SimpleHash _h = new SimpleHash();


            // act
            int _actual = SimpleHash.ConvertStringToHash(_s);
            int _expected = 324;

            // assert
            Assert.AreEqual(_expected, _actual);
        }


        [TestMethod]
        public void GetHashFor_oof()
        {
            // arrange
            string _s = "oof";
            SimpleHash _h = new SimpleHash();


            // act
            int _actual = SimpleHash.ConvertStringToHash(_s);
            int _expected = 324;

            // assert
            Assert.AreEqual(_expected, _actual);
        }





    }
}
