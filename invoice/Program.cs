
using System;
using System.Globalization;
using System.Threading;
//using RomanNumerals;

namespace invoice
{
    class Program
    {
        static void Main (string[] args)
        {
            int counter = 10983;
            CultureInfo bhs = new CultureInfo("en-US"); 
            Thread.CurrentThread.CurrentCulture = bhs;
            var date = DateTime.Now.AddDays(3);
            var month = date.ToString("yyyyMM");
            var day = date.ToString("ddd");
            var hari = day.Substring(0, 2);
            var dayNum = date.Day;
            counter++;
            Console.Write($"INV/{month}/{hari}/");
            BilRoman(dayNum);
            Console.Write("/");
            BilRoman(Convert.ToInt32(DateTime.Now.ToString("yy")));
            Console.Write("/"+counter);
        }
        static void BilRoman(int bil)
        {
            bil = Convert.ToInt32(bil);
            while (bil >= 1000)
            {
                bil = bil - 1000;
                Console.Write("M");
            }
            while (bil >= 500)
            {
                if (bil >= 900)
                {
                    bil = bil - 900;
                    Console.Write("CM");
                }
                else
                {
                    bil = bil - 500;
                    Console.Write("D");
                }

            }
            while (bil >= 100)
            {
                if (bil >= 400)
                {
                    bil = bil - 400;
                    Console.Write("CD");
                }
                else
                {

                    bil = bil - 100;
                    Console.Write("C");
                }

            }
            while (bil >= 50)
            {
                if (bil >= 90)
                {
                    bil = bil - 90;
                    Console.Write("XC");
                }
                else
                {
                    bil = bil - 50;
                    Console.Write("L");
                }
            }
            while (bil >= 10)
            {
                if (bil >= 40)
                {
                    bil = bil - 40;
                    Console.Write("XL");
                }
                else
                {
                    bil = bil - 10;
                    Console.Write("X");
                }
            }
            while (bil >= 5)
            {
                if (bil == 9)
                {
                    bil = bil - 9;
                    Console.Write("IX");
                }
                else
                {
                    bil = bil - 5;
                    Console.Write("V");
                }

            }
            while (bil >= 1)
            {
                if (bil == 4)
                {
                    bil = bil - 4;
                    Console.Write("IV");
                }
                else
                {
                    bil = bil - 1;
                    Console.Write("I");
                }
            }
        }
    }
}
