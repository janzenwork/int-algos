using System;

namespace ConsoleApp3
{
    class Palindrome
    {

        public static void CheckPalindrome(int n)
        {
            //Check if number is palindrome

            int temp, remainder, reverse = 0;
            temp = n;

            if (temp > 0)
            {
                while (n > 0)
                {
                    remainder = n % 10;

                    reverse = reverse * 10 + remainder;
                    n /= 10;
                }

                if (temp == reverse)
                {
                    Console.WriteLine("Palindrome!");
                    Environment.Exit(0);
                }
                Console.Write("Number is " + temp + " and the reverse is " + reverse);
            }
            Environment.Exit(0);
        }
    }
}
