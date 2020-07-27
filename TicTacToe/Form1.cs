using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Xwins.Text = "X:  " + s1;
            Owins.Text = "O:  " + s2;
            Draws.Text = "Draws:   " + sd;
        }

        public int player = 2; // even = X turn; odd = O turn;
        public int turns = 0; // counting turns;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;
        //counting wins for both players and draws;

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {

                    button.Text = "X";
                    player++;
                    turns++;

                }
                else
                {

                    button.Text = "0";
                    player++;
                    turns++;

                }
                if (CheckDraw() == true)
                {
                    MessageBox.Show("Tie Game!");
                    sd++;
                    NewGame();
                
                }
                if (CheckWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X Won!");
                        s1++;
                        NewGame();


                    }
                    else 
                    {
                        MessageBox.Show("O Won!");
                        s2++;
                        NewGame();
                    }
                               
                }
            }

        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void NewGame()
        {

            player = 2;
            turns = 0;
            AD0.Text = AD1.Text = AD2.Text = A11.Text = A12.Text = A13.Text = A20.Text = A21.Text = A22.Text = "";
            Xwins.Text = "X:  " + s1;
            Owins.Text = "O:  " + s2;
            Draws.Text = "Draws:   " + sd;
        }

        private void newGamebtn_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        bool CheckDraw()
        {
            if ((turns == 9) && CheckWinner()==false)
                return true;
            else
                return false;
        }

        bool CheckWinner()
        {
            //horizontal checks
            if ((AD0.Text == AD1.Text) && (AD1.Text == AD2.Text) && AD0.Text != "")
                return true;

            else if ((A11.Text == A12.Text) && (A12.Text == A13.Text) && A11.Text != "")
                return true;

            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
                return true;

            //vertical checks

            if ((AD0.Text == A11.Text) && (A11.Text == A20.Text) && AD0.Text != "")
                return true;

            else if ((AD1.Text == A12.Text) && (A12.Text == A21.Text) && AD1.Text != "")
                return true;

            else if ((AD2.Text == A13.Text) && (A13.Text == A22.Text) && AD2.Text != "")
                return true;

            //diagonal checks

            if ((AD0.Text == A12.Text) && (A12.Text == A22.Text) && AD0.Text != "")
                return true;

            else if ((AD2.Text == A12.Text) && (A12.Text == A20.Text) && AD2.Text != "")
                return true;
            else
                return false;

        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }
    }
}
