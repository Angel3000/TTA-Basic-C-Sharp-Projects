﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
       public Suit Suit { get; set; }
       public Face Face { get; set; }
    }
    public enum Suit
    {
        Clubs,
        Hearts,
        Spades,
        Diamonds
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eigth,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
