using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tik_Tac_Toe
{
    public partial class Form1 : Form
    {
        //True X Turn , False O Turn
        bool turn = true;
        int turn_count = 0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();
        }

        private void checkForWinner() 
        {
            // Horizontal checker
            bool there_is_a_winner = false;
            if ((R1C1.Text == R1C2.Text) && (R1C2.Text == R1C3.Text) &&(!R1C1.Enabled))
                there_is_a_winner = true;

            else if ((R2C1.Text == R2C2.Text) && (R2C2.Text == R2C3.Text) && (!R2C1.Enabled))
                there_is_a_winner = true;

            else if ((R3C1.Text == R3C2.Text) && (R3C2.Text == R3C3.Text) && (!R3C1.Enabled))
                there_is_a_winner = true;

            // Diagonal Checker

            else if ((R1C1.Text == R2C2.Text) && (R2C2.Text == R3C3.Text) && (!R1C1.Enabled))
                there_is_a_winner = true;
            else if ((R1C3.Text == R2C2.Text) && (R2C2.Text == R3C1.Text) && (!R1C3.Enabled))
                there_is_a_winner = true;

            // Vertical Checker
            else if ((R1C1.Text == R2C1.Text) && (R2C1.Text == R3C1.Text) && (!R1C1.Enabled))
                there_is_a_winner = true;
            else if ((R1C2.Text == R2C2.Text) && (R2C2.Text == R3C2.Text) && (!R1C2.Enabled))
                there_is_a_winner = true;
            else if ((R1C3.Text == R2C3.Text) && (R2C3.Text == R3C3.Text) && (!R1C3.Enabled))
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                disableButtons();

                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";


                MessageBox.Show(winner+ " Won");
            }//end for string
            else 
            {
                if (turn_count == 9)
                    MessageBox.Show(" Draw ");

            }
        }//end for horizontal checker

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }//end foreach
            }//end of try
            catch { }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//end foreach
            }//end of try
            catch { }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)

                    b.Text = "X";
                else
                    b.Text = "O";
            }// end if

            
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }// end if
        }
    }
}
