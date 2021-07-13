using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EMail
{
    //UC1-Validating Mandatory part abc
    class EmailCheck
    {
        string pattern = @"^[a-zA-z]{3}[a-zA-Z0-9]*$";
        string[] inputs = {"abc","abcdf","a" ,"a1b"};
        public void ValidatingEmail()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("validating Pincodes");
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
