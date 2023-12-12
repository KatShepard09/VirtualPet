namespace VirtualPetDraft2
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
            TicTacToe = new Button();
            Notepad = new Button();
            hungerLabel = new Label();
            SuspendLayout();
            // 
            // TicTacToe
            // 
            TicTacToe.Location = new Point(12, 315);
            TicTacToe.Name = "TicTacToe";
            TicTacToe.Size = new Size(112, 34);
            TicTacToe.TabIndex = 0;
            TicTacToe.Text = "TicTacToe";
            TicTacToe.UseVisualStyleBackColor = true;
            TicTacToe.Click += TicTacToe_Click;
            // 
            // Notepad
            // 
            Notepad.Location = new Point(12, 275);
            Notepad.Name = "Notepad";
            Notepad.Size = new Size(112, 34);
            Notepad.TabIndex = 1;
            Notepad.Text = "Notepad";
            Notepad.UseVisualStyleBackColor = true;
            Notepad.Click += Notepad_Click;
            // 
            // hungerLabel
            // 
            hungerLabel.AutoSize = true;
            hungerLabel.Location = new Point(12, 9);
            hungerLabel.Name = "hungerLabel";
            hungerLabel.Size = new Size(59, 25);
            hungerLabel.TabIndex = 3;
            hungerLabel.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(163, 177, 138);
            ClientSize = new Size(2567, 359);
            Controls.Add(hungerLabel);
            Controls.Add(Notepad);
            Controls.Add(TicTacToe);
            Name = "Form1";
            Text = "My Virtual Pet";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TicTacToe;
        private Button Notepad;
        private Label hungerLabel;
    }
}