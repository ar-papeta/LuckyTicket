using System;
using System.Collections.Generic;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                CheckTicketLucky();
            }
           
        }

        private static void CheckTicketLucky()
        {
            int firstSum = 0;
            int secondSum = 0;
            List<char> d = new List<char>();
            Console.Write("Enter your number: ");
            string _strNum = Console.ReadLine();
            if (!IsNumCorrect(_strNum))
            {
                Console.WriteLine("Uncorect input number, try again");
                return;
            }
            if (_strNum.Length % 2 != 0)
            {
                d.Add('0');
                Console.Write("Your ticket 0" + _strNum + " is ");
            }
            else
            {
                Console.Write("Your ticket " + _strNum + " is ");
            }
            foreach (char c in _strNum)
            {
                d.Add(c);
            }
            int j = 0;
            foreach (int n in d)
            {
                if (j < (d.Count/2) )
                {
                    firstSum += n;
                }
                else
                {
                    secondSum += n;
                }
                j++;
            }
            Console.WriteLine(PrintTicketMessage(firstSum == secondSum ? true : false));
            Console.WriteLine("-------------------");
        }

        private static string PrintTicketMessage(bool isLucky)
        {
            return isLucky ? "lucky ticket !!!" : "unlucky, try again.";
        }

        private static bool IsNumCorrect(string str)
        {
            if(str.Length < 4 || str.Length > 8)
            {
                return false;
            }

            foreach(int c in str)
            {
                if (c < 0x30 || c > 0x39)
                    return false;
            }
            return true;
        }
    }
}
