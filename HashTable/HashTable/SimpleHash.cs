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
    /// STABLE - The same input generates the same output every time
    /// UNIFORM - The hash value should be uniformly distributed through the available space
    /// EFFICIENT - The cost of generating a hash must be balanced with application needs
    /// SECURE !!!!! - The cost of finding data that produces a given hash is prohibitive
    /// 
    /// This hash takes a string, char by char and get it's ASCII int and sums those integers and that will be the hash
    /// </summary>
    public class SimpleHash
    {

        public static int ConvertStringToHash(string inString)
        {

            int _hash = 0;

            foreach (var _char in inString)
            {
                _hash += ConvertCharToInt(_char);
            }

            return _hash;
        }

        private static int ConvertCharToInt(char inC)
        {
            if (IsConvertable(inC))
            {
                return (int)inC;
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        private static bool IsConvertable(char inC)
        {
            return char.IsLetterOrDigit(inC);
        }
    }
}
