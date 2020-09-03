using System;
using System.Collections.Generic;

namespace BonAppetit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string bonAppetit(List<int> bill, int k, int b)
        {
            //bill.ToArray();
            int billSum = 0;
                        
            foreach(int item in bill)
            {
                billSum += item;
            }
            
            int correctBill = (billSum - bill[k]) / 2;


            if(correctBill == b)
            {
                Console.WriteLine("Bon Appetit");
                return "Bon Appetit";
            }
            else
            {
                int refund = b - correctBill;
                Console.WriteLine(refund.ToString());
                return refund.ToString();
            }
        }
    }
}
