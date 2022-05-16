using System;
using System.Linq;
using PalindromeExercise;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var pali = new WordSmith();
            string result = "Anna";
            Console.WriteLine(pali.IsAPalindrome(result));
        }
    }
}
