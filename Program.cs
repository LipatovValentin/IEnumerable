using System;
using System.Collections.Generic;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            // var data = Test1(0);
            foreach (var element in Test1(1))
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
        public static IEnumerable<int> Test1(int value)
        {
            if (value == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                return Test2();
            }
        }
        public static IEnumerable<int> Test2()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }
}
