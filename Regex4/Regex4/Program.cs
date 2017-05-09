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
"assumes word senses. Within",
"does the clustering. In the",
"but when? It was hard to tell",
"he arrive.\" After she had",
"mess! He did not let it",
"it wasn't hers!' She replied",
"always thought so.) Then",
"in the U.S.A., people often",
"John?\", he often thought, but",
            "weighed 17.5 grams",
            "well ... they'd better not",
            "A.I. has long been a very",
            "like that\", he thought",
            "but W. G. Grace never had much"};


            string pattern = @"^[a-z][a-z"'\s]*[.!?][\w"')\s]+$";
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
