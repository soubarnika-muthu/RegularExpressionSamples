using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EMail
{
    //UC1-Validating Mandatory part abc
    //UC2-Validating Mandatory second  part @

    class EmailCheck
    {
        string pattern = @"^[a-zA-z]{3}[a-zA-Z0-9]*[@][a-zA-z]+$";
        string[] inputs = {"abc@bridzelabz","abc@0mail","abc" ,"a@tvs"};
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
