using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHashtable
{
    [TestClass]
    public class UnitTestFoldingHash

    {
        [TestMethod]
        public void GetInteger32Froml()
        {
            // arrange
            char _l = 'l'; // 108


            // act
            int _value = Convert.ToInt32(_l);

            // assert
            Console.WriteLine(_value);
            Assert.AreEqual(108, _value);
        }

        [TestMethod]
        public void GetBinaryFroml()
        {
            // arrange
            char _l = 'l'; // 108

            // act
            int _value = Convert.ToInt32(_l);
            string _binary = Convert.ToString(_value, 2); // Base2 formatting

            // assert
            Console.WriteLine(_binary);
            Assert.AreEqual("1101100", _binary);
        }



    }
}
