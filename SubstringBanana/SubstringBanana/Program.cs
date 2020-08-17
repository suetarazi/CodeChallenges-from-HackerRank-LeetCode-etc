using System;
using System.Collections.Generic;
using System.Linq;

namespace SubstringBanana
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            string s = "banana";
            string output = p.SubstringB(s);
            //Console.WriteLine(output); 
            
        }

    public string SubstringB(string s)
    {
        if(string.IsNullOrEmpty(s))
            {
                return null;
            }

        List<string> list = new List<string>();
            
            for (int j = 0; j < s.Length; j++)
            {
               
                for (int i=0; i <= s.Length - j; i++)
                {
                    string output = s.Substring(j, i);
                    list.Add(output);
                    Console.WriteLine(output);
                   
                }

               
            }
            list.Sort();
            Console.WriteLine(list.Last());
        return list.Last();
    }
}
}
