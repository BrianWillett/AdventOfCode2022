using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_Day_2 {
    internal class RockPaperScissors {

        Dictionary<string, int> playValues = new Dictionary<string, int>();
        Dictionary<string, string> playNames = new Dictionary<string, string>();     

        int a, x = 1; //"rock"
        int b, y = 2;//"paper"
        int c, z = 3;//"scissors";

        int win = 6;
        int tie = 3;
        int loss = 0;

        public RockPaperScissors() {
            playValues.Add("A", 1);
            playValues.Add("B", 2);
            playValues.Add("C", 3);

            playValues.Add("X", 1);
            playValues.Add("Y", 2);
            playValues.Add("Z", 3);

            playNames.Add("A", "rock");
            playNames.Add("B", "paper");
            playNames.Add("C", "scissors");

            playNames.Add("X", "rock");
            playNames.Add("Y", "paper");
            playNames.Add("Z", "scissors");
        }

        public int doRound(string plays) {
            int points = 0;
            var thePlays = plays.Split(" ");
            points += calculateWinner(playNames[thePlays[0]], playNames[thePlays[1]]);
            points += playValues[thePlays[1]];

            return points;
        }


        private int calculateWinner(string oppPlay, string myPlay) {

            string outcome = "";

            switch (myPlay) {
                case "rock":
                    if("paper" == oppPlay) {
                        outcome = "loss";
                    }else if ("scissors" == oppPlay) {
                        outcome = "win";
                    } else {
                        outcome = "tie";
                    }
                    break;
                case "scissors":
                    if ("rock" == oppPlay) {
                        outcome = "loss";
                    } else if ("paper" == oppPlay) {
                        outcome = "win";
                    } else {
                        outcome = "tie";
                    }
                    break;
                case "paper":
                    if ("scissors" == oppPlay) {
                        outcome = "loss";
                    } else if ("rock" == oppPlay) {
                        outcome = "win";
                    } else {
                        outcome = "tie";
                    }
                    break;
            }
            if ("" != outcome) {
                if ("loss" == outcome) {
                    return loss;
                } else if ("win" == outcome) {
                    return win;
                } else {
                    return tie;
                }
            } else {
                Console.WriteLine("Error happened.  My play: " + myPlay + ", Opponents Play: " + oppPlay);
                return tie;
            }
        }
    }
}
