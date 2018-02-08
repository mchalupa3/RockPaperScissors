using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            int score = 0;
            int highScore = 12;

            int computerChoice;
            int userChoice;

            Console.WriteLine("welcome to Rock, Paper , Scissors!!");
            Console.WriteLine("To Choose Rock paper or scissors, type the corresponding numbers,");
            Console.WriteLine("Rock = 1 Paper = 2 Scisscors = 3");

            while (score <= highScore)
            {
                Console.WriteLine("Wins:" + score);
                Console.WriteLine("High score:" + highScore);
                Random rnd = new Random();
                userChoice = Convert.ToInt32(Console.ReadLine());
                computerChoice = rnd.Next(1, 4);
                if (userChoice == computerChoice)

                {
                    Console.WriteLine("T'Was was a Tie!");
                }
               if (userChoice == 1 && computerChoice == 3)
               {
                        Console.WriteLine("You Win!!");
                        score = score + 1;
                    }
               if (userChoice == 1 && computerChoice == 2)
                    {
                            Console.WriteLine("You Loose!");
                     }
               if (userChoice == 2 && computerChoice == 1)
                        {
                                Console.WriteLine("You Win!!");
                                score = score + 1;
                        }
               if (userChoice == 2 && computerChoice == 1)
                   {
                   Console.WriteLine("You Loose!");
                    }
               if (userChoice == 3 && computerChoice == 1)
                  {
                   Console.WriteLine("You Loose!");
                       }
                 if (userChoice == 3 && computerChoice == 2)
                 {
                 Console.WriteLine("You Win!!");
                 score = score + 1;
                 }
               if (userChoice > 4)
               {
                   Console.WriteLine("Please enter a valid number!");
               }
               else
                   Console.WriteLine("Anwer cannot be empty!");
            
   
            }
        }
    }
}
