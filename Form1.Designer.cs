namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnNewGame = new Button();
            btnRestart = new Button();
            ScoreBox = new GroupBox();
            Tie = new TextBox();
            PlayerO = new TextBox();
            PlayerX = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            PlayerTurn = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnExit = new Button();
            label3 = new Label();
            groupBox2 = new GroupBox();
            ScoreBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("The Bold Font", 47.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(93, 37);
            label1.Name = "label1";
            label1.Size = new Size(235, 89);
            label1.TabIndex = 0;
            label1.Text = "X - O";
            // 
            // btn9
            // 
            btn9.BackColor = Color.DarkSlateBlue;
            btn9.Font = new Font("Segoe UI", 60F, FontStyle.Bold);
            btn9.ForeColor = SystemColors.ButtonFace;
            btn9.Location = new Point(374, 491);
            btn9.Name = "btn9";
            btn9.Size = new Size(150, 147);
            btn9.TabIndex = 18;
            btn9.TextAlign = ContentAlignment.TopRight;
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.DarkSlateBlue;
            btn8.Font = new Font("Segoe UI", 60F, FontStyle.Bold);
            btn8.ForeColor = SystemColors.ButtonFace;
            btn8.Location = new Point(214, 491);
            btn8.Name = "btn8";
            btn8.Size = new Size(150, 147);
            btn8.TabIndex = 17;
            btn8.TextAlign = ContentAlignment.TopRight;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.DarkSlateBlue;
            btn7.Font = new Font("Segoe UI", 60F, FontStyle.Bold);
            btn7.ForeColor = SystemColors.ButtonFace;
            btn7.Location = new Point(54, 491);
            btn7.Name = "btn7";
            btn7.Size = new Size(150, 147);
            btn7.TabIndex = 16;
            btn7.TextAlign = ContentAlignment.TopRight;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.DarkSlateBlue;
            btn4.Font = new Font("Segoe UI", 60F, FontStyle.Bold);
            btn4.ForeColor = SystemColors.ButtonFace;
            btn4.Location = new Point(54, 324);
            btn4.Name = "btn4";
            btn4.Size = new Size(150, 147);
            btn4.TabIndex = 15;
            btn4.TextAlign = ContentAlignment.TopRight;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.DarkSlateBlue;
            btn5.Font = new Font("Segoe UI", 60F, FontStyle.Bold);
            btn5.ForeColor = SystemColors.ButtonFace;
            btn5.Location = new Point(214, 324);
            btn5.Name = "btn5";
            btn5.Size = new Size(150, 147);
            btn5.TabIndex = 14;
            btn5.TextAlign = ContentAlignment.TopRight;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.DarkSlateBlue;
            btn6.Font = new Font("Segoe UI", 60F, FontStyle.Bold);
            btn6.ForeColor = SystemColors.ButtonFace;
            btn6.Location = new Point(374, 324);
            btn6.Name = "btn6";
            btn6.Size = new Size(150, 147);
            btn6.TabIndex = 13;
            btn6.TextAlign = ContentAlignment.TopRight;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.DarkSlateBlue;
            btn3.Font = new Font("Segoe UI", 60F, FontStyle.Bold);
            btn3.ForeColor = SystemColors.ButtonFace;
            btn3.Location = new Point(374, 158);
            btn3.Name = "btn3";
            btn3.Size = new Size(150, 147);
            btn3.TabIndex = 12;
            btn3.TextAlign = ContentAlignment.TopRight;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.DarkSlateBlue;
            btn2.Font = new Font("Segoe UI", 60F, FontStyle.Bold);
            btn2.ForeColor = SystemColors.ButtonFace;
            btn2.Location = new Point(214, 158);
            btn2.Name = "btn2";
            btn2.Size = new Size(150, 147);
            btn2.TabIndex = 11;
            btn2.TextAlign = ContentAlignment.TopRight;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.DarkSlateBlue;
            btn1.Font = new Font("Segoe UI", 60F, FontStyle.Bold);
            btn1.ForeColor = SystemColors.ButtonFace;
            btn1.Location = new Point(54, 158);
            btn1.Name = "btn1";
            btn1.Size = new Size(150, 147);
            btn1.TabIndex = 10;
            btn1.TextAlign = ContentAlignment.TopRight;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("The Bold Font", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewGame.ForeColor = Color.DarkSlateBlue;
            btnNewGame.Location = new Point(64, 324);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(396, 106);
            btnNewGame.TabIndex = 19;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnRestart
            // 
            btnRestart.Font = new Font("The Bold Font", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = Color.DarkSlateBlue;
            btnRestart.Location = new Point(64, 441);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(253, 99);
            btnRestart.TabIndex = 20;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // ScoreBox
            // 
            ScoreBox.Controls.Add(Tie);
            ScoreBox.Controls.Add(PlayerO);
            ScoreBox.Controls.Add(PlayerX);
            ScoreBox.Controls.Add(textBox4);
            ScoreBox.Controls.Add(textBox2);
            ScoreBox.Controls.Add(textBox1);
            ScoreBox.Font = new Font("The Bold Font", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreBox.ForeColor = SystemColors.ButtonHighlight;
            ScoreBox.Location = new Point(42, 155);
            ScoreBox.Name = "ScoreBox";
            ScoreBox.Size = new Size(427, 147);
            ScoreBox.TabIndex = 22;
            ScoreBox.TabStop = false;
            ScoreBox.Text = "Score";
            // 
            // Tie
            // 
            Tie.BackColor = Color.DarkSlateBlue;
            Tie.BorderStyle = BorderStyle.None;
            Tie.Font = new Font("The Bold Font", 22.2F, FontStyle.Bold);
            Tie.ForeColor = SystemColors.InactiveBorder;
            Tie.Location = new Point(341, 92);
            Tie.Name = "Tie";
            Tie.Size = new Size(59, 41);
            Tie.TabIndex = 5;
            Tie.Text = "0";
            Tie.TextAlign = HorizontalAlignment.Center;
            // 
            // PlayerO
            // 
            PlayerO.BackColor = Color.DarkSlateBlue;
            PlayerO.BorderStyle = BorderStyle.None;
            PlayerO.Font = new Font("The Bold Font", 22.2F, FontStyle.Bold);
            PlayerO.ForeColor = SystemColors.InactiveBorder;
            PlayerO.Location = new Point(207, 92);
            PlayerO.Name = "PlayerO";
            PlayerO.Size = new Size(59, 41);
            PlayerO.TabIndex = 4;
            PlayerO.Text = "0";
            PlayerO.TextAlign = HorizontalAlignment.Center;
            // 
            // PlayerX
            // 
            PlayerX.BackColor = Color.DarkSlateBlue;
            PlayerX.BorderStyle = BorderStyle.None;
            PlayerX.Font = new Font("The Bold Font", 22.2F, FontStyle.Bold);
            PlayerX.ForeColor = SystemColors.InactiveBorder;
            PlayerX.Location = new Point(53, 92);
            PlayerX.Name = "PlayerX";
            PlayerX.Size = new Size(59, 41);
            PlayerX.TabIndex = 3;
            PlayerX.Text = "0";
            PlayerX.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DarkSlateBlue;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(332, 56);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(77, 30);
            textBox4.TabIndex = 2;
            textBox4.Text = "Ties";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkSlateBlue;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(178, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 30);
            textBox2.TabIndex = 1;
            textBox2.Text = "Player O";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkSlateBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(19, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 30);
            textBox1.TabIndex = 0;
            textBox1.Text = "Player X";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // PlayerTurn
            // 
            PlayerTurn.BackColor = Color.DarkSlateBlue;
            PlayerTurn.BorderStyle = BorderStyle.None;
            PlayerTurn.Font = new Font("The Bold Font", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayerTurn.ForeColor = SystemColors.InactiveBorder;
            PlayerTurn.Location = new Point(9, 16);
            PlayerTurn.Name = "PlayerTurn";
            PlayerTurn.Size = new Size(143, 41);
            PlayerTurn.TabIndex = 23;
            PlayerTurn.Text = "X Turn";
            PlayerTurn.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("The Bold Font", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(64, 50);
            label2.Name = "label2";
            label2.Size = new Size(386, 67);
            label2.TabIndex = 24;
            label2.Text = "Tic-Tac-Toe";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ScoreBox);
            groupBox1.Controls.Add(btnRestart);
            groupBox1.Controls.Add(btnNewGame);
            groupBox1.Location = new Point(591, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 575);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("The Bold Font", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.DarkSlateBlue;
            btnExit.Location = new Point(327, 441);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(133, 99);
            btnExit.TabIndex = 26;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(156, 117);
            label3.Name = "label3";
            label3.Size = new Size(199, 22);
            label3.TabIndex = 25;
            label3.Text = "By : Makrious Ayman";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PlayerTurn);
            groupBox2.Location = new Point(353, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(161, 70);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1145, 697);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic-Tac-Toe";
            ScoreBox.ResumeLayout(false);
            ScoreBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnNewGame;
        private Button btnRestart;
        private GroupBox ScoreBox;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox Tie;
        private TextBox PlayerO;
        private TextBox PlayerX;
        private TextBox PlayerTurn;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private GroupBox groupBox2;
        private Button btnExit;
    }
}
