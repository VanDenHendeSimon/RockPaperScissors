using RockPaperScissors.Models;
using RockPaperScissors.Repositories;
using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Score score = new Score();
            while (true)
            {
                Console.WriteLine("\nRock [r] Paper [p] Scissors [s] Quit [q]");
                string userInput = Console.ReadLine();

                try
                {
                    char userChar = Convert.ToChar(userInput);
                    IChoice userChoice = RPSRepository.GetChoiceFromChar(userChar);

                    if (userChoice.Name.Equals("Quit")) break;
                    if (userChoice.Name.Equals("Invalid")) continue;

                    IChoice randomChoice = RPSRepository.GetRandomChoice();
                    RPSRepository.Outcome outcome = RPSRepository.GetOutcome(userChoice, randomChoice);

                    if (outcome.Equals(RPSRepository.Outcome.loss)) score.otherScore++;
                    if (outcome.Equals(RPSRepository.Outcome.win)) score.myScore++;

                    Console.WriteLine(score);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input");
                }

            }
        }
    }
}
