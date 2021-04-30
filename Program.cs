using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IDifficulty Easy = new EasyDifficulty();
            IDifficulty Normal = new NormalDifficulty();
            IDifficulty Hard = new HardDifficulty();

            IDifficulty SelectedDiff = new NullDifficulty();

            int input = 17;

            switch(input)
            {
                case 1:
                    SelectedDiff = Easy;
                    break;
                case 2:
                    SelectedDiff = Normal;
                    break;
                case 3:
                    SelectedDiff = Hard;
                    break;
                default:
                    break;

            }



            SelectedDiff.PlayMove();



        }
    }
}
