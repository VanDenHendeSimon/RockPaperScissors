using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Models
{
    public class Invalid : IChoice
    {
        public string Name { get { return "Invalid"; } }
        public bool? WinsFrom(IChoice otherChoice)
        {
            return true;
        }
    }
}
