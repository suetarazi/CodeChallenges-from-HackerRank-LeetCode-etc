using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 15;
            Program p = new Program();
            string[] resArr = p.FizzBuzz(n);
            foreach (string s in resArr)
            {
                //Console.WriteLine(resArr.ToString());
            }
        }

        public string[] FizzBuzz(int n)
        {
            //List<string> list = new List<string>();
            string[] resArr = new string[n+1];

            for (int i = 1; i <= n; i++)
            { 
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    resArr[i] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    resArr[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    resArr[i] = "Buzz";
                }
                else
                {
                    resArr[i] = i.ToString();
                }
            }
            foreach(string s in resArr)
            {
                Console.WriteLine(s);
            }

            return resArr;
        }


    }
}
