using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    /// <summary>
    /// AUTHOR: Giancarlo Rhoddes
    /// CREATE DATE: Jan-12-2019
    /// Hash Characteristics (SUES)
    /// STABLE - The same input generates the same output every time. 1 to 1.
    /// UNIFORM - The hash value should be uniformly distributed through the available space
    /// EFFICIENT - The cost of generating a hash must be balanced with application needs
    /// SECURE !!!!! - The cost of finding data that produces a given hash is prohibitive
    /// 
    /// This hash takes a string, char by char and get it's ASCII int and sums those integers and that will be the hash
    /// 
    ///  PROS - Stable, Efficient CONS - Not Uniform, Not Secure
    /// </summary>
    public class SimpleHash
    {
        /// <summary>
        /// This is simple hash that sums the ASCII dec values for the chars of the string
        /// </summary>
        /// <param name="inKeyUnhashed"></param>
        /// <returns></returns>
        public static int ConvertStringToHash(string inKeyUnhashed)
        {
            int _hash = 0;

            foreach (var _char in inKeyUnhashed)
            {
                // unchecked key word basically allows rapping for int so the sum may go into negative numbers
                // remember int is -2,147,483,648 to 2,147,483,647
                unchecked
                {
                    _hash += ConvertCharToInt(_char);
                }
            }

            return _hash;
        }

        /// <summary>
        /// This supports letters and digit otherwise an exception will be throw and
        /// so we need to validate that this does not happen in the UI layer
        /// </summary>
        /// <param name="inC"></param>
        /// <returns></returns>
        private static int ConvertCharToInt(char inC)
        {
            if (IsConvertable(inC))
            {
                return (int)inC;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        ///  Is this a digit or letter or not
        /// </summary>
        /// <param name="inC"></param>
        /// <returns></returns>
        private static bool IsConvertable(char inC)
        {
            return char.IsLetterOrDigit(inC);
        }

    }
}
