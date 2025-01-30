using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_program__if_else_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if-else statement 

            Console.Write("What is your age? ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Sorry, you are not allowed to drink!");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Okay, you are allowed to enter!");
            } 

            // switch 

            /*Console.Write("What is your age? ");
            int age = int.Parse(Console.ReadLine());

            switch (age)
            {
                case 17:
                    Console.WriteLine("You are not allowed to enter!");
                    break;
                case 18:
                    Console.WriteLine("You barely made it, you can enter!");
                    break;
                case 19:
                    Console.WriteLine("Okay, okay, grandpa, you can enter!");
                    break;
                default:
                    Console.WriteLine("Unfortunetely, you can't enter ");
                    break;

            }*/


        }
    }
}
