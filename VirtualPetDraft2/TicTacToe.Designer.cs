﻿namespace VirtualPetDraft2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(60, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 450);
            panel1.TabIndex = 0;
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
            // button2
            // 
            button2.Location = new Point(150, 0);
            button2.Name = "button2";
            button2.Size = new Size(150, 150);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(300, 0);
            button3.Name = "button3";
            button3.Size = new Size(150, 150);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(151, 150);
            button4.TabIndex = 1;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(0, 300);
            button5.Name = "button5";
            button5.Size = new Size(151, 150);
            button5.TabIndex = 1;
            button5.Text = "button1";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(150, 300);
            button6.Name = "button6";
            button6.Size = new Size(150, 150);
            button6.TabIndex = 2;
            button6.Text = "button2";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(300, 300);
            button7.Name = "button7";
            button7.Size = new Size(150, 150);
            button7.TabIndex = 3;
            button7.Text = "button3";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(0, 150);
            button8.Name = "button8";
            button8.Size = new Size(151, 150);
            button8.TabIndex = 1;
            button8.Text = "button1";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(150, 150);
            button9.Name = "button9";
            button9.Size = new Size(150, 150);
            button9.TabIndex = 2;
            button9.Text = "button2";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(300, 150);
            button10.Name = "button10";
            button10.Size = new Size(150, 150);
            button10.TabIndex = 3;
            button10.Text = "button3";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(230, 645);
            button11.Name = "button11";
            button11.Size = new Size(112, 34);
            button11.TabIndex = 1;
            button11.Text = "Play Again";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 812);
            Controls.Add(button11);
            Controls.Add(panel1);
            Name = "TicTacToe";
            Text = "TicTacToe";
            Load += TicTacToe_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button10;
        private Button button7;
        private Button button3;
        private Button button9;
        private Button button8;
        private Button button6;
        private Button button5;
        private Button button2;
        private Button button4;
        private Button button1;
        private Button button11;
    }
}