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
            //StreamReader sr = new StreamReader(@"D:\Magisterka\Zaawansowane programowanie obiektowe\zaj6\regex3.txt");
            string[] sr = new string[] {
"affgfking",
"rafgkahe",
"bafghk",
"baffgkit",
"baffg kit",
"fgok",
"a fgk",
"affgm",
"afffhk",
"alg.K",
"aff gm",
"afffhgk" };


            //string input;
            string pattern = @"(baf\w+\s?\w+)|(\w+k\w+)";
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);

            for (int i = 0; i < sr.Length; i++)
            {
                if (rgx.IsMatch(sr[i]))
                {
                    Console.WriteLine(sr[i]);
                }
            }
            /*
            while (sr.Peek() >= 0)
            {
                input = sr.ReadLine();
                MatchCollection matches = rgx.Matches(input);
                if (matches.Count > 0)
                {
                    Console.WriteLine("{0} ({1} matches):", input, matches.Count);
                    foreach (Match match in matches)
                        Console.WriteLine("   " + match.Value);
                }
            }
            */
            Console.ReadKey();
            //sr.Close(); 
        }
    }
}
