using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
    public class Score
    {
        public static int CalculateScore(int score, string scoreMultiplier)
        {
            if(scoreMultiplier == "outer-band")
            {
                return score * 2;
            }
            else if(scoreMultiplier == "inner-band")
            {
                return score * 3;
            }
            else if(scoreMultiplier == "outer-bullseye")
            {
                return 25;
            }
            else if(scoreMultiplier == "inner-bullseye")
            {
                return 50;
            }
            else
            {
                return score;
            }
        }
    }
}