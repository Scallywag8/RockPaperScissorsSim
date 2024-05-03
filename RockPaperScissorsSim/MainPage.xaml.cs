using System.Collections.ObjectModel;
using System.ComponentModel;
using Windows.Gaming.Preview;

namespace RockPaperScissorsSim
{
    public partial class MainPage : ContentPage
    {
        Game g;
        StatsList lst;

        public MainPage()
        {
            InitializeComponent();

            g = new Game();
            lst = new StatsList();
            BindingContext = lst;
        }

        private void RockBtn(object sender, EventArgs e)
        {
            g = new Game("R");
            result.Text = g.results();

            //change AI move on label
            if (result.Text == "YOU WIN")
            {
                AI.Text = "Scissors";
                
            }
            else if (result.Text == "DRAW")
            {
                AI.Text = "Rock";
            }
            else
            {
                AI.Text = "Paper";
            }
        }

        private void PapBtn(object sender, EventArgs e)
        {
            g = new Game("P");
            result.Text = g.results();
            if (result.Text == "YOU WIN")
            {
                AI.Text = "Rock";
            }
            else if (result.Text == "DRAW")
            {
                AI.Text = "Paper";
            }
            else
            {
                AI.Text = "Scissors";
            }

        }

        private void ScisBtn(object sender, EventArgs e)
        {
            g = new Game("S");
            result.Text = g.results();


            if (result.Text == "YOU WIN")
            {
                AI.Text = "Paper";
            }
            else if (result.Text == "DRAW")
            {
                AI.Text = "Scissors";
            }
            else
            {
                AI.Text = "Rock";
            }

        }


        public class StatsList
        {
            private string _name;
            private int _games;
            private int _wins;
            private int _losses;
            private int _playedR;
            private int _playedP;
            private int _playedS;

            public StatsList()
            {
                Name = "---";
                Games = 0;
                Wins = 0;
                Losses = 0;
                PlayedR = 0;
                PlayedP = 0;
                PlayedS = 0;

            }
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public int Games
            {
                get { return _games; }
                set { _games = value; }
            }
            public int Wins
            {
                get { return _wins; }
                set { _wins = value; }
            }

            public int Losses
            {
                get { return _losses; }
                set { _losses = value; }
            }

            public int PlayedR
            {
                get { return _playedR; }
                set { _playedR = value; }
            }

            public int PlayedP
            {
                get { return _playedP; }
                set { _playedP = value; }
            }

            public int PlayedS
            {
                get { return _playedS; }
                set { _playedS = value; }
            }
        }
    }

}


