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
"pit",
"spot",
"spate",
"slap two",
"respite",
"pt",
"Pot",
"peat",
"part" };

            
            string pattern = @"(\w+\s\w+)|(^s\w+)|(\w+i\w+)";
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
