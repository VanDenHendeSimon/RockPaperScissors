using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Models
{
    public class Score
    {
        public int myScore { get; set; }
        public int otherScore { get; set; }

        public override string ToString()
        {
            return $"{myScore} - {otherScore}";
        }
    }
}
