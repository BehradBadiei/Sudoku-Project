using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Rock_paper_scissors : Form
    {

        int rounds = 3;
        int timerPerRound = 6;
        bool gameOver = false;

        string[] CPUpickList = { "rock", "paper", "scissors", "paper", "rock", "scissors" };

        int randomNumber = 0;

        Random rnd = new Random();

        string CPUPick;

        string playerPick;

        int playerScore;
        int CPUScore;
        public Rock_paper_scissors()
        {
            InitializeComponent();

            CountdownTimer.Enabled = true;

            playerPick = "none";

            textCountdown.Text = "5";

        }

        private void Rock_btn_Click(object sender, EventArgs e)
        {
            Player_pick.Image = Properties.Resources.rock;
            playerPick = "rock";
        }

        private void Paper_btn_Click(object sender, EventArgs e)
        {
            Player_pick.Image = Properties.Resources.paper;
            playerPick = "paper";
        }

        private void Scissors_btn_Click(object sender, EventArgs e)
        {
            Player_pick.Image = Properties.Resources.scissors;
            playerPick = "scissors";
        }

        private void Restart_btn_Click(object sender, EventArgs e)
        {

            playerScore = 0;
            CPUScore = 0;
            rounds = 3;
            textScore.Text = $"Player: {playerScore} - CPU: {CPUScore}";


            playerPick = "none";
            textCountdown.Text = "5";

            CountdownTimer.Enabled = true;

            Player_pick.Image = Properties.Resources.qq;
            Cpu_pick.Image = Properties.Resources.qq;

            gameOver = false;



        }

        private void CountDownTimer_Event(object sender, EventArgs e)
        {
            timerPerRound -= 1;

            textCountdown.Text = timerPerRound.ToString();

            textRound.Text = "Rounds:" + rounds;

            if (timerPerRound == 0)
            {
                CountdownTimer.Enabled = false;

                timerPerRound = 6;

                randomNumber = rnd.Next(0, CPUpickList.Length);

                CPUPick = CPUpickList[randomNumber];


                switch (CPUPick)
                {

                    case "rock":
                        Cpu_pick.Image = Properties.Resources.rock;

                        break;
                    case "paper":
                        Cpu_pick.Image = Properties.Resources.paper;

                        break;
                    case "scissors":
                        Cpu_pick.Image = Properties.Resources.scissors;

                        break;
                }

                if (rounds > 0)
                {
                    checkGame();
                }
                else if(rounds == 0)
                {
                    if (playerScore > CPUScore)
                    {
                        MessageBox.Show("You win, winner winner chicken dinner!");
                    }
                    else
                    {
                        MessageBox.Show("CPU won,try again maybe?");
                    }

                    gameOver = true;
                }
            }


        }

        private void checkGame()
        {

            if (playerPick == "rock" && CPUPick == "paper")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU wins this round, Paper covers rock");
            }
            else if (playerPick == "scissors" && CPUPick == "rock")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU wins this round, Rock breaks the scissors");
            }
            else if (playerPick == "paper" && CPUPick == "scissors")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU wins this round, scissors cuts the paper");
            }
            else if (playerPick == "paper" && CPUPick == "rock")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("You win this round, Paper covers rock");
            }
            else if (playerPick == "rock" && CPUPick == "scissors")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("You win this round, Rock breaks the scissors");
            }
            else if (playerPick == "scissors" && CPUPick == "paper")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("You win this round, scissors cuts the paper");
            }
            else if (playerPick == "none")
            {


                MessageBox.Show("Please make a choice");
            }
            else
            {
                MessageBox.Show("DRAW!!!");
            }


            NextRound();
        }

        private void NextRound()
        {
            if (gameOver)
            {
                return;
            }

            textScore.Text = $"Player: {playerScore} - CPU: {CPUScore}";


            playerPick = "none";

            CountdownTimer.Enabled = true;

            Player_pick.Image = Properties.Resources.qq;
            Cpu_pick.Image = Properties.Resources.qq;


        }
    }
}