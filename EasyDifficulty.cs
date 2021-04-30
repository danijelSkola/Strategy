using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class EasyDifficulty : IDifficulty
    {
        public void PlayMove()
        {
            Console.WriteLine("Playing an easy move");
        }
    }
}
