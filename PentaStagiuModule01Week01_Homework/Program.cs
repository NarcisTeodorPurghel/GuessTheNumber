using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaStagiuModule01Week01_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random GenerateRandom = new Random();
            int RandomNumber = GenerateRandom.Next(1, 100);
            int UserGuess;

            do
            {
                Console.WriteLine("Guess the number between (1, 100) :)");
                UserGuess = int.Parse(Console.ReadLine());

                if (UserGuess < 1 || UserGuess > 100)
                {
                    Console.WriteLine("You need to choise a number between (1, 100).");
                    continue;
                }

                if (UserGuess != RandomNumber)
                {
                    if (UserGuess > RandomNumber)
                        Console.WriteLine("Your guess was higher than the number");
                    if (UserGuess < RandomNumber)
                        Console.WriteLine("Your guess was smaller than the number");

                    Console.WriteLine("Do you want to try again? (Y/N)");
                    string UserResponse = Console.ReadLine();
                    if (UserResponse.ToUpper() == "Y")
                    {
                        continue;
                    }
                    else if (UserResponse.ToUpper() == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Undefined answer.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Congratulations!! You won! :)");
                }
            } while (UserGuess != RandomNumber);

            Console.WriteLine("The number was {0}", RandomNumber);
        }
    }
}
