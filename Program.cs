using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess what day of the week is it today using numbers one to seven.");
            int day = Convert.ToInt32(Console.ReadLine());
            bool isDay = false;


            while  (isDay ==false)
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("No, that is not today! Please try again!");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("No, that is not today! Please try again!");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("No, that is not today! Please try again!");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Yes, today is Thursday");
                        isDay = true;
                        break;
                    case 5:
                        Console.WriteLine("No, that is not today! Please try again!");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("No, that is not today! Please try again!");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("No, that is not today! Please try again!");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Please use numbers one to seven");
                        day = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            

            Console.WriteLine("Guess my year of birth!");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 1995;

            do
            {
                switch (number)
                {
                    case 1989:
                        Console.WriteLine("You guessed 1989. Try again.");
                        Console.WriteLine("Guess a year?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1992:
                        Console.WriteLine("You guessed 1992. Try again.");
                        Console.WriteLine("Guess a year?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1997:
                        Console.WriteLine("You guessed 1997. Try again.");
                        Console.WriteLine("Guess a year?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1995:
                        Console.WriteLine("You guessed 1995. That is the year I was born!");
                        isGuessed |= true;
                        break;
                    default:
                        Console.WriteLine("No, I wasnt born that year!");
                        Console.WriteLine("Guess a year?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);             
            Console.ReadLine();
        }
    }
}
