using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sr = new string[] {
"bilbo@bagend.com",
"bilbo.baggins@bagend.com",
"bilbo.baggins+hobbit@bagend.com",
"bilbo@bagend.com.pl",
"frodo@bagend.com",
"sam@bagend.com",
"theringoverthe+chimney@bagend.com"};


            string pattern = @"^[a-z][\w\d._-]*@([a-z\d]+\.){1,2}[a-z]{2,3}";
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);

            for (int i = 0; i < sr.Length; i++)
            {
                if (rgx.IsMatch(sr[i]))
                {
                    Console.WriteLine(sr[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
