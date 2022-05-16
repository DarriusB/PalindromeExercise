using System;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {
        }

        public bool IsAPalindrome(string text)
        {
            var result = text.ToLower();
            return result.SequenceEqual(result.Reverse());

            //throw new NotImplementedException();
        }
    }
}
