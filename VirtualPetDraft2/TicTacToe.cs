using System;
using System.Windows.Forms;

namespace VirtualPetDraft2
{
    public partial class TicTacToe : Form
    {
        private char currentPlayer = 'X'; // 'X' starts the game
        private char[,] board = new char[3, 3]; // Represent the game board

        public TicTacToe()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            // Set up the initial state of the game
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Clear the board and reset buttons
            currentPlayer = 'X';
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                    ResetButton(i, j);
                }
            }
        }

        private void ResetButton(int row, int col)
        {
            // Reset individual button
            Button button = GetButton(row, col);
            button.Text = "";
            button.Enabled = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Check if the current player is 'X'
            if (currentPlayer != 'X')
            {
                // If it's not 'X', return early and don't make a move
                return;
            }

            // Attempt to convert Tag to integer
            if (int.TryParse(button.Tag.ToString(), out int tagValue))
            {
                int row = tagValue / 3;
                int col = tagValue % 3;

                if (board[row, col] == ' ')
                {
                    board[row, col] = currentPlayer;
                    button.Text = currentPlayer.ToString();
                    button.Enabled = false;

                    if (CheckForWinner())
                    {
                        MessageBox.Show($"{currentPlayer} wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InitializeGame();
                    }
                    else if (IsBoardFull())
                    {
                        MessageBox.Show("It's a draw!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InitializeGame();
                    }
                    else
                    {
                        currentPlayer = 'O'; // Switch to the other player
                        MakeCPUMove(); // Call the method to make the automatic 'O' move
                    }
                }
            }
        }

        private void MakeCPUMove()
        {
            // Implement logic for the CPU move (simple example: find the first empty cell)
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        board[i, j] = 'O';
                        GetButton(i, j).Text = 'O'.ToString();
                        GetButton(i, j).Enabled = false;

                        if (CheckForWinner())
                        {
                            MessageBox.Show("O wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InitializeGame();
                        }
                        else if (IsBoardFull())
                        {
                            MessageBox.Show("It's a draw!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InitializeGame();
                        }

                        currentPlayer = 'X'; // Switch back to the player after CPU move
                        return;
                    }
                }
            }
        }


        private bool CheckForWinner()
        {
            // Check rows, columns, and diagonals for a winner
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return true;

                if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return true;
            }

            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return true;

            if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return true;

            return false;
        }

        private bool IsBoardFull()
        {
            // Check if the board is full (draw)
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                        return false;
                }
            }
            return true;
        }

        private Button GetButton(int row, int col)
        {
            // Helper method to get the button at a specific row and column
            return (Button)Controls.Find($"butt{row * 3 + col + 1}", true)[0];
        }

        private void butt1_Click(object sender, EventArgs e) { button_Click(sender, e); }
        private void butt2_Click(object sender, EventArgs e) { button_Click(sender, e); }
        private void butt3_Click(object sender, EventArgs e) { button_Click(sender, e); }
        private void butt4_Click(object sender, EventArgs e) { button_Click(sender, e); }
        private void butt5_Click(object sender, EventArgs e) { button_Click(sender, e); }
        private void butt6_Click(object sender, EventArgs e) { button_Click(sender, e); }
        private void butt7_Click(object sender, EventArgs e) { button_Click(sender, e); }
        private void butt8_Click(object sender, EventArgs e) { button_Click(sender, e); }
        private void butt9_Click(object sender, EventArgs e) { button_Click(sender, e); }
    }
}

