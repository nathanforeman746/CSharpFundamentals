using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello World!");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default. It will be executed if no other case is evaluated.");
                    break;
            }

            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Welcome to the beginning of a work week!");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Still working!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's the weekend!!!");
                    break;
            }

            Console.WriteLine("How are you feeling today?");
            int range = int.Parse(Console.ReadLine());

            switch (input) 
            {
                case 1:
                    Console.WriteLine("Not Feeling good.");
                    break;
                case 2:
                    Console.WriteLine("Feeling alright but still not that great.");
                    break;
                case 3:
                    Console.WriteLine("Feeling okay, could still be better.");
                    break;
                case 4:
                    Console.WriteLine("Feeling good.");
                    break;
                case 5:
                    Console.WriteLine("Feeling very confident.");
                    break;
                default:
                    Console.WriteLine("Out of range.");
                    break;
                    
            }
            Console.ReadKey();
        }
    }
}
