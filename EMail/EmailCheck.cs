﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EMail
{
    //UC1-Validating Mandatory part abc
    //UC2-Validating Mandatory second  part @
    //UC3-Validating Mandatory third  part ensure . after bridzelabz
    ////UC4-Validating Optional part 


    class EmailCheck
    {
        string pattern = @"^[a-zA-z]{3}([\+ \- _ \.]*[a-zA-Z0-9]+)*[@][a-zA-z]+\.[a-z]{2,3}$";
        string[] inputs = {"abc.xyz@bridzelabz.co","abc123@gmail.com","abc-100@yahoo.co" ,"abc@tvs",".abc@gmail.com","abc@.com"};
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
