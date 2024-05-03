using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsSim
{
    class Game
    {
        public string User { get; set; }
        public string AI { get; set; }

        public Game(string userMove)
        {
            User = userMove;
            GenAImove();
        }

        public Game()
        {
            User = "";
            AI = "";
        }

        //gernerate AI move
        public void GenAImove()
        {
            int num = number();
            if (num == 0)
            { AI = "R"; }
            else if (num == 1)
            { AI = "P"; }
            else if (num == 2)
            { AI = "S"; }
            else { AI = string.Empty; }
        }

        //AI number for move
        public int number()
        {
            Random rnd = new Random();
            return rnd.Next(0, 3);
        }

        //assign value to result
        public int determineWinner()
        {
            int result = 3; //0=draw; 1=userwin; 2=AIwin

            if (User == AI)
            {
                result = 0;
            }
            //user paper
            else if (User == "P")
            {
                if (AI == "R")
                { result = 1; }
                else
                { result = 2; }
            }
            //user scissors
            else if (User == "S")
            {
                if (AI == "P")
                { result = 1; }
                else
                { result = 2; }
            }
            //user rock
            else if (User == "R")
            {
                if (AI == "S")
                { result = 1; }
                else
                { result = 2; }
            }
            return result;
        }

        public string results()
        {
            int result = determineWinner();
            string outcome;

            Console.WriteLine($"Your move:  {User}");
            Console.WriteLine($"Opponent move:  {AI}");

            if (result == 0)
            {
                outcome = "DRAW";
                return outcome;
            }
            else if (result == 1)
            {
                outcome = "YOU WIN";
                return outcome;
            }
            else
            {
                outcome = "YOU LOSE";
                return outcome;
            }
        }
    }
}

