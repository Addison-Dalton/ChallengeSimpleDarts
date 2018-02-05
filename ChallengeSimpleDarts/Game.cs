using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Game
    {
        //num of players
        private List<Player> players;
        private Dart dart;
        private Random rand = new Random();
        private const int MAX_SCORE = 300;
        private const int MAX_DARTS_PER_TURN = 3;
        private string gameResults;

        public Game(int numOfPlayers)
        {
            this.players = new List<Player>();
            this.dart = new Dart(rand);
            for (int i = 0; i < numOfPlayers; i++)
            {
                this.players.Add(new Player("Player " + (i + 1).ToString()));
            }
        }

        public void Play()
        {
            int highestScore = 0;
            while(highestScore < MAX_SCORE) //when highest score reaches max score, stop the game.
            {
                for(int i = 0; i < players.Count; i++)
                {
                    for(int j = 0; j < MAX_DARTS_PER_TURN; j++)
                    {
                        dart.Throw();
                        players[i].Score += Score.CalculateScore(dart.getScore(), dart.getScoreMultiplier());

                        //keep track of highet score
                        if (highestScore < players[i].Score)
                        {
                            highestScore = players[i].Score;
                        }
                    }
                }
            }
        }

        public string GetGameResults()
        {
            for(int i = 0; i < players.Count; i++)
            {
                this.gameResults += String.Format("{0}: {1} <br />", players[i].Name, players[i].Score.ToString());
            }
            this.gameResults += "Winner: " + players.OrderByDescending(players => players.Score).First().Name;
            return this.gameResults;
        }
    }
}