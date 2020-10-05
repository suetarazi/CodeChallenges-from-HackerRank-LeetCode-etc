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
        }

        public int designerPdfViewer(int[] h, string word)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach(int i in h)
            {
                dictionary.Add(h[i], h[i]);
            }
            


            int maxHeight = 0;

            int[] wordArr = new int[word.Length];

            for(int i=0; i<word.Length; i++)
            {
                wordArr[i] = dictionary.;
            }

            maxHeight = wordArr.Max<int>();


            return (maxHeight * word.Length); 

        }
    }
}
