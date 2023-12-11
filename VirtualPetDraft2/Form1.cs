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
        private int PetHunger = 0;
        private int MaxPetHunger = 5;
        private readonly System.Windows.Forms.Timer hungerTimer = new System.Windows.Forms.Timer();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        //TicTacToe Button - Lets user play a simple game of TicTacToe with pet
        private void button1_Click(object sender, EventArgs e)
        {
            TicTacToe game = new TicTacToe();
            game.Show();
        }

        //Notepad Button - Lets user make a text document that can later be saved and opened at a later point
        private void button2_Click(object sender, EventArgs e)
        {
            Notepad game = new Notepad();
            game.Show();
        }

        //Interact Button - Lets user interact with the pet by opening up console interactions
        private void button3_Click(object sender, EventArgs e)
        {
            AllocConsole();
            while (true)
            {
                Console.WriteLine("Welcome to your Virtual Pet! How would you like to interact with your pet? [Feed, Talk To]");
                string UInteractChoice = Console.ReadLine();

                switch (UInteractChoice)
                {
                    case "Feed":
                        PetHunger++;
                        if (PetHunger >= MaxPetHunger)
                        {
                            Console.WriteLine("Your pet is too full! Please wait a bit before feeding again");
                        }
                        else
                        {
                            Console.WriteLine($"Your pet's fullness is at {PetHunger}");
                        }
                        break;

                    case "Talk To":
                        int TalkLine = new Random().Next(0, 5);
                        Console.WriteLine(TalkLine);
                        break;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            InitializePet();
            InitializeTimer();
            InitializeHungerTimer();


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

            //When pet is clicked, message is shown
            PetPictureBox.Click += (sender, e) => { MessageBox.Show("Hi Hi!!"); };
            Controls.Add(PetPictureBox);
        }

        private void InitializeTimer()
        {
            timer.Interval = 100;
            timer.Tick += (sender, e) => MovePet();
            timer.Start();
        }

        private void MovePet()
        {
            int moveX = random.Next(-20, 21);
            int moveY = random.Next(-10, 11);

            int newX = PetPictureBox.Location.X + moveX;
            int newY = PetPictureBox.Location.Y + moveY;

            // Apply smoothing factor (e.g., 0.2) to make the movement smoother
            int smoothedX = (int)(PetPictureBox.Location.X + 0.2 * (newX - PetPictureBox.Location.X));
            int smoothedY = (int)(PetPictureBox.Location.Y + 0.2 * (newY - PetPictureBox.Location.Y));

            PetPictureBox.Location = new Point(smoothedX, smoothedY);

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

        private void InitializeHungerTimer()
        {
            hungerTimer.Interval = 5000; // Set the interval to 5000 milliseconds (5 seconds)
            hungerTimer.Tick += (sender, e) => DecreasePetHunger();
            hungerTimer.Start();
        }

        private void DecreasePetHunger()
        {
            if (PetHunger > 0)
            {
                PetHunger--;
                Console.WriteLine($"Your pet's fullness is at {PetHunger}");
            }
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
