using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Models
{
    public interface IChoice
    {
        public string Name { get; }
        public bool? WinsFrom(IChoice otherChoice);
    }
}
