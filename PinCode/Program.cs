using System;

namespace PinCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validating PinCode Using REGEX");
            PinCodeCheck pinCode = new PinCodeCheck();
            pinCode.ValidatingPinCode();
        }
    }
}
