﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void ListPlayer()
        {
            Console.WriteLine("Wellcome to 21");
            base.ListPlayer();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
