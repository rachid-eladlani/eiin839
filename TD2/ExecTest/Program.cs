using System;

namespace ExeTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                Console.WriteLine("<HTML><BODY> Hello " + args[0] + " " + args[1] + "</BODY></HTML>");
            }
            else
                Console.WriteLine("ExeTest  ");
        }
    }
}