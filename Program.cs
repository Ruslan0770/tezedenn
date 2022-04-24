using practice_friday.Models;
using System;

namespace practice_friday
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Console.WriteLine(afk.IsEven(49));


            //static bool IsContainsDigit(string host)
            //{
            //    int digitCount = 0;
            //    foreach (char item in host)
            //    {
            //        if (char.IsDigit(item))
            //        {
            //            digitCount++;
            //        }
            //    }

            //    if (digitCount > 0)
            //    {
            //        return true;
            //    }

            //    return false;
            //}

            //Console.WriteLine("Text daxil edin:");
            //string text = Console.ReadLine();
            //Console.WriteLine(IsContainsDigit(text));

            int a = 4;
          int[] arr=  Extension.GetValueIndexes(a);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
