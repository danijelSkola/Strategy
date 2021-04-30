using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class HardDifficulty : IDifficulty
    {
        public void PlayMove()
        {
            Console.WriteLine("Playing a hard move");
        }
    }
}
