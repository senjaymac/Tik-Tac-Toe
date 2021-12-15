using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTacToe_App
{
    public partial class TikTakToeF1 : Form
    {
        bool Player_Turn = true;
        SoundPlayer ClickSoundFxPop = new SoundPlayer(@"C:\Users\Senon\Documents\Repositories\TikTacToe App\TikTacToe App\Properties\PopFx.wav");

        public TikTakToeF1()
        {
            InitializeComponent();
        }

        private void LabelTikTakToe_Click(object sender, EventArgs e)
        {

        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.The game is played on a grid that's 3 squares by 3 squares. \n2.You are X, your friend(or the computer in this case) is O.Players take turns putting their marks in empty squares. \n3.The first player to get 3 of her marks in a row(up, down, across, or diagonally) is the winner. \n4.When all 9 squares are full, the game is over.If no player has 3 marks in a row, the game ends in a tie.");
        }

        public void BtnFalse()
        {
            BtnB1.Enabled = false;
            BtnB2.Enabled = false;
            BtnB3.Enabled = false;
            BtnB4.Enabled = false;
            BtnB5.Enabled = false;
            BtnB6.Enabled = false;
            BtnB7.Enabled = false;
            BtnB8.Enabled = false;
            BtnB9.Enabled = false;

        }

        public void Checker()
        {
            //For X, Horizontal//
            if (BtnB1.Text == "X" && BtnB2.Text == "X" && BtnB3.Text == "X")
            {
                //Verifier//
                BtnB1.BackColor = System.Drawing.Color.Gray;
                BtnB2.BackColor = System.Drawing.Color.Gray;
                BtnB3.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("X Wins!");
                BtnFalse();
            }

            if (BtnB4.Text == "X" && BtnB5.Text == "X" && BtnB6.Text == "X")
            {
                //Verifier//
                BtnB4.BackColor = System.Drawing.Color.Gray;
                BtnB5.BackColor = System.Drawing.Color.Gray;
                BtnB6.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("X Wins!");
                BtnFalse();
            }

            if (BtnB7.Text == "X" && BtnB8.Text == "X" && BtnB9.Text == "X")
            {
                //Verifier//
                BtnB7.BackColor = System.Drawing.Color.Gray;
                BtnB8.BackColor = System.Drawing.Color.Gray;
                BtnB9.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("X Wins!");
                BtnFalse();
            }

            //For X Vertical//

            if (BtnB1.Text == "X" && BtnB4.Text == "X" && BtnB7.Text == "X")
            {
                //Verifier//
                BtnB1.BackColor = System.Drawing.Color.Gray;
                BtnB4.BackColor = System.Drawing.Color.Gray;
                BtnB7.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("X Wins!");
                BtnFalse();
            }

            if (BtnB2.Text == "X" && BtnB5.Text == "X" && BtnB8.Text == "X")
            {
                //Verifier//
                BtnB2.BackColor = System.Drawing.Color.Gray;
                BtnB5.BackColor = System.Drawing.Color.Gray;
                BtnB8.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("X Wins!");
                BtnFalse();
            }

            if (BtnB3.Text == "X" && BtnB6.Text == "X" && BtnB9.Text == "X")
            {
                //Verifier//
                BtnB3.BackColor = System.Drawing.Color.Gray;
                BtnB6.BackColor = System.Drawing.Color.Gray;
                BtnB9.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("X Wins!");
                BtnFalse();
            }

            // For X Diagonal //
            if (BtnB1.Text == "X" && BtnB5.Text == "X" && BtnB9.Text == "X")
            {
                //Verifier//
                BtnB1.BackColor = System.Drawing.Color.Gray;
                BtnB5.BackColor = System.Drawing.Color.Gray;
                BtnB9.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("X Wins!");
                BtnFalse();
            }

            if (BtnB3.Text == "X" && BtnB5.Text == "X" && BtnB7.Text == "X")
            {
                //Verifier//
                BtnB3.BackColor = System.Drawing.Color.Gray;
                BtnB5.BackColor = System.Drawing.Color.Gray;
                BtnB7.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("X Wins!");
                BtnFalse();
            }





                                      //For O, Horizontal//
            if (BtnB1.Text == "O" && BtnB2.Text == "O" && BtnB3.Text == "O")
            {
                //Verifier//
                BtnB1.BackColor = System.Drawing.Color.Gray;
                BtnB2.BackColor = System.Drawing.Color.Gray;
                BtnB3.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("O Wins!");
                BtnFalse();
            }

            if (BtnB4.Text == "O" && BtnB5.Text == "O" && BtnB6.Text == "O")
            {
                //Verifier//
                BtnB4.BackColor = System.Drawing.Color.Gray;
                BtnB5.BackColor = System.Drawing.Color.Gray;
                BtnB6.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("O Wins!");
                BtnFalse();
            }

            if (BtnB7.Text == "O" && BtnB8.Text == "O" && BtnB9.Text == "O")
            {
                //Verifier//
                BtnB7.BackColor = System.Drawing.Color.Gray;
                BtnB8.BackColor = System.Drawing.Color.Gray;
                BtnB9.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("O Wins!");
                BtnFalse();
            }

                                        //For O Vertical//

            if (BtnB1.Text == "O" && BtnB4.Text == "O" && BtnB7.Text == "O")
            {
                //Verifier//
                BtnB1.BackColor = System.Drawing.Color.Gray;
                BtnB4.BackColor = System.Drawing.Color.Gray;
                BtnB7.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("O Wins!");
                BtnFalse();
            }

            if (BtnB2.Text == "O" && BtnB5.Text == "O" && BtnB8.Text == "O")
            {
                //Verifier//
                BtnB2.BackColor = System.Drawing.Color.Gray;
                BtnB5.BackColor = System.Drawing.Color.Gray;
                BtnB8.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("O Wins!");
                BtnFalse();
            }

            if (BtnB3.Text == "O" && BtnB6.Text == "O" && BtnB9.Text == "O")
            {
                //Verifier//
                BtnB3.BackColor = System.Drawing.Color.Gray;
                BtnB6.BackColor = System.Drawing.Color.Gray;
                BtnB9.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("O Wins!");
                BtnFalse();
            }

                                      // For O Diagonal //
            if (BtnB1.Text == "O" && BtnB5.Text == "O" && BtnB9.Text == "O")
            {
                //Verifier//
                BtnB1.BackColor = System.Drawing.Color.Gray;
                BtnB5.BackColor = System.Drawing.Color.Gray;
                BtnB9.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("O Wins!");
                BtnFalse();
            }

            if (BtnB3.Text == "O" && BtnB5.Text == "O" && BtnB7.Text == "O")
            {
                //Verifier//
                BtnB3.BackColor = System.Drawing.Color.Gray;
                BtnB5.BackColor = System.Drawing.Color.Gray;
                BtnB7.BackColor = System.Drawing.Color.Gray;
                MessageBox.Show("O Wins!");
                BtnFalse();
            }

        }

        public void BtnB1_Click(object sender, EventArgs e)
        {
            ClickSoundFxPop.Play();
            if (Player_Turn == false)
            {
                BtnB1.Text = "O";
                Player_Turn = true;
            }
            else
            {
                BtnB1.Text = "X";
                Player_Turn = false;
            }
            Checker();
            BtnB1.Enabled = false;
            
        }


        public void BtnB2_Click(object sender, EventArgs e)
        {
            ClickSoundFxPop.Play();
            if (Player_Turn == false)
            {
                BtnB2.Text = "O";
                Player_Turn = true;
            }
            else
            {
                BtnB2.Text = "X";
                Player_Turn = false;
            }
            Checker();
            BtnB2.Enabled = false;
            
        }

        public void BtnB3_Click(object sender, EventArgs e)
        {
            ClickSoundFxPop.Play();
            if (Player_Turn == false)
            {
                BtnB3.Text = "O";
                Player_Turn = true;
            }
            else
            {
                BtnB3.Text = "X";
                Player_Turn = false;
            }
            Checker();
            BtnB3.Enabled = false;
            
        }

        public void BtnB4_Click(object sender, EventArgs e)
        {
            ClickSoundFxPop.Play();
            if (Player_Turn == false)
            {
                BtnB4.Text = "O";
                Player_Turn = true;
            }
            else
            {
                BtnB4.Text = "X";
                Player_Turn = false;
            }
            Checker();
            BtnB4.Enabled = false;
            
        }


        public void BtnB5_Click(object sender, EventArgs e)
        {
            ClickSoundFxPop.Play();
            if (Player_Turn == false)
            {
                BtnB5.Text = "O";
                Player_Turn = true;
            }
            else
            {
                BtnB5.Text = "X";
                Player_Turn = false;
            }
            Checker();
            BtnB5.Enabled = false;
            
        }
        public void BtnB6_Click(object sender, EventArgs e)
        {
            ClickSoundFxPop.Play();
            if (Player_Turn == false)
            {
                BtnB6.Text = "O";
                Player_Turn = true;
            }
            else
            {
                BtnB6.Text = "X";
                Player_Turn = false;
            }
            Checker();
            BtnB6.Enabled = false;
            
        }

        public void BtnB7_Click(object sender, EventArgs e)
        {
            ClickSoundFxPop.Play();
            if (Player_Turn == false)
            {
                BtnB7.Text = "O";
                Player_Turn = true;
            }
            else
            {
                BtnB7.Text = "X";
                Player_Turn = false;
            }
            Checker();
            BtnB7.Enabled = false;
            
        }

        public void BtnB8_Click(object sender, EventArgs e)
        {
            ClickSoundFxPop.Play();
            if (Player_Turn == false)
            {
                BtnB8.Text = "O";
                Player_Turn = true;
            }
            else
            {
                BtnB8.Text = "X";
                Player_Turn = false;
            }
            Checker();
            BtnB8.Enabled = false;
            
        }
        public void BtnB9_Click(object sender, EventArgs e)
        {
            ClickSoundFxPop.Play();
            if (Player_Turn == false)
            {
                BtnB9.Text = "O";
                Player_Turn = true;
            }
            else
            {
                BtnB9.Text = "X";
                Player_Turn = false;
            }
            Checker();
            BtnB9.Enabled = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                BtnB1.Enabled = true;
                BtnB2.Enabled = true;
                BtnB3.Enabled = true;
                BtnB4.Enabled = true;
                BtnB5.Enabled = true;
                BtnB6.Enabled = true;
                BtnB7.Enabled = true;
                BtnB8.Enabled = true;
                BtnB9.Enabled = true;

                BtnB1.Text = "";
                BtnB2.Text = "";
                BtnB3.Text = "";
                BtnB4.Text = "";
                BtnB5.Text = "";
                BtnB6.Text = "";
                BtnB7.Text = "";
                BtnB8.Text = "";
                BtnB9.Text = "";

                BtnB1.BackColor = Color.DarkTurquoise;
                BtnB2.BackColor = Color.DarkTurquoise;
                BtnB3.BackColor = Color.DarkTurquoise;
                BtnB4.BackColor = Color.DarkTurquoise;
                BtnB5.BackColor = Color.DarkTurquoise;
                BtnB6.BackColor = Color.DarkTurquoise;
                BtnB7.BackColor = Color.DarkTurquoise;
                BtnB8.BackColor = Color.DarkTurquoise;
                BtnB9.BackColor = Color.DarkTurquoise;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
