using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
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
            int a_char = (int)'a';

            int[] wordArr = new int[word.Length];

            for(int i=0; i<word.Length; i++)
            {
                int height = h[(int)word[i] - a_char];
                if (height > maxHeight)
                {
                    maxHeight = height;
                }
                //[key] can go in here in order to retrieve value from dictionary

            }



            return (maxHeight * word.Length); 

        }

    // Return key=value in numbers, value=occurrences of key in numbers
    // List<int> 1, 3, 3, 3, 5
    // Dict<int><int> { (1, 1), (3, 3), (5, 1) };
    // MUST use TryGetValue

    Dictionary<int,int> Histogram(IList<int> numbers)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        int count = 0;

        foreach (int value in numbers)
        {
            bool a = dictionary.TryGetValue(value, out count);

            
                dictionary.Add(value, count++);

            
        }
        foreach(var d in dictionary)
        {
            Console.Write(d.Key.ToString(), d.Value);
        }

        return dictionary; 
    }

        public int CandleCount(int[] inputArr)
        {
            int tallestCandle = inputArr[0];
            int candleCount = 0;

            foreach(int c in inputArr)
            {
                if(c>tallestCandle)
                {
                    tallestCandle = c;
                    candleCount = 1;
                    
                }
                if(c==tallestCandle)
                {
                    candleCount++;
                }

            }
            return tallestCandle;
        }
    }
}
