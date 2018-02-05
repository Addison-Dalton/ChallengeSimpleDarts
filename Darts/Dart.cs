using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        private Random rand;
        private int score;
        private string scoreMultiplier; //variable to hold special areas on the board where score can be multiplied

        public Dart(Random rand)
        {
            this.rand = rand;
            this.score = -1;
            this.scoreMultiplier = "none";
        }

        public void Throw()
        {
            this.score = this.rand.Next(0, 21);
            int percentage = this.rand.Next(1, 101);

            //if the bullseye isn't hit
            if(this.score != 0)
            {
                //check for outer or inner band
                if(percentage <= 5)
                {
                    this.scoreMultiplier = "outer-band";
                }
                else if(percentage > 5 && percentage <= 10)
                {
                    this.scoreMultiplier = "inner-band";
                }
            }
            else //the bullseye is hit
            {
                if(percentage <= 5)
                {
                    this.scoreMultiplier = "inner-bullseye";
                }
                else
                {
                    this.scoreMultiplier = "outer-bullseye";
                }
            }
        }

        public int getScore()
        {
            return this.score;
        }

        public string getScoreMultiplier()
        {
            return this.scoreMultiplier;
        }

        

    }
}
