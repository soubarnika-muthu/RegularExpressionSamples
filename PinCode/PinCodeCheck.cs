using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PinCode
{
    class PinCodeCheck
    {
        string pattern = "^[0-9]{3}[ ]*[0-9]{3}$";
        string[] inputs = { "400088","A400088","400088B","400 088"};
        public void ValidatingPinCode()
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
