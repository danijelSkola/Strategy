using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class NullDifficulty : IDifficulty
    {
        public void PlayMove()
        {
            Console.Write("Not playing, no difficulty selected");
        }
    }
}
