using System;
using System.Dynamic;

namespace RockPaperScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello," + Name);
            string UserInput;
            string ComputerInput;
            int UserScore = 0;
            int ComputerScore = 0;

            while (UserScore < 3 && ComputerScore < 3)
            {
                Console.WriteLine("do you choose rock, paper or scissors?");
                UserInput = Console.ReadLine().ToLower();

                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 4);
                if (randomNumber == 1)
                {
                    ComputerInput = "rock";
                }
                else if (randomNumber == 2)
                {
                    ComputerInput = "paper";
                }
                else
                {
                    ComputerInput = "scissors";
                }
                if (UserInput == ComputerInput)
                {
                    Console.WriteLine($"It's a draw! The computer also chose {UserInput}");
                }
                else if (UserInput == "rock" && ComputerInput == "scissors")
                {
                    UserScore++;
                    Console.WriteLine($"You got a point! The computer chose scissors. You now have {UserScore} points and the computer has {ComputerScore} points.");
                }
                else if (UserInput == "rock" && ComputerInput == "paper")
                {
                    ComputerScore++;
                    Console.WriteLine($"you lost! the computer chose paper. you have {UserScore} points and the computer has {ComputerScore} points.");
                }
                else if (UserInput == "paper" && ComputerInput == "rock")
                {
                    UserScore++;
                    Console.WriteLine($"You got a point! The computer chose rock. You now have {UserScore} points and the computer has {ComputerScore} points.");
                }
                else if (UserInput == "paper" && ComputerInput == "scissors")
                {
                    ComputerScore++;
                    Console.WriteLine($"you lost! the computer chose scissors. you have {UserScore} points and the computer has {ComputerScore} points.");
                }
                else if (UserInput == "scissors" && ComputerInput == "paper")
                {
                    UserScore++;
                    Console.WriteLine($"You got a point! The computer chose paper. You now have {UserScore} points and the computer has {ComputerScore} points.");
                }
                else if (UserInput == "scissors" && ComputerInput == "rock")
                {
                    ComputerScore++;
                    Console.WriteLine($"you lost! the computer chose rock. you have {UserScore} points and the computer has {ComputerScore} points.");
                }
                else
                {
                    Console.WriteLine("you need to enter either rock, paper or scissors in order to play this game.");
                }
                
            }
            if(UserScore == 3)
            {
                Console.WriteLine("you won! the computer lives to fight another day.");
            }
            else
            {
                Console.WriteLine("The computer won. You live to fight another day.");
            }

        }
    }
}
