using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignerPdfViewer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] inputArr = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            string inputWord = "abc";
            Program p = new Program();
            int result = p.designerPdfViewer(inputArr, inputWord);
            Console.WriteLine($"The result is {result}");
        }

        public int designerPdfViewer(int[] h, string word)
        {
            //create a dictionary and put the key:value pairs AsciiCodeOfAlphabet:h in the dictionary 
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            char[] alphaArr = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] alphaAsciiArr = new int[26];

            for(int i=0; i<alphaArr.Length; i++)
            {
                alphaAsciiArr[i] = (int)alphaArr[i];
                Console.WriteLine($"alphaAsciiArr[i] is {alphaAsciiArr[i]}");
            }

            for(int i=0; i<h.Length; i++)
            {
                dictionary.Add(alphaAsciiArr[i], h[i]);
            }
            
            //now take each letter in inputted word, convert each to Ascii to get the Key to look up in the dictionary, then return the value.

            int maxHeight = 0;

            int[] wordArr = new int[word.Length];

            for(int i=0; i<word.Length; i++)
            {
                wordArr[i] = dictionary.GetValueOrDefault((int)word[i]);

            }

            maxHeight = wordArr.Max<int>();


            return (maxHeight * word.Length); 

        }
    }
}
