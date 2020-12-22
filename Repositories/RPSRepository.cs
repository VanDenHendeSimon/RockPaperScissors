using RockPaperScissors.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Repositories
{
    public class RPSRepository
    {
        private static readonly Random _random = new Random();
        private static readonly List<IChoice> choices = new List<IChoice>()
        {
            new Rock(), new Paper(), new Scissors(), new Quit(), new Invalid()
        };

        public enum Outcome
        {
            win,
            loss,
            tie
        }

        public static IChoice GetChoiceFromChar(char input)
        {
            return input switch
            {
                'r' => choices[0],
                'p' => choices[1],
                's' => choices[2],
                'q' => choices[3],
                _ => choices[4],
            };
        }

        public static IChoice GetRandomChoice()
        {
            return choices[_random.Next(0, 3)];
        }

        public static Outcome GetOutcome(IChoice userChoice, IChoice randomChoice)
        {
            bool? userWon = userChoice.WinsFrom(randomChoice);
            if (userWon == null)
            {
                Console.WriteLine($"you both chose {userChoice.Name}! => It's a tie");
                return Outcome.tie;
            }

            if (Convert.ToBoolean(userWon))
            {
                Console.WriteLine($"you won! {userChoice.Name} beats {randomChoice.Name}");
                return Outcome.win;
            }
            else
            {
                Console.WriteLine($"you lose.. {randomChoice.Name} beats {userChoice.Name}");
                return Outcome.loss;
            }
        }
    }
}
