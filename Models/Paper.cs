﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Models
{
    public class Paper : IChoice
    {
        public string Name { get { return "Paper"; } }
        public bool? WinsFrom(IChoice otherChoice)
        {
            return otherChoice.Name switch
            {
                "Rock" => true,
                "Paper" => null,
                "Scissors" => false,
                _ => null
            };
        }
    }
}
