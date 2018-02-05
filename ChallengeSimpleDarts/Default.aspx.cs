using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleDarts
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PlayGameButtonClick(object sender, EventArgs e)
        {
            InitializeGame();
        }

        //checks for some correct parameters for number of players (doesn't check for non-numerical characters)
        //if parameters are valid, creates a new Game objects and calls it's Play method. Finally displays results of game.
        private void InitializeGame()
        {

            if (numberOfPlayersTextBox.Text.Trim() == "" || numberOfPlayersTextBox.Text.Trim() == "0")
            {
                gameSummaryLabel.Text = "Please enter a number greater than 0";
            }
            else if(int.Parse(numberOfPlayersTextBox.Text) > 5)
            {
                gameSummaryLabel.Text = "Maximum players is 5.";
            }
            else
            {
                Game newGame = new Game(int.Parse(numberOfPlayersTextBox.Text));
                newGame.Play();
                DisplayGameResults(newGame);
            }
        }

        private void DisplayGameResults(Game game)
        {
            gameSummaryLabel.Text = game.GetGameResults();
        }
    }
}