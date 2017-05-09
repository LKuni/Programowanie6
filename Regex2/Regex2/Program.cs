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
"rap them",
"tapeth",
"apth",
"wrap/try",
"sap tray",
"87ap9th",
"apothecary",
"aleht",
"tarpth",
            "Apt",
            "peth",
            "tarreth",
            "ddapdg",
            "apples",
            "shape the"};


            string pattern = @"(\w{3}\s\w{4})|(\w+p.t\w+)|(apt\w)";
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
