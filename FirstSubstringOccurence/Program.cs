using System;

namespace FirstSubstringOccurence
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "CodefightsIsAwesome";
            string x = "IA"; // the output should be strstr(s, x) = -1;
            string y = "IsA"; // the output should be strstr(s, x) = 10

            var check = new SubstringFinder();
            var findSubstring = check.findFirstSubstringOccurrence(s, x);
            var findSecSubstring = check.findFirstSubstringOccurrence(s, y);

            Console.WriteLine(findSubstring);
            Console.WriteLine(findSecSubstring);
            Console.Read();  
        }
    }
}
