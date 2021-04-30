using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class NormalDifficulty : IDifficulty
    {
        public void PlayMove()
        {
            Console.WriteLine("Playing a normal move");
        }
    }
}
