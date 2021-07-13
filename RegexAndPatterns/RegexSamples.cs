using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexAndPatterns
{
    class RegexSamples
    {
        string pattern = "^[0-9]*[a-zA-Z]{3,}[a-zA-Z0-9]*$";
        string[] inputs = { "111", "1aaa", "aa11", "bcc", "1a1aab", "1abb23a" };
        public void ValidatingThreeConsecutives()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("validating 3 Consecutive Samples");
            IterateLoop(inputs, regex);
        }
        public static void IterateLoop(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool result = regex.IsMatch(arr[i]);
                if (result == true)
                {
                    Console.WriteLine(arr[i] + "------->" + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + "------->" + "Invalid");
                }
            }
        }
    }
}
