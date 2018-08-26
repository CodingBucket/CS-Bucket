using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class FuncDemo
    {
        static void Main(string[] args)
        {
            // Func with lamda
            Func<string, int, string> selectorFunc = (word, index) => word.ToUpper() + " " + index;
            string[] words = { "apple", "orange", "elephant", "dog" };
            var r = words.Select(selectorFunc);
            foreach (var s in r)
            {
                Console.WriteLine(s);
            }

            // Func with lamda
            Func<string, bool> checkDigit = input =>
            {
                bool isFirstCharDigit = char.IsDigit(input.First());
                return isFirstCharDigit;
            };
            List<string> list = new List<string> { "1A2.jpg", "A11B.jpg", "2.jpg", "B.jpg", "1.jpg", "A.jpg", "C.jpg" };
            List<string> list1 = list.OrderBy(s => checkDigit(s)).ThenBy(s => s).ToList();  // Output : A, A11B, B, C, 1, 1A2, 2

            // Func with function
            Func<int, int, int> sumFunc = Sum;
            var result = sumFunc(2, 3);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
