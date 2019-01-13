using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {

            string _input = String.Empty;

            while (!_input.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write(">");
                _input = Console.ReadLine();

                Console.WriteLine("Simple Hash: {0}", SimpleHash.ConvertStringToHash(_input));
            }


            Console.ReadLine();
        }
    }
}
