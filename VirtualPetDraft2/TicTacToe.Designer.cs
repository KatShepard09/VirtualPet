namespace VirtualPetDraft2
{
    partial class TicTacToe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            butt6 = new Button();
            butt9 = new Button();
            butt3 = new Button();
            butt5 = new Button();
            butt4 = new Button();
            butt8 = new Button();
            butt7 = new Button();
            butt2 = new Button();
            butt1 = new Button();
            button1 = new Button();
            PlayAgain = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(butt6);
            panel1.Controls.Add(butt9);
            panel1.Controls.Add(butt3);
            panel1.Controls.Add(butt5);
            panel1.Controls.Add(butt4);
            panel1.Controls.Add(butt8);
            panel1.Controls.Add(butt7);
            panel1.Controls.Add(butt2);
            panel1.Controls.Add(butt1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(60, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 450);
            panel1.TabIndex = 0;
            // 
            // butt6
            // 
            butt6.Location = new Point(300, 150);
            butt6.Name = "butt6";
            butt6.Size = new Size(150, 150);
            butt6.TabIndex = 3;
            butt6.Tag = "5";
            butt6.Text = "button3";
            butt6.UseVisualStyleBackColor = true;
            butt6.Click += butt6_Click;
            // 
            // butt9
            // 
            butt9.Location = new Point(300, 300);
            butt9.Name = "butt9";
            butt9.Size = new Size(150, 150);
            butt9.TabIndex = 3;
            butt9.Tag = "8";
            butt9.Text = "button3";
            butt9.UseVisualStyleBackColor = true;
            butt9.Click += butt9_Click;
            // 
            // butt3
            // 
            butt3.Location = new Point(300, 0);
            butt3.Name = "butt3";
            butt3.Size = new Size(150, 150);
            butt3.TabIndex = 3;
            butt3.Tag = "2";
            butt3.Text = "button3";
            butt3.UseVisualStyleBackColor = true;
            butt3.Click += butt3_Click;
            // 
            // butt5
            // 
            butt5.Location = new Point(150, 150);
            butt5.Name = "butt5";
            butt5.Size = new Size(150, 150);
            butt5.TabIndex = 2;
            butt5.Tag = "4";
            butt5.Text = "button5";
            butt5.UseVisualStyleBackColor = true;
            butt5.Click += butt5_Click;
            // 
            // butt4
            // 
            butt4.Location = new Point(0, 150);
            butt4.Name = "butt4";
            butt4.Size = new Size(151, 150);
            butt4.TabIndex = 1;
            butt4.Tag = "3";
            butt4.Text = "button4";
            butt4.UseVisualStyleBackColor = true;
            butt4.Click += butt4_Click;
            // 
            // butt8
            // 
            butt8.Location = new Point(150, 300);
            butt8.Name = "butt8";
            butt8.Size = new Size(150, 150);
            butt8.TabIndex = 2;
            butt8.Tag = "7";
            butt8.Text = "button2";
            butt8.UseVisualStyleBackColor = true;
            butt8.Click += butt8_Click;
            // 
            // butt7
            // 
            butt7.Location = new Point(0, 300);
            butt7.Name = "butt7";
            butt7.Size = new Size(151, 150);
            butt7.TabIndex = 1;
            butt7.Tag = "6";
            butt7.Text = "button1";
            butt7.UseVisualStyleBackColor = true;
            butt7.Click += butt7_Click;
            // 
            // butt2
            // 
            butt2.Location = new Point(150, 0);
            butt2.Name = "butt2";
            butt2.Size = new Size(150, 150);
            butt2.TabIndex = 2;
            butt2.Tag = "1";
            butt2.Text = "button2";
            butt2.UseVisualStyleBackColor = true;
            butt2.Click += butt2_Click;
            // 
            // butt1
            // 
            butt1.Location = new Point(0, 0);
            butt1.Name = "butt1";
            butt1.Size = new Size(151, 150);
            butt1.TabIndex = 1;
            butt1.Tag = "0";
            butt1.Text = "button1";
            butt1.UseVisualStyleBackColor = true;
            butt1.Click += butt1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(151, 150);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // PlayAgain
            // 
            PlayAgain.Location = new Point(230, 645);
            PlayAgain.Name = "PlayAgain";
            PlayAgain.Size = new Size(112, 34);
            PlayAgain.TabIndex = 1;
            PlayAgain.Text = "Play Again";
            PlayAgain.UseVisualStyleBackColor = true;
            PlayAgain.Click += PlayAgain_Click;
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 812);
            Controls.Add(PlayAgain);
            Controls.Add(panel1);
            Name = "TicTacToe";
            Text = "TicTacToe";
            Load += TicTacToe_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button butt6;
        private Button butt9;
        private Button butt3;
        private Button butt5;
        private Button butt4;
        private Button butt8;
        private Button butt7;
        private Button butt2;
        private Button butt1;
        private Button button1;
        private Button PlayAgain;
    }
}