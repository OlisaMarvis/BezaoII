using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a guessing game where the user has to guess a secret number.
            //After every guess the program tells the user whether their number was too large or too small.
            //At the end the number of tries needed should be printed.
            //It counts only as one try if they input the same number multiple times consecutively.



            int number = 0, answer = 0, i = 0;

            Random rd = new Random();

            Console.WriteLine("Start Game :(Guess Number between 0 and 100)");
            answer = rd.Next(0, 100);

            while (number != answer)
            {
                Console.Write("Please guess number : ");
                number = int.Parse(Console.ReadLine());
                if (number > answer && (number - answer) > 5)
                {
                    Console.WriteLine("too big\n");

                }
                else if (number < answer && (answer - number) > 5)
                {
                    Console.WriteLine("too small\n");

                }
                else if (number != answer)
                {
                    Console.WriteLine("You are close\n");

                }

                i++;


            }
            Console.WriteLine("\nNICE ONE!, Number matched!\n\nNumber of tries : {0}", i);
            Console.ReadLine();
        }
    }
}