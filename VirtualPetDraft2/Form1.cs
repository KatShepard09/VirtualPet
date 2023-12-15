using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VirtualPetDraft2
{
    public partial class Form1 : Form
    {
        private readonly System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(); // timer that moves the pet periodically
        private readonly Random random = new Random(); // random number generator for the pet movement 
        private readonly PictureBox PetPictureBox = new PictureBox(); // displays pet image
        private readonly PictureBox FoodPictureBox = new PictureBox(); // for the food
        private int PetHunger = 0;
        private int MaxPetHunger = 5;
        private readonly System.Windows.Forms.Timer hungerTimer = new System.Windows.Forms.Timer();

        //TicTacToe Button - Lets user play a simple game of TicTacToe with pet
        private void TicTacToe_Click(object sender, EventArgs e)
        {
            TicTacToe game = new TicTacToe();
            game.Show();
        }

        //Notepad Button - Lets user make a text document that can later be saved and opened at a later point
        private void Notepad_Click(object sender, EventArgs e)
        {
            Notepad game = new Notepad();
            game.Show();
        }


        //List of random phrases for when pet is clicked on
        private readonly List<string> petPhrases = new List<string>
        {
            "Hi Hi !",
            "Feed me !",
            "＼(^o^)／",
            "Let's play a game !",
            "How are you doing ?",
            "(◕‿◕✿)",
        };

        private string GetRandomPetPhrase()
        {
            int index = random.Next(petPhrases.Count);
            return petPhrases[index];
        }

        public Form1()
        {
            InitializeComponent();
            InitializePet();
            InitializeTimer();
            InitializeHungerTimer();
            InitializeUI();

            // Set the form's start position to manual
            this.StartPosition = FormStartPosition.Manual;

            // Set the form's initial location to be at the bottom center of the screen
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;

            int initialX = (screenWidth - formWidth) / 2; // Center horizontally
            int initialY = screenHeight - formHeight; // Place at the bottom

            this.Location = new Point(initialX, initialY);


        }

        //Draws the pet onto the screem
        private void InitializePet()
        {
            PetPictureBox.Image = Properties.Resources.pet;
            PetPictureBox.Size = new Size(100, 100);
            PetPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PetPictureBox.Location = new Point(random.Next(0, this.ClientSize.Width - 50), random.Next(0, this.ClientSize.Height - 50));
            PetPictureBox.Click += (sender, e) =>
            {
                string randomPhrase = GetRandomPetPhrase();
                MessageBox.Show(randomPhrase);
            };
            Controls.Add(PetPictureBox);

            // Initialize the food
            FoodPictureBox.Image = Properties.Resources.Food;
            FoodPictureBox.Size = new Size(50, 50);
            FoodPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            FoodPictureBox.Location = new Point(random.Next(0, this.ClientSize.Width - 50), random.Next(0, this.ClientSize.Height - 50));
            Controls.Add(FoodPictureBox);

            // Set up drag-and-drop events for the food
            FoodPictureBox.AllowDrop = true;
            FoodPictureBox.MouseDown += FoodPictureBox_MouseDown;
            PetPictureBox.AllowDrop = true;
            PetPictureBox.DragEnter += PetPictureBox_DragEnter;
            PetPictureBox.DragDrop += PetPictureBox_DragDrop;
        }

        private void InitializeTimer()
        {
            timer.Interval = 100;
            timer.Tick += (sender, e) => MovePet();
            timer.Start();
        }

        private void InitializeUI()
        {
            // Initialize hunger label
            hungerLabel.Text = $"Hunger Level: {PetHunger}";
            hungerLabel.AutoSize = true;
            hungerLabel.Location = new Point(10, 10); // Adjust the location as needed
            Controls.Add(hungerLabel);
        }

        //Set up Hunger Timer
        private void InitializeHungerTimer()
        {
            hungerTimer.Interval = 10000; // Set the interval to 10000 milliseconds (10 seconds)
            hungerTimer.Tick += (sender, e) => DecreasePetHunger();
            hungerTimer.Start();
        }

        //Clicking and dragging on the food picture box
        private void FoodPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Start the drag-and-drop operation for the food
            if (sender is PictureBox foodPictureBox)
            {
                foodPictureBox.DoDragDrop(foodPictureBox, DragDropEffects.Move);
            }
        }

        private void PetPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            // Allow the food to be dropped onto the pet
            e.Effect = DragDropEffects.Move;
        }

        private void PetPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            // Handle the drop event for the pet
            FeedPet();
        }

        private void FeedPet()
        {
            // Check if the pet is too full
            if (PetHunger >= MaxPetHunger)
            {
                MessageBox.Show("Your pet is too full! Please try again later.");
                return;
            }

            // Reset the food's position
            FoodPictureBox.Location = new Point(random.Next(0, this.ClientSize.Width - 50), random.Next(0, this.ClientSize.Height - 50));

            // Increment the pet's hunger
            PetHunger++;
            // Using BeginInvoke to update UI elements on the main UI thread
            BeginInvoke(new Action(() =>
            {
                hungerLabel.Text = $"Hunger Level: {PetHunger}";
                Console.WriteLine($"Your pet's fullness is at {PetHunger}");
            }));
            MessageBox.Show($"Your pet's fullness is at {PetHunger}");
        }

        private void DecreasePetHunger()
        {
            if (PetHunger > 0)
            {
                PetHunger--;

                // Using BeginInvoke to update UI elements on the main UI thread
                BeginInvoke(new Action(() =>
                {
                    hungerLabel.Text = $"Hunger Level: {PetHunger}";
                    Console.WriteLine($"Your pet's fullness is at {PetHunger}");
                }));
            }
        }

        private void MovePet()
        {
            const int maxStep = 30; // Maximum movement distance in pixels
            const double smoothingFactor = 0.1; // Smoothing factor for movement

            // Calculate a random direction vector
            double angle = random.NextDouble() * 2 * Math.PI;
            double deltaX = Math.Cos(angle);
            double deltaY = Math.Sin(angle);

            // Calculate the next position
            int newX = (int)(PetPictureBox.Location.X + maxStep * smoothingFactor * deltaX);
            int newY = (int)(PetPictureBox.Location.Y + maxStep * smoothingFactor * deltaY);

            // Apply smoothing factor to make the movement smoother
            int smoothedX = (int)(PetPictureBox.Location.X + smoothingFactor * (newX - PetPictureBox.Location.X));
            int smoothedY = (int)(PetPictureBox.Location.Y + smoothingFactor * (newY - PetPictureBox.Location.Y));

            // Set the new position
            PetPictureBox.Location = new Point(smoothedX, smoothedY);

            // Ensure the pet stays within the form boundaries
            ClampPetLocation();
        }

        private void ClampPetLocation()
        {
            int maxX = this.ClientSize.Width - PetPictureBox.Width;
            int maxY = this.ClientSize.Height - PetPictureBox.Height;

            PetPictureBox.Location = new Point(
                Math.Max(0, Math.Min(PetPictureBox.Location.X, maxX)),
                Math.Max(0, Math.Min(PetPictureBox.Location.Y, maxY))
            );
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the timers when the form is closing
            timer.Stop();
            hungerTimer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
