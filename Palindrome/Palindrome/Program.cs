using System;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution s = new Solution();
            int x = 12321;
            int n = -121;
            int t = 10;
            //s.IsPalindrome(x);
            //s.IsPalindrome(n);
            s.IsPalindrome(t);
        }

        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                if (x < 0)
                {
                    Console.WriteLine("Your number is not a palindrome");
                    return false;
                    
                }

                string stringInput = x.ToString();
                char[] charInput = stringInput.ToCharArray();

                //char[] resultArray = new char[charInput.Length];
                char[] resultArray = stringInput.ToCharArray();
                Array.Reverse(resultArray);

                

                if (charInput.ToString() == resultArray.ToString())
                {
                    Console.WriteLine("Your input is indeed a palindrome");
                    return true;
                }
                else
                {
                    Console.WriteLine("Your input is not a palindrome");
                    return false;
                }                              
            }
        }
    }
}
