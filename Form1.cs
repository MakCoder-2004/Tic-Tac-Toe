namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        string Player = "X Turn";

        int Xcnt = 0, Ocnt = 0, Tcnt = 0, btCnt =0;

        void Enable_False()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        public bool CheckWinner(Button bt1, Button bt2, Button bt3, string XO)
        {
            if (bt1.Text == XO && bt2.Text == XO && bt3.Text == XO)
            {
                bt1.BackColor = Color.LightGreen;
                bt2.BackColor = Color.LightGreen;
                bt3.BackColor = Color.LightGreen;

                if (XO == "X")
                {
                    Xcnt++;
                    PlayerX.Text = Convert.ToString(Xcnt);
                }
                else if(XO == "O")
                {
                    Ocnt++;
                    PlayerO.Text = Convert.ToString(Ocnt);
                }


                Enable_False();
                return true;
            }
            return false;
        }

        public void Winner()
        {
            //-------------------- Winner Conditions for Player X

            if (CheckWinner(btn1, btn2, btn3, "X") ||
                CheckWinner(btn4, btn5, btn6, "X") ||
                CheckWinner(btn7, btn8, btn9, "X") ||
                CheckWinner(btn1, btn4, btn7, "X") ||
                CheckWinner(btn2, btn5, btn8, "X") ||
                CheckWinner(btn3, btn6, btn9, "X") ||
                CheckWinner(btn1, btn5, btn9, "X") ||
                CheckWinner(btn3, btn5, btn7, "X"))
            {
                MessageBox.Show("Player X Wins :)", "Winner !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //-------------------- Winner Conditions for Player O

            if (CheckWinner(btn1, btn2, btn3, "O") ||
                CheckWinner(btn4, btn5, btn6, "O") ||
                CheckWinner(btn7, btn8, btn9, "O") ||
                CheckWinner(btn1, btn4, btn7, "O") ||
                CheckWinner(btn2, btn5, btn8, "O") ||
                CheckWinner(btn3, btn6, btn9, "O") ||
                CheckWinner(btn1, btn5, btn9, "O") ||
                CheckWinner(btn3, btn5, btn7, "O"))
            {
                MessageBox.Show("Player O Wins :)", "Winner !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // If all buttons are filled and no winner, it's a draw
            if (btCnt == 9)
            {
                Tcnt++;
                Tie.Text = Convert.ToString(Tcnt);
                MessageBox.Show("It's a Draw :(", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_False();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Reset button values
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            // Reset button states
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            // Reset Button colors
            btn1.BackColor = Color.DarkSlateBlue;
            btn2.BackColor = Color.DarkSlateBlue;
            btn3.BackColor = Color.DarkSlateBlue;
            btn4.BackColor = Color.DarkSlateBlue;
            btn5.BackColor = Color.DarkSlateBlue;
            btn6.BackColor = Color.DarkSlateBlue;
            btn7.BackColor = Color.DarkSlateBlue;
            btn8.BackColor = Color.DarkSlateBlue;
            btn9.BackColor = Color.DarkSlateBlue;

            //Reset Player Turn
            Player = PlayerTurn.Text = "X Turn";

            //Reset Button count
            btCnt = 0;

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //Reset button values
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            // Reset button states
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            // Reset Button colors
            btn1.BackColor = Color.DarkSlateBlue;
            btn2.BackColor = Color.DarkSlateBlue;
            btn3.BackColor = Color.DarkSlateBlue;
            btn4.BackColor = Color.DarkSlateBlue;
            btn5.BackColor = Color.DarkSlateBlue;
            btn6.BackColor = Color.DarkSlateBlue;
            btn7.BackColor = Color.DarkSlateBlue;
            btn8.BackColor = Color.DarkSlateBlue;
            btn9.BackColor = Color.DarkSlateBlue;

            // Reset Score Board
            Xcnt = 0;
            Ocnt = 0;
            Tcnt = 0;
            PlayerX.Text = Xcnt.ToString();
            PlayerO.Text = Ocnt.ToString();
            Tie.Text = Tcnt.ToString();

            //Reset Player Turn
            Player = PlayerTurn.Text = "X Turn";

            //Reset Button count
            btCnt = 0;


        }

        public void PressBtn(Button b)
        {
            if (Player == "X Turn")
            {
                b.Text = "X";
                Player = "O Turn";
                PlayerTurn.Text = Player;
                b.Enabled = false;
                b.BackColor = Color.White;
                btCnt++;
            }
            else
            {
                b.Text = "O";
                Player = "X Turn";
                PlayerTurn.Text = Player;
                b.Enabled = false;
                b.BackColor = Color.White;
                btCnt++;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            PressBtn(btn1);
            Winner();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            PressBtn(btn2);
            Winner();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            PressBtn(btn3);
            Winner();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            PressBtn(btn4);
            Winner();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            PressBtn(btn5);
            Winner();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            PressBtn(btn6);
            Winner();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            PressBtn(btn7);
            Winner();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            PressBtn(btn8);
            Winner();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            PressBtn(btn9);
            Winner();
        }
    }
}
