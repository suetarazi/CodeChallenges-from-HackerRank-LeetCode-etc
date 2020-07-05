using System;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                string stringInput = x.ToString();
                char[] charInput = stringInput.ToCharArray();

                char[] resultArray = new char[charInput.Length];
                resultsArray = Array.Reverse(charInput);

                if (charInput == resultsArray)
                {
                    return true;
                }
                else
                    return false;
                                                
            }
        }
    }
}
