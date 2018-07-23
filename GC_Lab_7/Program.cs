using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GC_Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write your name");
            string input = Console.ReadLine();
            while (!(Regex.IsMatch(input, @"^[A-Z]{1}[a-z]{1,14}\s[A-Z]{1}[a-z]{1,14}$")))
            {
                Console.WriteLine("Put in the right stuff");
                input = Console.ReadLine();

            }
            Console.WriteLine("What's your email");
            input = Console.ReadLine();
            while (!(Regex.IsMatch(input, @"^.{5,30}[@]{1}[a-z]{5,10}[.][a-z]{2,3}$")))
            {
                Console.WriteLine("Put in the right stuff");
                input = Console.ReadLine();

            }
            Console.WriteLine("What's your number?");
            input = Console.ReadLine();
            while (!(Regex.IsMatch(input, @"^\d{3}-\d{3}-\d{4}$")))
            {
                Console.WriteLine("Put in the right stuff");
                input = Console.ReadLine();

            }
            Console.WriteLine("Enter an date"); 
            input = Console.ReadLine();
            while (!(Regex.IsMatch(input, @"^\d{2}[/]\d{2}[/]\d{4}$")))
            {
                Console.WriteLine("Put in the right stuff");
                input = Console.ReadLine();

            }
            Console.WriteLine("Enter an html tag ");
            input = Console.ReadLine();
            while (!(Regex.IsMatch(input, @"^<.{1,10}>.{0,10000}<[/].{1,10}>$")))
            {
                Console.WriteLine("Put in the right stuff");
                input = Console.ReadLine();

            }
        }

    }
}
