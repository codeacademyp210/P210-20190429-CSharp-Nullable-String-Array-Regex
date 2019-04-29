using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Lorem Ipsum is simply dummy text of the Srinting and Stypesetting Sindustry. Lorem Ipsum Shas been the industry's standard dummy text ever since the 1500s, ";
            ShowMatch(sentence, @"\bS\S*");

            Console.ReadLine();
        }

        public static void ShowMatch(string text, string pattern)
        {
            MatchCollection mc = Regex.Matches(text, pattern);

            foreach (Match item in mc)
            {
                Console.WriteLine(item);
            }
        }
    }
}
