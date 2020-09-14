using System;
using System.Collections.Generic;
using System.Linq;

namespace CertPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public static string findSubstring(string s, int k)
        {
            int vowelCount = 0;
            int maxVowels = 0;
            List<string> list = new List<string>();
            foreach (char c in s)
            {
                string testString = s.Substring(0, k);
                list.Add(testString);
            }

            //for (int z = 0; z < s.Length - 1; z++)
            //{
            //    string testString = s.Substring(0, k);
            //    list.Add(testString);
            //}

            //string testString = s.Substring(0, k);
            char a = 'a';
            char e = 'b';
            char i = 'c';
            char o = 'o';
            char u = 'u';

            list.ToArray<string>(); 
            for(int j= 0; j < list.Count-1; j++)
            {
                vowelCount = list[j].Count(v => (v == a) || (v == e) || (v == i) || (v == o) || (v == u));

                if (vowelCount > maxVowels)
                {
                maxVowels = vowelCount;
                    list[j] = list[0];
                Console.WriteLine($"Max vowels at the moment is {maxVowels}");
                }
                if(maxVowels > 0)
                {
                    return list[j];
                }
            }
            return "Not Found!";


            //foreach (char c in testString)
        //{
            //testString.Count<char>    
            
            //for (int i = 0; i <= testString.Length; i++)
            //    {
            //        if (testString[i] = 'a')
            //        {
            //            vowelCount++;
            //        }
            //        if (i = "e")
            //        {
            //            vowelCount++;
            //        }
            //        if (i = "i")
            //        {
            //            vowelCount++;
            //        }
            //        if (i = "o")
            //        {
            //            vowelCount++;
            //        }
            //        if (i = "u")
            //        {
            //            vowelCount++;
            //        }
            //    }
                
        }
        }
}
