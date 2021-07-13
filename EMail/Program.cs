using System;

namespace EMail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validating Email Using Regular Expression");
            EmailCheck emailCheck = new EmailCheck();
            emailCheck.ValidatingEmail();
        }
    }
}
