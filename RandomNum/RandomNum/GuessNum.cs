using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNum
{
    class GuessNum
    {
        int countTry;
        int numOfAttempts;
        int randomNum;
        int value;
        public GuessNum()
        {
            Console.WriteLine("Enter num of attempts:");
            countTry = Convert.ToInt32(Console.ReadLine());
            Random randomNum = new Random();
            value = randomNum.Next(0, 100);
        }
        public void IsItRight()
        {
            Console.WriteLine("Enter your num to check is it right.");
            int yourNum;
            for (int numOfAttempts = 0; numOfAttempts <= countTry; numOfAttempts++)
            {
                yourNum = Convert.ToInt32(Console.ReadLine());
                if (yourNum > value)
                {
                    Console.WriteLine("Your num is too high.Try again!\n");
                }
                else if (yourNum < value)
                {
                    Console.WriteLine("Your num is too small.Try again!\n");
                }
                else
                {
                    Console.WriteLine("You win!!");
                }

            }
        }
    }
}
