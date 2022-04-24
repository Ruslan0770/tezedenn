using System;
using System.Collections.Generic;
using System.Text;

namespace practice_friday.Models
{
    static class Extension
    {
        static bool IsEven(this int a)
        {

            if (a % 2 == 0)
            {

                return true;
            }
            else
            {
                Console.WriteLine("Eded cut deyil");
                return false;
            }
        }

        static bool IsAdd(this int b)
        {
            if (b % 2 == 0)
            {
                Console.WriteLine("Eded tek olmalidir");
                return false;
            }
            else
            {
                return true;
            }
        }

     public   static bool IsContainsDigit(this string host)
        {
            int digitCount = 0;
            foreach (char item in host)
            {
                if (char.IsDigit(item))
                {
                    digitCount++;
                }
            }

            if (digitCount > 0)
            {
                return true;
            }

            return false;
        }

        public static int[] GetValueIndexes(this int num)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            int[] arr2 = { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Array.Resize(ref arr2, arr2.Length + 1);
                    arr2[arr2.Length - 1] = i;

                }

            }
            return arr2;
        }

        public static int[] GetValueIndexes(this string avg)
        {
            string[] eas = { "salam" };
            int[] eas2 = { };
            for (int i = 0; i < eas.Length; i++)
            {
                if (eas[i]==avg)
                {
                    Array.Resize(ref eas2, eas2.Length + 1);
                    eas2[eas2.Length - 1] = i;
                }
            }
            return eas2;
        }
        
    }
}
