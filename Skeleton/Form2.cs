//Created by Devan Parsley

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Media;

namespace Skeleton
{
    public partial class Form2 : Form
    {
        //These are my declarations for Form2 class below

        string input = Regex.Replace((File.ReadAllText("level1.txt")), @"\s+", string.Empty);

        //SoundPlayer player2 = new SoundPlayer("P.I.E Theme2.wav");
        SoundPlayer player1 = new SoundPlayer("WraithSound.wav");
        SoundPlayer player3 = new SoundPlayer("WraithSpawnSound.wav");
        char direction = 'N';
        int gameOver = 0;
        int heightDisplay = 0;
        int music = 1;
        int eventCooldown = 0;
        int mapChecker = 0;
        int eventSelecter = 0;
        int currentEvent = 0;
        int chapterRoom = 0;
        int boneRoom = 0;
        int relicRoom = 0;
        int mainEvent = 0;
        int mainEventTrigger = 0;
        List<int> eventPicker = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };

        int itemSelecter = 0;
        List<int> itemPicker = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        List<int> itemLoser = new List<int> { 1, 4, 5, 6, 7, 8, 9, 10 };
        int item1 = 0;
        int item2 = 0;
        int item3 = 0;
        int item4 = 0;
        int item5 = 0;
        int item6 = 0;
        int item7 = 0;
        int item8 = 0;
        int item9 = 0;
        int item10 = 0;
        int item11 = 0;
        int item10used = 1;


        int height = 9;
        int width = 3;
        int playerStrength = 3;
        int playerSpeed = 4;
        int playerMind = 3;
        int playerMovement = 4;
        int playerHP = 20;
        int mainEventCounter = 0;
        int minorEventCounter = 0;
        int attackAbility = 0;

        int monsterSpawned = 0;
        int monsterHeight = 0;
        int monsterWidth = 9;
        int monsterSpawnerMain = 3;
        int monsterSpawnerMinor = 7;
        int monsterStrength = 6;
        int monsterSpeed = 3;
        //int monsterMind = 3;
        int monsterMove = 0;
        int monsterHP = 30;

        //These are my declarations for Form2 class above

        public Form2()
        {
            InitializeComponent();
        }

        //This is where it will end both Form2 and Form1 when Form2 is closed

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        //Here is where I first set up my display to pave for the rest of the game below
        //Because I went into a first person perspective instead of top down like in the movement beta
        //My image displayer algorithm had to change

        private void Form2_Load(object sender, EventArgs e)
        {
            songPlayer.Ctlcontrols.play();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            char[,] level = new char[10, 10];
            int inputNumber = 0;
            for (int rows = 0; rows < 10; rows++)
                for (int columns = 0; columns < 10; columns++)
                {
                    level[rows, columns] = input[inputNumber];
                    inputNumber++;
                }

            lblRoomNumberDisplay.Text = Convert.ToString("X:" + width + " " + "Y:" + heightDisplay);
            lblDirectionDisplay.Text = Convert.ToString(direction);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Anchor = AnchorStyles.None;

            if (direction == 'N')
            {
                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
            }

            if (direction == 'S')
            {
                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
            }

            if (direction == 'W')
            {
                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
            }

            if (direction == 'E')
            {
                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
            }
            lblStengthStatDisplay.Text = Convert.ToString("- " + playerStrength);
            lblSpeedStatDisplay.Text = Convert.ToString("- " + playerSpeed);
            lblMindStatDisplay.Text = Convert.ToString("- " + playerMind);

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(keyReadings);
        }
        //Here is where I first set up my display to pave for the rest of the game above

        //Starting here is where I researched how to use key bindings to move in my game

        protected override bool ProcessDialogKey(Keys keyData)
        {
            return false;
        }

        //This switch statement activates the movement buttons when the arrow keys are pressed

        void keyReadings(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.Left:
                    button2.Focus();
                    button2.PerformClick();
                    break;
                case Keys.Right:
                    button4.Focus();
                    button4.PerformClick();
                    break;
                case Keys.Up:
                    button1.Focus();
                    button1.PerformClick();
                    break;
                case Keys.Down:
                    button3.Focus();
                    button3.PerformClick();
                    break;
            }
        }

        //Ending here is where I researched how to use key bindings to move in my game

        //This is the first button or the move foward button
        //Uses same formula for displaying the map like in the form2 load

        private void button1_Click(object sender, EventArgs e)
        {
            int previousHeight = height;
            int previousWidth = width;
            Random eventChance = new Random();

            char[,] level = new char[10, 10];
            int inputNumber = 0;
            for (int rows = 0; rows < 10; rows++)
                for (int columns = 0; columns < 10; columns++)
                {
                    level[rows, columns] = input[inputNumber];
                    inputNumber++;
                }

            lblRoomNumberDisplay.Text = Convert.ToString(level[height, width]);
            lblDirectionDisplay.Text = Convert.ToString(direction);

            lblStoryText.Text = "You move foward";

            switch (level[height, width])
            {
                case '1':
                    if (direction == 'N')
                    {
                        height = height - 1;
                        heightDisplay = heightDisplay + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else
                        lblStoryText.Text = "You attempt to move foward, but run into a wall";
                    break;
                case '2':
                    if (direction == 'E')
                    {
                        width = width + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else
                        lblStoryText.Text = "You attempt to move foward, but run into a wall";
                    break;
                case '3':
                    if (direction == 'S')
                    {
                        height = height + 1;
                        heightDisplay = heightDisplay - 1;
                        playerMovement = playerMovement - 1;
                    }
                    else
                        lblStoryText.Text = "You attempt to move foward, but run into a wall";
                    break;
                case '4':
                    if (direction == 'W')
                    {
                        width = width - 1;
                        playerMovement = playerMovement - 1;
                    }
                    else
                        lblStoryText.Text = "You attempt to move foward, but run into a wall";
                    break;
                case '5':
                    if (direction == 'S')
                    {
                        lblStoryText.Text = "You attempt to move foward, but run into a wall";
                    }
                    else if (direction == 'N')
                    {
                        height = height - 1;
                        heightDisplay = heightDisplay + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'E')
                    {
                        width = width + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'W')
                    {
                        width = width - 1;
                        playerMovement = playerMovement - 1;
                    };
                    break;
                case '6':
                    if (direction == 'W')
                    {
                        lblStoryText.Text = "You attempt to move foward, but run into a wall";
                    }
                    else if (direction == 'N')
                    {
                        height = height - 1;
                        heightDisplay = heightDisplay + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'E')
                    {
                        width = width + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'S')
                    {
                        height = height + 1;
                        heightDisplay = heightDisplay - 1;
                        playerMovement = playerMovement - 1;
                    };
                    break;
                case '7':
                    if (direction == 'N')
                    {
                        lblStoryText.Text = "You attempt to move foward, but run into a wall";
                    }
                    else if (direction == 'S')
                    {
                        height = height + 1;
                        heightDisplay = heightDisplay - 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'E')
                    {
                        width = width + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'W')
                    {
                        width = width - 1;
                        playerMovement = playerMovement - 1;
                    };
                    break;
                case '8':
                    if (direction == 'E')
                    {
                        lblStoryText.Text = "You attempt to move foward, but run into a wall";
                    }
                    else if (direction == 'N')
                    {
                        height = height - 1;
                        heightDisplay = heightDisplay + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'S')
                    {
                        height = height + 1;
                        heightDisplay = heightDisplay - 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'W')
                    {
                        width = width - 1;
                        playerMovement = playerMovement - 1;
                    };
                    break;
                case '9':
                    if (direction == 'E')
                    {
                        width = width + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'N')
                    {
                        height = height - 1;
                        heightDisplay = heightDisplay + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'S')
                    {
                        height = height + 1;
                        heightDisplay = heightDisplay - 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'W')
                    {
                        width = width - 1;
                        playerMovement = playerMovement - 1;
                    };
                    break;
                case 'a':

                    if (direction == 'N')
                    {
                        height = height - 1;
                        heightDisplay = heightDisplay + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'E')
                    {
                        width = width + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else
                        lblStoryText.Text = "You attempt to move foward, but run into a wall";
                    break;
                case 'b':
                    if (direction == 'S')
                    {
                        height = height + 1;
                        heightDisplay = heightDisplay - 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'E')
                    {
                        width = width + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else
                        lblStoryText.Text = "You attempt to move foward, but run into a wall";
                    break;
                case 'c':
                    if (direction == 'S')
                    {
                        height = height + 1;
                        heightDisplay = heightDisplay - 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'W')
                    {
                        width = width - 1;
                        playerMovement = playerMovement - 1;
                    }
                    else
                        lblStoryText.Text = "You attempt to move foward, but run into a wall";
                    break;
                case 'd':
                    if (direction == 'N')
                    {
                        height = height - 1;
                        heightDisplay = heightDisplay + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'W')
                    {
                        width = width - 1;
                        playerMovement = playerMovement - 1;
                    }
                    else
                        lblStoryText.Text = "You attempt to move foward, but run into a wall";
                    break;
                case 'e':
                    if (direction == 'S')
                    {
                        height = height + 1;
                        heightDisplay = heightDisplay - 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'N')
                    {
                        height = height - 1;
                        heightDisplay = heightDisplay + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else
                        lblStoryText.Text = "You attempt to move foward, but run into a wall";
                    break;
                case 'f':
                    if (direction == 'E')
                    {
                        width = width + 1;
                        playerMovement = playerMovement - 1;
                    }
                    else if (direction == 'W')
                    {
                        width = width - 1;
                        playerMovement = playerMovement - 1;
                    }
                    else
                        lblStoryText.Text = "You attempt to move foward, but run into a wall";
                    break;
            }
            lblRoomNumberDisplay.Text = Convert.ToString("X:" + width + " " + "Y:" + heightDisplay);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Anchor = AnchorStyles.None;
            if (direction == 'N')
            {
                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
            }

            if (direction == 'S')
            {
                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
            }

            if (direction == 'W')
            {
                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
            }

            if (direction == 'E')
            {
                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
            }

            //Below is all the triggers for the Main Events in the game

            if (chapterRoom == 0 && ((width == 1) && (height == 8)))
            {
                lblStoryText.Text = "You found the Chapter House.";
                mainEvent = 1;
                mainEventCounter = mainEventCounter + 1;
                mainEventTrigger = 1;
                chapterRoom = 1;
                btnMind.Enabled = true;
                btnMind.BackColor = Color.RoyalBlue;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnMap.Enabled = false;
                btnInventory.Enabled = false;
                btnAttack.Enabled = false;
                btnAttack.BackColor = Color.Transparent;
                btnInventory.BackColor = Color.Transparent;
                System.Threading.Thread.Sleep(1000);
            }
            if (relicRoom == 0 && ((width == 8) && (height == 8)))
            {
                lblStoryText.Text = "You found the Relic Room.";
                mainEvent = 2;
                mainEventCounter = mainEventCounter + 1;
                mainEventTrigger = 1;
                relicRoom = 1;
                btnStrength.Enabled = true;
                btnStrength.BackColor = Color.Red;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnMap.Enabled = false;
                btnInventory.Enabled = false;
                btnAttack.Enabled = false;
                btnAttack.BackColor = Color.Transparent;
                btnInventory.BackColor = Color.Transparent;
                System.Threading.Thread.Sleep(1000);
            }
            if (boneRoom == 0 && ((width == 6) && (height == 2)))
            {
                lblStoryText.Text = "You found the 'Bone' Room.";
                mainEvent = 3;
                mainEventCounter = mainEventCounter + 1;
                mainEventTrigger = 1;
                boneRoom = 1;
                btnSpeed.Enabled = true;
                btnSpeed.BackColor = Color.LightGreen;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnMap.Enabled = false;
                btnInventory.Enabled = false;
                btnAttack.Enabled = false;
                btnAttack.BackColor = Color.Transparent;
                btnInventory.BackColor = Color.Transparent;
                System.Threading.Thread.Sleep(1000);

            }
            if ((width == 3) && (height == 9))
            {
                lblStoryText.Text = "You trying to leave? If so do you want to force it open or pick the lock?";
                btnStrength.Enabled = true;
                btnStrength.BackColor = Color.Red;
                btnMind.Enabled = true;
                btnMind.BackColor = Color.RoyalBlue;
                mainEvent = 4;
                System.Threading.Thread.Sleep(1000);
                mainEventTrigger = 1;
            }


            //Below is all the triggers for the Main Events in the game

            //Below is all the triggers for the Minor Events in the game
            //I have it set up so a Minor and Major event or Battle can happen at the same time

            if (eventCooldown >= 1)
            {
                eventCooldown = eventCooldown - 1;
            }
            if (mainEventTrigger == 0)
            {
                    if (previousWidth != width || previousHeight != height)
                {
                    if (eventCooldown == 0)
                        if (playerMovement != 0)
                        {
                            {
                                int eventTrigger = 1;
                                int eventRoller = eventChance.Next(1, 10);



                                if (eventTrigger == eventRoller)
                                {
                                    eventViewer();
                                    minorEventCounter = minorEventCounter + 1;
                                    eventCooldown = eventChance.Next(1, 3);

                                }
                            }
                        }
                }
            }

            //Above is all the triggers for the Minor Events in the game

            //This is one of the values to prevent Main and Minor events from overlapping
            mainEventTrigger = 0;

            //This is to display when the wraith is in the same room as you
            if ((monsterHeight == height) && (monsterWidth == width))
            {
                pictureBox2.Image = Image.FromFile("Wraith.png");
                player1.Play();
                pictureBox2.Visible = true;
                btnAttack.Enabled = true;
                btnAttack.BackColor = Color.Indigo;
            }

            if ((monsterHeight != height) || (monsterWidth != width))
            {
                pictureBox2.Image = Image.FromFile("Wraith.png");
                pictureBox2.Visible = false;
                btnAttack.Enabled = false;
                btnAttack.BackColor = Color.Transparent;
            }

            //This is how the wraith spawns and moves around
            //I have it set up so that the Wraith spawns if you trigger 7 minor events or all 3 main events
            //The wraith doesn't begin moving until 1 turn after it spawns
            //Once the player runs out of movement the Wraith will begin to chase
            //The Wraith (Due to my laziness) can move through walls
            //To give the players a chance I made it so the Wraith attacks once per turn
            //I also made it so if the player gives damage to the Wraith, the Wraith until its turn comes up again
            if (playerMovement == 0)
            {

                attackAbility = 0;

                if ((minorEventCounter >= monsterSpawnerMinor) || (mainEventCounter == monsterSpawnerMain))
                    {
                        //monster moves

                        monsterMove = eventChance.Next(1, (monsterSpeed * 2));

                        if (monsterSpawned == 0)
                        {
                        player3.Play();
                        lblStoryText.Text = "As you walk through this lifeless halls you start to feel a chill down your spine." + Environment.NewLine +
                        "Shortly after you hear a ear splitting sream and you feel its intensity in your soul." + Environment.NewLine +
                        "Something in this Crypt just emerged and it doesn't sound friendly" + Environment.NewLine +
                        Environment.NewLine +
                        "The Wraith has spawned!";
                        monsterMove = 0;
                        System.Threading.Thread.Sleep(1000);
                        monsterSpawned = 1;
                        }

                    button1.Enabled = false;

                    //This is the algorithm for the Wraiths movement below
                        while ((monsterMove > 0) && (monsterHeight != height) || (monsterWidth != width))
                        {

                            if (height != monsterHeight)
                            {
                                if (height > monsterHeight)
                                {
                                    monsterHeight = monsterHeight + 1;
                                    monsterMove = monsterMove - 1;
                                }

                                if (height < monsterHeight)
                                {
                                    monsterHeight = monsterHeight - 1;
                                    monsterMove = monsterMove - 1;
                                }
                            }
                            if (width != monsterWidth)
                            {
                                if (width > monsterWidth)
                                {
                                    monsterWidth = monsterWidth + 1;
                                    monsterMove = monsterMove - 1;
                                }

                                if (width < monsterWidth)
                                {
                                    monsterWidth = monsterWidth - 1;
                                    monsterMove = monsterMove - 1;
                                }
                            }

                        //This is the algorithm for the Wraiths movement above
                        //Below is how the Wraith knows to attaack

                        if ((monsterHeight == height) && (monsterWidth == width))
                            {
                                monsterMove = 0;
                                button1.Enabled = true;

                                pictureBox2.Image = Image.FromFile("Wraith.png");
                            player1.Play();
                            pictureBox2.Visible = true;

                                btnAttack.Enabled = true;
                            btnAttack.BackColor = Color.Indigo;

                            int monsterAttack = eventChance.Next(1, (monsterStrength * 2));
                                int playerAttack = eventChance.Next(1, (playerStrength * 2));


                                if (monsterAttack > playerAttack)
                                {
                                if (item2 == 0)
                                {
                                    playerHP = playerHP - (monsterAttack - playerAttack);
                                }

                                if (item2 == 1)
                                {
                                    playerHP = playerHP - ((monsterAttack - playerAttack) - 1);
                                }
                                lblStoryText.Text = "The monster attacks you!" + Environment.NewLine +
                                        "It attacks you for " + Convert.ToString(monsterAttack - playerAttack) + " damage!";
                                lblPlayerHP.Text = Convert.ToString(playerHP);
                                System.Threading.Thread.Sleep(1000);
                            }
                                if (monsterAttack < playerAttack)
                                {
                                    monsterHP = monsterHP - (playerAttack - monsterAttack);
                                    lblStoryText.Text = "The monster attacks you!" + Environment.NewLine +
                                        "You counter attack for " + Convert.ToString(playerAttack - monsterAttack) + " damage!";
                                btnAttack.Enabled = false;
                                btnAttack.BackColor = Color.Transparent;
                                monsterHeight = eventChance.Next(10);
                                monsterWidth = eventChance.Next(10);
                                pictureBox2.Visible = false;
                                System.Threading.Thread.Sleep(1000);
                            }
                                if (monsterAttack == playerAttack)
                                {
                                    lblStoryText.Text = "The monster attacks you" + Environment.NewLine +
                                        "You deflect the attack! " + Environment.NewLine +
                                        "No damage taken or given!";
                                System.Threading.Thread.Sleep(1000);
                            }

                            }

                        //Above is how the Wraith knows to attack
                        }
                        //This is to prevent the monster from tag onto the player after it attacks
                    monsterMove = 0;
                    }

                heightDisplay = 9 - height;
                lblRoomNumberDisplay.Text = Convert.ToString("X:" + width + " " + "Y:" + heightDisplay);

                //Below enables the player to start their turn
                if (monsterMove == 0)
                {
                    button1.Enabled = true;
                    playerMovement = eventChance.Next(1, (playerSpeed * 2));
                }
                //above enables the player to start their turn
                if (monsterSpawned == 1)
                {
                    player3.Play();
                    lblStoryText.Text = "As you walk through this lifeless halls you start to feel a chill down your spine." + Environment.NewLine +
                        "Shortly after you hear a ear splitting sream and you feel its intensity in your soul." + Environment.NewLine +
                        "Something in this Crypt just emerged and it doesn't sound friendly" + Environment.NewLine +
                        Environment.NewLine +
                        "The Wraith has spawned!";
                    monsterSpawned = 2;
                }
            }
            System.Threading.Thread.Sleep(1000);

            //This is to display the Main Rooms

            if (direction == 'N' && ((width == 6) && (height == 2)))
            {
                pictureBox1.Image = Image.FromFile("boneRoom.png");
            }
            if (direction == 'S' && ((width == 8) && (height == 8)))
            {
                pictureBox1.Image = Image.FromFile("relicRoom.png");
            }
            if (direction == 'S' && ((width == 1) && (height == 8)))
            {
                pictureBox1.Image = Image.FromFile("chapterRoom.png");
            }
            if (direction == 'S' &&(width == 3) && (height == 9))
            {
                pictureBox1.Image = Image.FromFile("exit.png");
            }

            //Below is the Game Over system for losing

            if (playerHP <= 0)
            {
                if (item10 == 1)
                {
                    playerHP = 1;
                    lblStoryText.Text = "Your charm broke!";
                    item10 = 0;
                }
                else
                {


                    if (item10used == 1 || item10 == 0)
                    {

                        if (item4 == 1)
                        {
                            playerHP = 10;
                        }
                        else
                        {
                            //game over
                            gameOver = 1;
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = false;
                            button4.Enabled = false;
                            btnMap.Enabled = false;
                            btnInventory.Enabled = false;
                            btnAttack.Enabled = false;
                            btnStrength.Enabled = true;
                            btnStrength.BackColor = Color.Red;
                            btnMind.Enabled = true;
                            btnMind.BackColor = Color.RoyalBlue;
                            lblStoryText.Text = "YOU LOSE" + Environment.NewLine +
                            Environment.NewLine + "You die here and nobody ever found the body." + Environment.NewLine +
                            Environment.NewLine + "Press Strength to play again or Press Mind to Quit.";
                        }
                    }
                }
            }

            //Above is the Game Over system for losing

            if (mainEvent == 8)
            {
                pictureBox1.Image = Image.FromFile("Black.png");
                mainEvent = 0;
            }

            //Below is the Game Over system for winning
            if (monsterHP <= 0)
            {
                //you win
                gameOver = 2;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnMap.Enabled = false;
                btnInventory.Enabled = false;
                btnAttack.Enabled = false;
                btnStrength.Enabled = true;
                btnStrength.BackColor = Color.Red;
                btnMind.Enabled = true;
                btnMind.BackColor = Color.RoyalBlue;
                lblStoryText.Text = "YOU WIN" + Environment.NewLine +
                        Environment.NewLine + "Before you struck the final blow you took a picture of the Wraith. " +
                        "Proving to the world that the Paranormal are real." + Environment.NewLine +
                        "Unless they think you used photshop, they never said it would be easy to prove with proof." + Environment.NewLine +
                        Environment.NewLine + "Press Strength to play again or Press Mind to Quit.";
            }
            //Above is the Game Over system for winning
            if (attackAbility == 1)
            {
                btnAttack.Enabled = false;
                btnAttack.BackColor = Color.Transparent;
            }

        }

        //This button allows you to turn left
        //Has a similar formula to display the level as moving foward

        private void button2_Click(object sender, EventArgs e)
        {

            char[,] level = new char[10, 10];
            int inputNumber = 0;
            for (int rows = 0; rows < 10; rows++)
                for (int columns = 0; columns < 10; columns++)
                {
                    level[rows, columns] = input[inputNumber];
                    inputNumber++;
                }

            if (direction == 'N')
            {
                direction = 'W';

                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }

            }
            else if (direction == 'S')
            {
                direction = 'E';

                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }

            }
            else if (direction == 'E')
            {
                direction = 'N';

                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }

            }
            else if (direction == 'W')
            {
                direction = 'S';

                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }

            }

            if (direction == 'N' && ((width == 6) && (height == 2)))
            {
                pictureBox1.Image = Image.FromFile("boneRoom.png");
            }
            if (direction == 'S' && ((width == 8) && (height == 8)))
            {
                pictureBox1.Image = Image.FromFile("relicRoom.png");
            }
            if (direction == 'S' && ((width == 1) && (height == 8)))
            {
                pictureBox1.Image = Image.FromFile("chapterRoom.png");
            }
            if (direction == 'S' && (width == 3) && (height == 9))
            {
                pictureBox1.Image = Image.FromFile("exit.png");
            }

            if (direction != 'N' && ((width == 3) && (height == 9)))
            {
                btnStrength.Enabled = false;
                btnStrength.BackColor = Color.Transparent;
                btnMind.Enabled = false;
                btnMind.BackColor = Color.Transparent;
                mainEvent = 0;
            }

            lblDirectionDisplay.Text = Convert.ToString(direction);
            lblStoryText.Text = "You turned Left";
            System.Threading.Thread.Sleep(500);
        }


        //This button allows you to turn right
        //Has a similar formula to display the level as moving foward
        private void button3_Click(object sender, EventArgs e)
        {

            char[,] level = new char[10, 10];
            int inputNumber = 0;
            for (int rows = 0; rows < 10; rows++)
                for (int columns = 0; columns < 10; columns++)
                {
                    level[rows, columns] = input[inputNumber];
                    inputNumber++;
                }

            if (direction == 'N')
            {
                direction = 'S';

                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }


            }
            else if (direction == 'S')
            {
                direction = 'N';

                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }

            }
            else if (direction == 'E')
            {
                direction = 'W';

                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }

            }
            else if (direction == 'W')
            {
                direction = 'E';

                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }

            }

            if (direction == 'N' && ((width == 6) && (height == 2)))
            {
                pictureBox1.Image = Image.FromFile("boneRoom.png");
            }
            if (direction == 'S' && ((width == 8) && (height == 8)))
            {
                pictureBox1.Image = Image.FromFile("relicRoom.png");
            }
            if (direction == 'S' && ((width == 1) && (height == 8)))
            {
                pictureBox1.Image = Image.FromFile("chapterRoom.png");
            }
            if (direction == 'S' && (width == 3) && (height == 9))
            {
                pictureBox1.Image = Image.FromFile("exit.png");
            }

            if (direction != 'N' && ((width == 3) && (height == 9)))
            {
                btnStrength.Enabled = false;
                btnStrength.BackColor = Color.Transparent;
                btnMind.Enabled = false;
                btnMind.BackColor = Color.Transparent;
                mainEvent = 0;
            }


            lblDirectionDisplay.Text = Convert.ToString(direction);
            lblStoryText.Text = "You turned around";
            System.Threading.Thread.Sleep(500);
        }

        //This button allows you to turn around
        //Has a similar formula to display the level as moving foward
        private void button4_Click(object sender, EventArgs e)
        {

            char[,] level = new char[10, 10];
            int inputNumber = 0;
            for (int rows = 0; rows < 10; rows++)
                for (int columns = 0; columns < 10; columns++)
                {
                    level[rows, columns] = input[inputNumber];
                    inputNumber++;
                }

            if (direction == 'N')
            {
                direction = 'E';

                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }

            }
            else if (direction == 'S')
            {
                direction = 'W';

                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }

            }
            else if (direction == 'E')
            {
                direction = 'S';

                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }

            }
            else if (direction == 'W')
            {
                direction = 'N';

                if (level[height, width] == '1')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == '2')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '3')
                {
                    pictureBox1.Image = Image.FromFile("Map1.png");
                }
                if (level[height, width] == '4')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }
                if (level[height, width] == '5')
                {
                    pictureBox1.Image = Image.FromFile("Map9.png");
                }
                if (level[height, width] == '6')
                {
                    pictureBox1.Image = Image.FromFile("Map2.png");
                }
                if (level[height, width] == '7')
                {
                    pictureBox1.Image = Image.FromFile("Map3.png");
                }
                if (level[height, width] == '8')
                {
                    pictureBox1.Image = Image.FromFile("Map4.png");
                }
                if (level[height, width] == '9')
                {
                    pictureBox1.Image = Image.FromFile("Map8.png");
                }
                if (level[height, width] == 'a')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'b')
                {
                    pictureBox1.Image = Image.FromFile("Map5.png");
                }
                if (level[height, width] == 'c')
                {
                    pictureBox1.Image = Image.FromFile("Map6.png");
                }
                if (level[height, width] == 'd')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'e')
                {
                    pictureBox1.Image = Image.FromFile("Map7.png");
                }
                if (level[height, width] == 'f')
                {
                    pictureBox1.Image = Image.FromFile("MapWall.png");
                }

            }

            if (direction == 'N' && ((width == 6) && (height == 2)))
            {
                pictureBox1.Image = Image.FromFile("boneRoom.png");
            }
            if (direction == 'S' && ((width == 8) && (height == 8)))
            {
                pictureBox1.Image = Image.FromFile("relicRoom.png");
            }
            if (direction == 'S' && ((width == 1) && (height == 8)))
            {
                pictureBox1.Image = Image.FromFile("chapterRoom.png");
            }
            if (direction == 'S' && (width == 3) && (height == 9))
            {
                pictureBox1.Image = Image.FromFile("exit.png");
            }


            if (direction != 'N' && ((width == 3) && (height == 9)))
            {
                btnStrength.Enabled = false;
                btnStrength.BackColor = Color.Transparent;
                btnMind.Enabled = false;
                btnMind.BackColor = Color.Transparent;
                mainEvent = 0;
            }

            lblDirectionDisplay.Text = Convert.ToString(direction);
            lblStoryText.Text = "You turned Right";
            System.Threading.Thread.Sleep(500);
        }

        // This is how items are choosen and given to the player
        // Do to time I made the all passives
        void itemRoullette()
        {
            if (itemPicker.Count != 0)
            {
                btnInventory.Enabled = true;
                btnInventory.BackColor = Color.Yellow;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnMap.Enabled = false;
                btnAttack.Enabled = false;
                btnAttack.BackColor = Color.Transparent;

            }
            else
            {
                lblStoryText.Text = "You got nothing";
            }
        }

        // This is how items are lost for 1 event
        void itemLoss()
        {
            Random itemLoss = new Random();
            int itemPicked = itemLoss.Next(itemLoser.Count);
            if (itemPicked == 1)
            {
                if (item1 == 0)
                {
                    itemLoser.Remove(itemLoser[itemPicked]);
                    this.itemLoss();
                }
                else
                {
                    lblStoryText.Text = "You lost your sword!";
                    item1 = 0;
                }
            }
            if (itemPicked == 4)
            {
                if (item4 == 0)
                {
                    itemLoser.Remove(itemLoser[itemPicked]);
                    this.itemLoss();
                }
                else
                {
                    lblStoryText.Text = "You lost your feather!";
                    item4 = 0;
                }
            }
            if (itemPicked == 5)
            {
                if (item5 == 0)
                {
                    itemLoser.Remove(itemLoser[itemPicked]);
                    this.itemLoss();
                }
                else
                {
                    lblStoryText.Text = "You lost the contraption!";
                    item5 = 0;
                }
            }
            if (itemPicked == 6)
            {
                if (item6 == 0)
                {
                    itemLoser.Remove(itemLoser[itemPicked]);
                    this.itemLoss();
                }
                else
                {
                    lblStoryText.Text = "You lost your gun!";
                    item6 = 0;
                }
            }
            if (itemPicked == 7)
            {
                if (item7 == 0)
                {
                    itemLoser.Remove(itemLoser[itemPicked]);
                    this.itemLoss();
                }
                else

                {
                    lblStoryText.Text = "You lost your green stone!";
                    item7 = 0;
                }
            }
            if (itemPicked == 8)
            {
                if (item8 == 0)
                {
                    itemLoser.Remove(itemLoser[itemPicked]);
                    this.itemLoss();
                }
                else
                {
                    lblStoryText.Text = "You lost your red stone!";
                    item8 = 0;
                }
            }
            if (itemPicked == 9)
            {
                if (item9 == 0)
                {
                    itemLoser.Remove(itemLoser[itemPicked]);
                    this.itemLoss();
                }
                else
                {
                    lblStoryText.Text = "You lost your blue stone!";
                    item9 = 0;
                }
            }
            if (itemPicked == 10)
            {
                if (item10 == 0)
                {
                    itemLoser.Remove(itemLoser[itemPicked]);
                    this.itemLoss();
                }
                else
                {
                    lblStoryText.Text = "You lost your charm necklace!";
                    item10 = 0;
                }
            }

        }


        // This is how Minor Events are choosen and played
        void eventViewer()
        {
            Random eventChooser = new Random();
          
                if (eventPicker.Count != 0)
                {
                    eventSelecter = eventChooser.Next((eventPicker.Count));
                currentEvent = eventPicker[eventSelecter];

                    if (currentEvent == 21)
                    {
                        lblStoryText.Text = "How long have you been here?" + Environment.NewLine +
                        "Luckily nearby stone slabs have already been makeshifted into a bench " + Environment.NewLine +
                        "to help cure your exhaustion." + Environment.NewLine +
                        "After a short break you feel something under the bench grab your leg!"+ Environment.NewLine + 
                        "What do you respond with?";
                    btnStrength.Enabled = true;
                    btnSpeed.Enabled = true;
                    btnStrength.BackColor = Color.Red;
                    btnSpeed.BackColor = Color.LightGreen;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                    btnInventory.BackColor = Color.Transparent;
                }
                    if (currentEvent == 2)
                    {
                        lblStoryText.Text = "Walking through the ancient crypts you notice how old and worn the walls are." + Environment.NewLine + 
                        "You wonder how this place is still safe to explore." + Environment.NewLine + 
                        "Thats when the strangest thing happens and you hear the ceiling begin to collapse" + Environment.NewLine +
                        "What do you respond with?";
                    btnStrength.Enabled = true;
                    btnSpeed.Enabled = true;
                    btnStrength.BackColor = Color.Red;
                    btnSpeed.BackColor = Color.LightGreen;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                }
                    if (currentEvent == 3)
                    {
                    lblStoryText.Text = "You find yourself entering this room when you spot something glimmer in the corner." + Environment.NewLine +
                    "As you appraoch you spot a skeleton arm hanging over an slightly open stone coffin." + Environment.NewLine +
                    "When you look inside you notice something that could be useful." + Environment.NewLine +
                    "You tell yourself that whatever that is you need it no matter what" + Environment.NewLine +
                    "What do you respond with";
                    btnStrength.Enabled = true;
                    btnMind.Enabled = true;
                    btnStrength.BackColor = Color.Red;
                    btnMind.BackColor = Color.RoyalBlue;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                    //Strength and Mind and Item
                }
                    if (currentEvent == 4)
                    {
                        lblStoryText.Text = "You move through to the next room but, something is off." + Environment.NewLine +
                    "You see the crypt back when it was first being built." + Environment.NewLine +
                    "You notice that someone was trying to hide something behind some stone bricks." + Environment.NewLine +
                    "After you realize what happened you find the room to be just as worn as the rest of the crypt." + Environment.NewLine +
                    "What do you respond with";
                    btnMind.Enabled = true;
                    btnMind.BackColor = Color.RoyalBlue;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                    //Mind and Item
                }
                    if (currentEvent == 5)
                    {
                        lblStoryText.Text = "You stumble into an empty hallway.You hear nothing from the crypt." + Environment.NewLine +
                    "All is quiet, until suddenly you hear a ghostly howl from the other end of the hallway." + Environment.NewLine +
                    "As you cover you ears you notice a shadow come towards and enter you." + Environment.NewLine +
                    "You must resist!" + Environment.NewLine +
                    "What do you respond with";
                    //Strength and Speed and Mind
                    btnStrength.Enabled = true;
                    btnSpeed.Enabled = true;
                    btnMind.Enabled = true;
                    btnStrength.BackColor = Color.Red;
                    btnSpeed.BackColor = Color.LightGreen;
                    btnMind.BackColor = Color.RoyalBlue;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;

                }
                    if (currentEvent == 6)
                    {
                        lblStoryText.Text = "As you find walk through you notice two men talking " + Environment.NewLine +
                    "with their backs towards you." + Environment.NewLine +
                    "When is the last time you've talked to anyone after you entered the crypt." + Environment.NewLine +
                    "But something in the back of you mind is telling you that they aren't real." + Environment.NewLine +
                    "What do you respond with"; ;
                    btnMind.Enabled = true;
                    btnMind.BackColor = Color.RoyalBlue;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                }
                    if (currentEvent == 7)
                    {
                        lblStoryText.Text = "Exhausted from investigating you sit on the floor with your back on the wall." + Environment.NewLine +
                        "back on the wall. You soon find that you have fallen asleep and have waken up to" + Environment.NewLine +
                        "spider the size of a baseball crawling on you shirt." + Environment.NewLine +
                        "What do you respond with?";
                    btnSpeed.Enabled = true;
                    btnMind.Enabled = true;
                    btnSpeed.BackColor = Color.LightGreen;
                    btnMind.BackColor = Color.RoyalBlue;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                }
                    if (currentEvent == 8)
                    {
                    Random travel = new Random();
                        lblStoryText.Text = "You enter the room with no problem." + Environment.NewLine +
                        "Until you turn around and find that wasn't the room you just came from" + Environment.NewLine +
                        "Where are you?";
                    height = travel.Next(1, 4);
                    width = travel.Next(6);
                    heightDisplay = 9 - height;
                    lblRoomNumberDisplay.Text = Convert.ToString("X:" + width + " " + "Y:" + heightDisplay);
                    System.Threading.Thread.Sleep(1000);
                    pictureBox1.Image = Image.FromFile("Black.png");
                    //travel
                }
                    if (currentEvent == 9)
                    {
                        lblStoryText.Text = "You traverse onward with only the sound of your own footsteps." + Environment.NewLine +
                        "Then you realize that its not only your footsteps that you hear." + Environment.NewLine +
                        "What do you respond with?";
                    btnStrength.Enabled = true;
                    btnSpeed.Enabled = true;
                    btnMind.Enabled = true;
                    btnStrength.BackColor = Color.Red;
                    btnSpeed.BackColor = Color.LightGreen;
                    btnMind.BackColor = Color.RoyalBlue;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                }
                    if (currentEvent == 10)
                    {
                        lblStoryText.Text = "The only thing that brings comfort is that you are alone." + Environment.NewLine +
                        "That is when you see the giant rat coming right at you with its mouth open" + Environment.NewLine +
                        "and it's foaming." + Environment.NewLine +
                        "What do you respond with?";
                    btnStrength.Enabled = true;
                    btnStrength.BackColor = Color.Red;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                }
                    if (currentEvent == 11)
                    {
                        lblStoryText.Text = "What could happen to you while in the crypt?" + Environment.NewLine +
                        "Nothing but the dead in these halls, or so you thought." + Environment.NewLine +
                        "You spot a graverobber diving into a nearby coffin." + Environment.NewLine +
                        "Before you can do anything he points his gun at you and fires!" + Environment.NewLine +
                        "What do you respond with?";
                    btnSpeed.Enabled = true;
                    btnSpeed.BackColor = Color.LightGreen;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                }
                    if (currentEvent == 12)
                    {
                        lblStoryText.Text = "You spot what looks like a gold covered coffin with jewels encrusted" + Environment.NewLine +
                        "on it. Then you hear a voice inside telling you to join her." + Environment.NewLine +
                        "What do you respond with?";
                    btnMind.Enabled = true;
                    btnMind.BackColor = Color.RoyalBlue;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                }
                if (currentEvent == 13)
                {
                    lblStoryText.Text = "You lean your hand against the wall to take a short breather when you feel" + Environment.NewLine +
                    "the wall cave in. You found a secret button which reveals a new path" + Environment.NewLine +
                    "What do you respond with?";
                    btnMind.Enabled = true;
                    btnMind.BackColor = Color.RoyalBlue;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                    //Mind and item and travel
                }
                    if (currentEvent == 14)
                    {
                    lblStoryText.Text = "Just as you were about to move into the next room" + Environment.NewLine +
                "You hear what sounds like a woman crying." + Environment.NewLine +
                "As you approach the weeping woman you ask to help her." + Environment.NewLine +
                "But as soon as you go to help her up she turns into dust." + Environment.NewLine +
                "What do you respond with?";
                    btnMind.Enabled = true;
                    btnMind.BackColor = Color.RoyalBlue;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                }
                    if (currentEvent == 15)
                    {
                        lblStoryText.Text = "The Mayor warned you that to attempt to counter whats been howling inside " + Environment.NewLine +
                        "the crypt he has his sheirff place some bear traps to catch what ever was inside. " + Environment.NewLine +
                        "How are you suppose to see a bear trap in here it is too dark to see!" + Environment.NewLine +
                        "Just as you take your next step you foot stumbles onto something." + Environment.NewLine +
                        "What do you respond with?";
                    btnSpeed.Enabled = true;
                    btnSpeed.BackColor = Color.LightGreen;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                }
                    if (currentEvent == 16)
                    {
                        lblStoryText.Text = "This has got to be the scariest place you've visited." + Environment.NewLine +
                        "Nothing but graves and torches and children..." + Environment.NewLine +
                        "CHILDREN!? You notice a child in front of you about to cry." + Environment.NewLine +
                        "What do you respond with?";
                    btnMind.Enabled = true;
                    btnMind.BackColor = Color.RoyalBlue;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                }
                    if (currentEvent == 17)
                    {
                        lblStoryText.Text = "What an odd place for a wooden table and chairs." + Environment.NewLine +
                        "As you sit down a ghost appears in front of you shuffling some cards." + Environment.NewLine +
                        "The ghost says 'The games Blackjack, What will you wager?'" + Environment.NewLine +
                        "This isn't a good idea but you are compelled to play." + Environment.NewLine +
                        "What do you respond with?";
                    btnStrength.Enabled = true;
                    btnSpeed.Enabled = true;
                    btnMind.Enabled = true;
                    btnStrength.BackColor = Color.Red;
                    btnSpeed.BackColor = Color.LightGreen;
                    btnMind.BackColor = Color.RoyalBlue;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                }
                    if (currentEvent == 18)
                    {
                        lblStoryText.Text = "You start thinking about you life up till now." + Environment.NewLine +
                        "You persued your dream to be a Paranormal Investigator." + Environment.NewLine +
                        "Your wife is willing to live 'Just scrapping by' to let you do so" + Environment.NewLine +
                        "Maybe you should get her something nice, like some jewelry from that skeleton." + Environment.NewLine +
                        "What do you respond with?";
                    btnMind.Enabled = true;
                    btnMind.BackColor = Color.RoyalBlue;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                    //Mind (good + mind) (bad - mind + item)
                }
                    if (currentEvent == 19)
                    {
                        lblStoryText.Text = "This is what you always wanted." + Environment.NewLine +
                        "This is your big break, this is the one to put you on the map." + Environment.NewLine +
                        "While lost in thought you bump into someone, looks like someone from a security team." + Environment.NewLine +
                        "Before you can ask her what she's doing here you smell death on her." + Environment.NewLine +
                        "What do you respond with?";
                    btnStrength.Enabled = true;
                    btnSpeed.Enabled = true;
                    btnStrength.BackColor = Color.Red;
                    btnSpeed.BackColor = Color.LightGreen;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                }
                    if (currentEvent == 20)
                {
                    lblStoryText.Text = "You hear water dripping from above you. Drip. Drip. Drip." + Environment.NewLine +
                        "Getting faster and faster until the ceiling caves from in front and behind you" + Environment.NewLine +
                        "inside. Guess you have to take the debris apart to exit the room." + Environment.NewLine +
                        "That's when you notice water start to rise and you can't get out." + Environment.NewLine +
                        "What do you respond with?";
                    btnStrength.Enabled = true;
                    btnMind.Enabled = true;
                    btnStrength.BackColor = Color.Red;
                    btnMind.BackColor = Color.RoyalBlue;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnInventory.BackColor = Color.Transparent;
                    btnAttack.Enabled = false;
                    btnAttack.BackColor = Color.Transparent;
                }


                    eventPicker.Remove(eventPicker[eventSelecter]);
                }
                else
                {
                currentEvent = 0;
                lblStoryText.Text = "You've been here before!" + Environment.NewLine +
                    "You are not sure literally or figuratively" + Environment.NewLine +
                    "You've been down here too long and it is starting to get to you" + Environment.NewLine +
                    "What do you respond with?";
                btnStrength.Enabled = true;
                btnSpeed.Enabled = true;
                btnMind.Enabled = true;
                btnStrength.BackColor = Color.Red;
                btnSpeed.BackColor = Color.LightGreen;
                btnMind.BackColor = Color.RoyalBlue;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnMap.Enabled = false;
                btnInventory.Enabled = false;
                btnInventory.BackColor = Color.Transparent;
                btnAttack.Enabled = false;
                btnAttack.BackColor = Color.Transparent;
                //Strength (even or more nothing) // speed travel // Mind (even or more nothing) less is bad
            }
        }
    


        //This is the button to play and stop music
        private void Music_Click(object sender, EventArgs e)
        {

            if (music == 0)
            {

                songPlayer.Ctlcontrols.play();
                music = 1;
                btnMusic.Text = "Music Playing";
            }
            else if (music == 1)
            {

                songPlayer.Ctlcontrols.pause();
                music = 0;
                btnMusic.Text = "Music Paused";
            }
        }


        //This is the button for opening the map
        private void btnMap_Click(object sender, EventArgs e)
        {
            if (mapChecker == 1) {

                char[,] level = new char[10, 10];
                int inputNumber = 0;
                for (int rows = 0; rows < 10; rows++)
                    for (int columns = 0; columns < 10; columns++)
                    {
                        level[rows, columns] = input[inputNumber];
                        inputNumber++;
                    }

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Anchor = AnchorStyles.None;

                if (direction == 'N')
                {
                    if (level[height, width] == '1')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                    if (level[height, width] == '2')
                    {
                        pictureBox1.Image = Image.FromFile("MapWall.png");
                    }
                    if (level[height, width] == '3')
                    {
                        pictureBox1.Image = Image.FromFile("Map1.png");
                    }
                    if (level[height, width] == '4')
                    {
                        pictureBox1.Image = Image.FromFile("MapWall.png");
                    }
                    if (level[height, width] == '5')
                    {
                        pictureBox1.Image = Image.FromFile("Map9.png");
                    }
                    if (level[height, width] == '6')
                    {
                        pictureBox1.Image = Image.FromFile("Map2.png");
                    }
                    if (level[height, width] == '7')
                    {
                        pictureBox1.Image = Image.FromFile("Map3.png");
                    }
                    if (level[height, width] == '8')
                    {
                        pictureBox1.Image = Image.FromFile("Map4.png");
                    }
                    if (level[height, width] == '9')
                    {
                        pictureBox1.Image = Image.FromFile("Map8.png");
                    }
                    if (level[height, width] == 'a')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                    if (level[height, width] == 'b')
                    {
                        pictureBox1.Image = Image.FromFile("Map5.png");
                    }
                    if (level[height, width] == 'c')
                    {
                        pictureBox1.Image = Image.FromFile("Map6.png");
                    }
                    if (level[height, width] == 'd')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                    if (level[height, width] == 'e')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                    if (level[height, width] == 'f')
                    {
                        pictureBox1.Image = Image.FromFile("MapWall.png");
                    }
                }

                if (direction == 'S')
                {
                    if (level[height, width] == '1')
                    {
                        pictureBox1.Image = Image.FromFile("Map1.png");
                    }
                    if (level[height, width] == '2')
                    {
                        pictureBox1.Image = Image.FromFile("MapWall.png");
                    }
                    if (level[height, width] == '3')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                    if (level[height, width] == '4')
                    {
                        pictureBox1.Image = Image.FromFile("MapWall.png");
                    }
                    if (level[height, width] == '5')
                    {
                        pictureBox1.Image = Image.FromFile("Map3.png");
                    }
                    if (level[height, width] == '6')
                    {
                        pictureBox1.Image = Image.FromFile("Map4.png");
                    }
                    if (level[height, width] == '7')
                    {
                        pictureBox1.Image = Image.FromFile("Map9.png");
                    }
                    if (level[height, width] == '8')
                    {
                        pictureBox1.Image = Image.FromFile("Map2.png");
                    }
                    if (level[height, width] == '9')
                    {
                        pictureBox1.Image = Image.FromFile("Map8.png");
                    }
                    if (level[height, width] == 'a')
                    {
                        pictureBox1.Image = Image.FromFile("Map6.png");
                    }
                    if (level[height, width] == 'b')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                    if (level[height, width] == 'c')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                    if (level[height, width] == 'd')
                    {
                        pictureBox1.Image = Image.FromFile("Map5.png");
                    }
                    if (level[height, width] == 'e')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                    if (level[height, width] == 'f')
                    {
                        pictureBox1.Image = Image.FromFile("MapWall.png");
                    }
                }

                if (direction == 'W')
                {
                    if (level[height, width] == '1')
                    {
                        pictureBox1.Image = Image.FromFile("MapWall.png");
                    }
                    if (level[height, width] == '2')
                    {
                        pictureBox1.Image = Image.FromFile("Map1.png");
                    }
                    if (level[height, width] == '3')
                    {
                        pictureBox1.Image = Image.FromFile("MapWall.png");
                    }
                    if (level[height, width] == '4')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                    if (level[height, width] == '5')
                    {
                        pictureBox1.Image = Image.FromFile("Map2.png");
                    }
                    if (level[height, width] == '6')
                    {
                        pictureBox1.Image = Image.FromFile("Map3.png");
                    }
                    if (level[height, width] == '7')
                    {
                        pictureBox1.Image = Image.FromFile("Map4.png");
                    }
                    if (level[height, width] == '8')
                    {
                        pictureBox1.Image = Image.FromFile("Map9.png");
                    }
                    if (level[height, width] == '9')
                    {
                        pictureBox1.Image = Image.FromFile("Map8.png");
                    }
                    if (level[height, width] == 'a')
                    {
                        pictureBox1.Image = Image.FromFile("Map5.png");
                    }
                    if (level[height, width] == 'b')
                    {
                        pictureBox1.Image = Image.FromFile("Map6.png");
                    }
                    if (level[height, width] == 'c')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                    if (level[height, width] == 'd')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                    if (level[height, width] == 'e')
                    {
                        pictureBox1.Image = Image.FromFile("MapWall.png");
                    }
                    if (level[height, width] == 'f')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                }

                if (direction == 'E')
                {
                    if (level[height, width] == '1')
                    {
                        pictureBox1.Image = Image.FromFile("MapWall.png");
                    }
                    if (level[height, width] == '2')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                    if (level[height, width] == '3')
                    {
                        pictureBox1.Image = Image.FromFile("MapWall.png");
                    }
                    if (level[height, width] == '4')
                    {
                        pictureBox1.Image = Image.FromFile("Map1.png");
                    }
                    if (level[height, width] == '5')
                    {
                        pictureBox1.Image = Image.FromFile("Map4.png");
                    }
                    if (level[height, width] == '6')
                    {
                        pictureBox1.Image = Image.FromFile("Map9.png");
                    }
                    if (level[height, width] == '7')
                    {
                        pictureBox1.Image = Image.FromFile("Map2.png");
                    }
                    if (level[height, width] == '8')
                    {
                        pictureBox1.Image = Image.FromFile("Map3.png");
                    }
                    if (level[height, width] == '9')
                    {
                        pictureBox1.Image = Image.FromFile("Map8.png");
                    }
                    if (level[height, width] == 'a')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                    if (level[height, width] == 'b')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                    if (level[height, width] == 'c')
                    {
                        pictureBox1.Image = Image.FromFile("Map5.png");
                    }
                    if (level[height, width] == 'd')
                    {
                        pictureBox1.Image = Image.FromFile("Map6.png");
                    }
                    if (level[height, width] == 'e')
                    {
                        pictureBox1.Image = Image.FromFile("MapWall.png");
                    }
                    if (level[height, width] == 'f')
                    {
                        pictureBox1.Image = Image.FromFile("Map7.png");
                    }
                }
                mapChecker = 0;
            }
            else {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Anchor = AnchorStyles.None;
                pictureBox1.Image = Image.FromFile("gameMap.png");
                mapChecker = 1;
            }
        }

        //This is the button for Strength based Scenerios
        //The button will become Red when active
        private void btnStrength_Click(object sender, EventArgs e)
        {
            Random eventPath = new Random();
            int pathStrength = eventPath.Next(((playerStrength * 2)+1));
            int damage = 0;
            btnStrength.Enabled = false;
            btnSpeed.Enabled = false;
            btnMind.Enabled = false;
            btnStrength.BackColor = Color.Transparent;
            btnSpeed.BackColor = Color.Transparent;
            btnMind.BackColor = Color.Transparent;

            if (gameOver == 1 || gameOver == 2 || gameOver == 3)
            {
                Application.Restart();
            }

            if (currentEvent == 21)
            {
                if (pathStrength >= 4)
                {
                    lblStoryText.Text = "You yank your leg out from whatever grabbed you!";
                    System.Threading.Thread.Sleep(1000);
                }
                else {
                    damage = (eventPath.Next(2)) + 1;
                    if (item2 == 0)
                    {
                        playerHP = playerHP - damage;
                    }

                    if (item2 == 1)
                    {
                        playerHP = (playerHP - (damage - 1));
                    }
                    playerHP = playerHP - damage;
                    lblStoryText.Text = "You yank your leg out from whatever grabbed you, but " + Environment.NewLine +
                        "it digs into you and cuts deep into your calf!" + Environment.NewLine + 
                        "You take damage!";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 2)
            {
                if (pathStrength >= 5)
                {
                    damage = 1;
                    playerStrength = playerStrength + 1;
                    playerHP = playerHP - damage;
                    lblStoryText.Text = "Brace yourself before the debris falls on you." + Environment.NewLine +
                        "The debris hits you but doesn't hurt you nearly as bad as you thought." + Environment.NewLine +
                        "You must be stronger than you thought." + Environment.NewLine + 
                        "You take 1 damage and gain 1 strength!";
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    damage = (eventPath.Next(2)) + 1;
                    if (item2 == 0)
                    {
                        playerHP = playerHP - damage;
                    }

                    if (item2 == 1)
                    {
                        playerHP = (playerHP - (damage - 1));
                    }
                
                    lblStoryText.Text = "You panic and brack for impact." + Environment.NewLine +
                        "The debris knocks you against the floor." + Environment.NewLine +
                        "Why didn't you just roll out of the way?!" + Environment.NewLine +
                        "You take damage!";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 3)
            {
                if (pathStrength >= 4)
                {
                    //obtain item
                    lblStoryText.Text = "You push the stone lid until your hear a loud thud as it falls to the ground." + Environment.NewLine +
                        "You grab the item that is inside" + Environment.NewLine;
                    itemRoullette();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    lblStoryText.Text = "You attempt to take the lid off but stone is very very heavy." + Environment.NewLine +
                        "After 5 minutes in you give up." + Environment.NewLine +
                        "You think to yourself 'I don't need it anyway'";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 5)
            {
                if (pathStrength > 4)
                {
                    playerStrength = playerStrength + 1;
                    lblStoryText.Text = "You use all you strength to resist the shadow." + Environment.NewLine +
                        "Shortly you notice the shadow quickly leave your body." + Environment.NewLine +
                        "It was no match for you" + Environment.NewLine +
                        "You gain 1 strength!";
                    System.Threading.Thread.Sleep(1000);
                }
                else if (pathStrength == 4)
                {
                    lblStoryText.Text = "You use all you strength to resist the shadow." + Environment.NewLine +
                        "Shortly you notice the shadow slowly leave your body." + Environment.NewLine +
                        "That was a close one";
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    damage = (eventPath.Next(2)) + 1;
                    playerStrength = playerStrength - 1;
                    if (item2 == 0)
                    {
                        playerHP = playerHP - damage;
                    }

                    if (item2 == 1)
                    {
                        playerHP = (playerHP - (damage - 1));
                    }
                    lblStoryText.Text = "You use all you strength to resist the shadow." + Environment.NewLine +
                        "Try as you might you feel no control over you own body." + Environment.NewLine +
                        "The shadow makes you crush your foot with a nearby brick and exits your body." + Environment.NewLine +
                        "You take damage and lose 1 strength!";
                    System.Threading.Thread.Sleep(1000);
                }
            }
 
            if (currentEvent == 9)
            {
                if (pathStrength >= 4)
                {
                    playerStrength = playerStrength + 1;
                    lblStoryText.Text = "You spin around and strike at the mysterious thing behind you." + Environment.NewLine +
                        "It was a skeleton and it collapses by the force of your heavy blow." + Environment.NewLine+
                        "Thats quite the swing you got there, more so than you thought." + Environment.NewLine + 
                        "You gain 1 strength!";

                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    lblStoryText.Text = "You spin around and strike at the mysterious thing behind you." + Environment.NewLine +
                        "It was a skeleton and you completely miss." + Environment.NewLine +
                        "The skeleton appears to make the jester of laughing as it walks away.";

                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 10)
            {
                if (pathStrength >= 5) { 
                    playerStrength = playerStrength + 1;
                    lblStoryText.Text = "You fight off the giant rat with a solid kick to its foaming face." + Environment.NewLine +
                        "What a joke!" + Environment.NewLine +
                        "You gain 1 strength!";

                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    damage = (eventPath.Next(4)) + 1;
                    if (item2 == 0)
                    {
                        playerHP = playerHP - damage;
                    }

                    if (item2 == 1)
                    {
                        playerHP = (playerHP - (damage - 1));
                    }
                    lblStoryText.Text = "You prepare for a fight and attempt to defend yourself." + Environment.NewLine +
                        "The rat jumps foward and bites you in the are leaving two huge gashes, " + Environment.NewLine +
                        "The rat satisfied with your pain runs past you down the hall." + Environment.NewLine +
                        "This is going to hurt for weeks... if you don't die before than." + Environment.NewLine +
                    "You take damage.";

                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 17)
            {
                if (pathStrength > 6)
                {
                    playerStrength = playerStrength + 1;
                    lblStoryText.Text = "You win, you feel as if you could take on anything." + Environment.NewLine +
                        "You gain 1 Strength!";
                    System.Threading.Thread.Sleep(1000);
                }
                else if (pathStrength == 4 || pathStrength == 5)
                {
                    lblStoryText.Text = "You win but, the ghost vanishes before you can claim your prize." + Environment.NewLine +
                        "What a rip off.";
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    playerStrength = playerStrength - 1;
                    lblStoryText.Text = "You Lose, you feel frail as if the wind could knock you over." + Environment.NewLine +
                        "You lose 1 strength!";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 19)
            {
                if (pathStrength >= 5)
                {
                    playerStrength = playerStrength + 1;
                    lblStoryText.Text = "You strike at the 'Woman' in front of you." + Environment.NewLine +
                        " Good thing too, she was a zombie. A dead zombie now..." + Environment.NewLine +
                        "It's not moving as for as you can tell." + Environment.NewLine +
                        "The undead are no match for you!" + Environment.NewLine +
                        "You gain 1 strength!";

                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    damage = (eventPath.Next(3)) + 1;
                    if (item2 == 0)
                    {
                        playerHP = playerHP - damage;
                    }

                    if (item2 == 1)
                    {
                        playerHP = (playerHP - (damage - 1));
                    }
                    lblStoryText.Text = "You strike at the 'Woman' in front of you." + Environment.NewLine +
                        "Bad idea , she is a zombie. And is now looking to strike you" + Environment.NewLine +
                        "You go for another blow and it lands, but not before it claws at your chest." + Environment.NewLine +
                        "At least that blow finished it off" + Environment.NewLine +
                        "You take damage!";

                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 20)
            {
                lblStoryText.Text = "You keep calm and take the debris apart until you can escape.";
            }
            if (currentEvent == 0)
            {
                if (playerStrength < 3)
                {
                    playerStrength = playerStrength + 1;
                    lblStoryText.Text = "You sigh, and begin to do basic excercises to help calm your nerves." + Environment.NewLine +
                        "You gain 1 Strength!";
                    
                }
                else
                {
                    lblStoryText.Text = "You sigh, and begin to do basic excercises to help calm your nerves.";
                }
                System.Threading.Thread.Sleep(1000);
            }

            if (mainEvent == 2)
            {
                //get item
                if (playerStrength >= 3)
                {
                    mainEvent = 0;
                    playerStrength = playerStrength + 1;
                    lblStoryText.Text = "You enter into a room of many treasures." + Environment.NewLine +
                            "You remember this room houses special items that the dead were buried with." + Environment.NewLine +
                            "You know better not to steal until you bump into a ghost wearing full armor." + Environment.NewLine +
                            "He points at an item and says 'This should help you, I have no need of it.'" + Environment.NewLine +
                            "'Let me lend you strength for the trials ahead.'" + Environment.NewLine +
                            "You gain 1 strength and an item.";
                    itemRoullette();
                }

                else
                {
                    mainEvent = 0;
                    playerStrength = 3;
                    lblStoryText.Text = "You enter into a room of many treasures." + Environment.NewLine +
                            "You remember this room houses special items that the dead were buried with." + Environment.NewLine +
                            "You know better not to steal until you bump into a ghost wearing full armor." + Environment.NewLine +
                            "He points at an item and says 'This should help you, I have no need of it.'" + Environment.NewLine +
                            "'Let me lend you strength for the trials ahead.'" + Environment.NewLine +
                            "You regain your strength and an item.";
                    itemRoullette();
                }
                System.Threading.Thread.Sleep(1000);

            }
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            btnMap.Enabled = true;
            lblSpeedStatDisplay.Text = Convert.ToString(playerSpeed);
            lblStengthStatDisplay.Text = Convert.ToString(playerStrength);
            lblMindStatDisplay.Text = Convert.ToString(playerMind);
            lblPlayerHP.Text = Convert.ToString(playerHP);

            if (playerStrength <= 0)
            {
                playerStrength = 1;
                lblStoryText.Text = "You can't have less than 1 Strength. You take 1 damage.";
                playerHP = playerHP - 1;
                System.Threading.Thread.Sleep(1000);
            }

            if (playerSpeed <= 0)
            {
                playerSpeed = 1;
                lblStoryText.Text = "You can't have less than 1 Speed. You take 1 damage.";
                playerHP = playerHP - 1;
                System.Threading.Thread.Sleep(1000);
            }

            if (playerMind <= 0)
            {
                playerMind = 1;
                lblStoryText.Text = "You can't have less than 1 Mind. You take 1 damage.";
                playerHP = playerHP - 1;
                System.Threading.Thread.Sleep(1000);
            }

            if (mainEvent == 4)
            {
                    if (pathStrength >= 7)
                    {

                    gameOver = 3;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnAttack.Enabled = false;
                    btnStrength.Enabled = true;
                    btnStrength.BackColor = Color.Red;
                    btnMind.Enabled = true;
                    btnMind.BackColor = Color.RoyalBlue;
                    lblStoryText.Text = "YOU ACHIEVED NOTHING" + Environment.NewLine +
                        Environment.NewLine + "The horrors of the Crypt are too much for you. " + Environment.NewLine +
                        "Hey, at least you are still alive" + Environment.NewLine +
                        Environment.NewLine + "Press Strength to play again or Press Mind to Quit.";
                }
                else
                {
                    mainEvent = 0;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    btnMap.Enabled = true;
                    lblStoryText.Text = "You failed, how much time has passed?";
                          System.Threading.Thread.Sleep(1000);
                }
                
            }

            if (playerHP <= 0)
            {
                if (item10 == 1)
                {
                    playerHP = 1;
                    lblStoryText.Text = "Your charm broke!";
                    item10 = 0;
                }
                else
                {

                    if (item10used == 1 || item10 == 0)
                    {

                        if (item4 == 1)
                        {
                            playerHP = 10;
                        }
                        else
                        {
                            //game over
                            gameOver = 1;
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = false;
                            button4.Enabled = false;
                            btnMap.Enabled = false;
                            btnInventory.Enabled = false;
                            btnAttack.Enabled = false;
                            btnStrength.Enabled = true;
                            btnStrength.BackColor = Color.Red;
                            btnMind.Enabled = true;
                            btnMind.BackColor = Color.RoyalBlue;
                            lblStoryText.Text = "YOU LOSE" + Environment.NewLine +
                            Environment.NewLine + "You die here and nobody ever found the body." + Environment.NewLine +
                            Environment.NewLine + "Press Strength to play again or Press Mind to Quit.";

                        }
                    }
                }
            }
        }

        //This is the button for Speed based Scenerios
        //The button will become Green when active
        private void btnSpeed_Click(object sender, EventArgs e)
        {
            Random eventPath = new Random();
            int pathSpeed = eventPath.Next(((playerSpeed * 2)+1));
            int damage = 0;
            btnSpeed.Enabled = false;
            btnStrength.Enabled = false;
            btnMind.Enabled = false;
            btnStrength.BackColor = Color.Transparent;
            btnSpeed.BackColor = Color.Transparent;
            btnMind.BackColor = Color.Transparent;
            if (currentEvent == 21)
            {
                if (pathSpeed >= 4)
                {
                    lblStoryText.Text = "You yank your leg out from whatever grabbed you!";
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    damage = (eventPath.Next(2)) + 1;
                    if (item2 == 0)
                    {
                        playerHP = playerHP - damage;
                    }

                    if (item2 == 1)
                    {
                        playerHP = (playerHP - (damage - 1));
                    }
                    lblStoryText.Text = "You yank your leg out from whatever grabbed you, but " + Environment.NewLine +
                        "it digs into you and cuts deep into your calf!" + Environment.NewLine +
                        "You take damage!";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 2)
            {
                if (pathSpeed >= 2)
                {
                    lblStoryText.Text = "You evade the falling debris.";
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    damage = (eventPath.Next(3)) + 1;
                    if (item2 == 0)
                    {
                        playerHP = playerHP - damage;
                    }

                    if (item2 == 1)
                    {
                        playerHP = (playerHP - (damage - 1));
                    }
                    lblStoryText.Text = "You panic and freeze as the debris hits your head and knocks you out." + Environment.NewLine +
                        "You wake up feeling sore and you feel that you should dodge debris when its about to fall on you." + Environment.NewLine +
                        "You take damage!";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 5)
            {
                if (pathSpeed > 4)
                {
                    playerSpeed = playerSpeed + 1;
                    lblStoryText.Text = "You quickly try to resist the shadow." + Environment.NewLine +
                        "Shortly you notice the shadow quickly leave your body." + Environment.NewLine +
                        "It was no match for you" + Environment.NewLine +
                        "You gain 1 speed!";
                    System.Threading.Thread.Sleep(1000);
                }
                else if (pathSpeed == 4)
                {
                    lblStoryText.Text = "You quickly try to resist the shadow." + Environment.NewLine +
                        "Shortly you notice the shadow slowly leave your body." + Environment.NewLine +
                        "That was a close one";
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    damage = (eventPath.Next(2)) + 1;
                    playerSpeed = playerSpeed - 1;
                    if (item2 == 0)
                    {
                        playerHP = playerHP - damage;
                    }

                    if (item2 == 1)
                    {
                        playerHP = (playerHP - (damage - 1));
                    }
                    lblStoryText.Text = "You quickly try to resist the shadow." + Environment.NewLine +
                        "Try as you might you feel no control over you own body." + Environment.NewLine +
                        "The shadow makes you run full sprint into a wall." + Environment.NewLine +
                        "You take damage and lose 1 speed!";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 7)
            {

                
                    if (pathSpeed >= 4) { 
                        playerSpeed = playerSpeed + 1;
                    lblStoryText.Text = "You swat the spider as fast as you can and with great accuracy." + Environment.NewLine +
                        "It hits the ground and wanders into the crypt." + Environment.NewLine +
                        "You gain 1 Speed!";
                    System.Threading.Thread.Sleep(1000);
                }

                else{
                    damage = (eventPath.Next(2)) + 1;
                    if (item2 == 0)
                    {
                        playerHP = playerHP - damage;
                    }

                    if (item2 == 1)
                    {
                        playerHP = (playerHP - (damage - 1));
                    }
                    lblStoryText.Text = "You attempt to swat the spider off you." + Environment.NewLine +
                        "The spider panics and bites you arm!" + Environment.NewLine +
                        "Hope it wasnt poisoneous." + Environment.NewLine +
                        "You take damage!";
                    System.Threading.Thread.Sleep(1000);
                }
                    damage = (eventPath.Next(2)) + 1;

            }
            if (currentEvent == 9)
            {
                if (pathSpeed >= 3)
                {
                    lblStoryText.Text = "What you thought was footsteps turns out to be galloping." + Environment.NewLine +
                        "You press yourself quickly to the side of wall." + Environment.NewLine +
                        "You see the spectral steed pass and keep going till it leaves your vision.";

                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    playerMind = playerMind - 1;
                    lblStoryText.Text = "What you thought was footsteps turns out to be galloping." + Environment.NewLine +
                        "You attempt to press yourself quickly to the side of wall, but you trip." + Environment.NewLine +
                        "You see the spectral steed passes through you. Your body is fine at least." + Environment.NewLine + 
                        "You lose 1 Mind";

                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 11)
            {
                if (pathSpeed > 6)
                {
                    playerSpeed = playerSpeed + 1;
                    lblStoryText.Text = "You dodge with speed and grace." + Environment.NewLine +
                        "As you run towards the graverobber he panicks and runs away, " + Environment.NewLine +
                        "Leaving behind what he tried to loot." + Environment.NewLine +
                        "You gain 1 speed!" + Environment.NewLine +
                        "You obtain an item!";
                    itemRoullette();

                    //item obtained
                    System.Threading.Thread.Sleep(1000);
                }
                else if (pathSpeed == 5 || pathSpeed == 6 || pathSpeed == 4)
                {
                    lblStoryText.Text = "You attempt to dodge, but trip in the process." + Environment.NewLine +
                        "As your falling you tell yourself a prayer until you realized he missed." + Environment.NewLine +
                        "What a blessing to be clumsy. While mid-thought you notice the graverobber is gone." + Environment.NewLine +
                        "At least you are left unscathed.";
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    damage = (eventPath.Next(3)) + 1;
                    playerSpeed = playerSpeed - 1;
                    if (item2 == 0)
                    {
                        playerHP = playerHP - damage;
                    }

                    if (item2 == 1)
                    {
                        playerHP = (playerHP - (damage - 1));
                    }
                    lblStoryText.Text = "You have no time to dodge as you feel a sharp pain in your thigh" + Environment.NewLine +
                        "You take damage and lose 1 speed";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 15)
            {
                if (pathSpeed >= 3)
                {
                    playerSpeed = playerSpeed + 1;
                    lblStoryText.Text = "You instinctively snap your foot back." + Environment.NewLine +
                        "CLANK. Just avoided your foot getting mauled up." + Environment.NewLine +
                        "You gain 1 speed.";

                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    playerSpeed = playerSpeed - 1;
                    damage = (eventPath.Next(2)) + 1;
                    if (item2 == 0)
                    {
                        playerHP = playerHP - damage;
                    }

                    if (item2 == 1)
                    {
                        playerHP = (playerHP - (damage - 1));
                    }
                    lblStoryText.Text = "" + Environment.NewLine +
                        "You instinctively snap your foot back." + Environment.NewLine +
                        "CLANK. Half your foot is caught in the trap." + Environment.NewLine +
                        "You slowly pry the trap off while screaming at the top of your lungs." + Environment.NewLine +
                        "You lose 1 speed and take damage.";
                }
            }
            if (currentEvent == 17)
            {
                if (pathSpeed > 6)
                {
                    playerSpeed = playerSpeed + 1;
                    lblStoryText.Text = "You win, you feel as if you could run a marathon." + Environment.NewLine +
                        "You gain 1 speed!";
                    System.Threading.Thread.Sleep(1000);
                }
                else if (pathSpeed == 4 || pathSpeed == 5)
                {
                    lblStoryText.Text = "You win but, the ghost vanishes before you can claim your prize." + Environment.NewLine +
                        "What a rip off.";
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    playerSpeed = playerSpeed - 1;
                    lblStoryText.Text = "You Lose, you like you gained weight." + Environment.NewLine + "How is that possible>" + Environment.NewLine +
                        "You lose 1 mind!";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 19)
            {
                if (pathSpeed >= 2)
                {
                    //obtain item
                    lblStoryText.Text = "You jump back from the 'Woman' in front of you." + Environment.NewLine +
                        " Good thing too, she was a zombie. She creeps at you slowly." + Environment.NewLine +
                        "The undead are so slow.You decide to just stay a good distance away.";

                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    damage = (eventPath.Next(5)) + 1;
                    if (item2 == 0)
                    {
                        playerHP = playerHP - damage;
                    }

                    if (item2 == 1)
                    {
                        playerHP = (playerHP - (damage - 1));
                    }
                    lblStoryText.Text = "You tap at the 'Woman' shoulder to get her attention." + Environment.NewLine +
                        "Bad idea , she is a zombie. And is now looking to strike you" + Environment.NewLine +
                        "You attempt to jump back, but not before it claws at your chest." + Environment.NewLine +
                        "At least it didn't bite you, you decide to out pace it licking your wounds in the process." + Environment.NewLine +
                        "You take damage!";

                    System.Threading.Thread.Sleep(1000);
                }
            }

            if (currentEvent == 0)
            {
                lblStoryText.Text = "You find yourself in a random new area, now you are really lost. Better Check the Map";
                height = eventPath.Next(1, 4);
                width = eventPath.Next(6);
                heightDisplay = 9 - height;
                lblRoomNumberDisplay.Text = Convert.ToString("X:" + width + " " + "Y:" + heightDisplay);
                pictureBox1.Image = Image.FromFile("Black.png");
                System.Threading.Thread.Sleep(1000);
            }

            if (mainEvent == 3)
            {
                mainEvent = 0;
                playerSpeed = playerSpeed + 1;

                lblStoryText.Text = "You enter into a room of many bones decorated throughout." + Environment.NewLine +
                            "Through all the skulls in this room, one is alone on a pedestal." + Environment.NewLine +
                            "As you approach the skull you hear 'Find me what I seek and do it post-haste.'" + Environment.NewLine +
                            "In fear of what the talking skull you look around until you stumble upon a chest." + Environment.NewLine +
                            "You grab the chest and bring it to the base of the pedestal." + Environment.NewLine +
                            "'Good, now take whats inside it will be of great use' Then skull cracks and then explodes into powder." + Environment.NewLine +
                            "You got 1 speed and an item";
                itemRoullette();

                Width = 6;
                Height = 2;
            }

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            btnMap.Enabled = true;

            lblSpeedStatDisplay.Text = Convert.ToString(playerSpeed);
            lblStengthStatDisplay.Text = Convert.ToString(playerStrength);
            lblMindStatDisplay.Text = Convert.ToString(playerMind);
            lblPlayerHP.Text = Convert.ToString(playerHP);


            if (playerStrength <= 0)
            {
                playerStrength = 1;
                lblStoryText.Text = "You can't have less than 1 Strength. You take 1 damage.";
                playerHP = playerHP - 1;
                System.Threading.Thread.Sleep(1000);
            }

            if (playerSpeed <= 0)
            {
                playerSpeed = 1;
                lblStoryText.Text = "You can't have less than 1 Speed. You take 1 damage.";
                playerHP = playerHP - 1;
                System.Threading.Thread.Sleep(1000);
            }

            if (playerMind <= 0)
            {
                playerMind = 1;
                lblStoryText.Text = "You can't have less than 1 Mind. You take 1 damage.";
                playerHP = playerHP - 1;
                System.Threading.Thread.Sleep(1000);
            }


            if (playerHP <= 0)
            {
                if (item10 == 1)
                {
                    playerHP = 1;
                    lblStoryText.Text = "Your charm broke!";
                    item10 = 0;
                }
                else
                {
                    //game ove
                    if (item10used == 1 || item10 == 0)
                    {

                        if (item4 == 1)
                        {
                            playerHP = 10;
                        }
                        else
                        {
                            //game over
                            gameOver = 1;
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = false;
                            button4.Enabled = false;
                            btnMap.Enabled = false;
                            btnInventory.Enabled = false;
                            btnAttack.Enabled = false;
                            btnStrength.Enabled = true;
                            btnStrength.BackColor = Color.Red;
                            btnMind.Enabled = true;
                            btnMind.BackColor = Color.RoyalBlue;
                            lblStoryText.Text = "YOU LOSE" + Environment.NewLine +
                            Environment.NewLine + "You die here and nobody ever found the body." + Environment.NewLine +
                            Environment.NewLine + "Press Strength to play again or Press Mind to Quit.";
                        }
                    }
                }
            }
        }

        //This is the button for Mind based Scenerios
        //The button will become Blue when active
        private void btnMind_Click(object sender, EventArgs e)
        {
            Random eventPath = new Random();
            int pathMind = eventPath.Next(((playerMind * 2)+1));
            int damage = 0;
            btnSpeed.Enabled = false;
            btnStrength.Enabled = false;
            btnMind.Enabled = false;
            btnStrength.BackColor = Color.Transparent;
            btnSpeed.BackColor = Color.Transparent;
            btnMind.BackColor = Color.Transparent;

            if (gameOver == 1 || gameOver == 2 || gameOver == 3)
            {
                Application.Exit();
            }

            if (currentEvent == 3)
            {
                if (pathMind >= 3)
                {
                    //obtain item
                    lblStoryText.Text = "You remove the skeleton from the stone coffin." + Environment.NewLine +
                        "You can almost reach, if only you had something long enough to scrape it close " + Environment.NewLine +
                    "enough for you to grab. Then the greatest idea popped in your mind." + Environment.NewLine +
                    "You take one of skeletons arms and obtain the item!" + Environment.NewLine;
                    itemRoullette();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    playerMind = playerMind - 1;
                    lblStoryText.Text = "You remove the skeleton from the stone coffin." + Environment.NewLine +
                        "You can almost reach, if only you had something long enough to scrape it close " + Environment.NewLine +
                    "enough for you to grab. Filled with guilt of defiling a grave you do your best to " + Environment.NewLine +
                    "put the skelton back." + Environment.NewLine +
                    "You lose 1 Mind!";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 4)
            {
                if (pathMind >= 3)
                {
                    //obtain item
                    lblStoryText.Text = "You remove the bricks and grab the item.";
                    itemRoullette();
                    System.Threading.Thread.Sleep(1000);
                    
                }
                else
                {
                    lblStoryText.Text = "You remove the bricks to find nothing." + Environment.NewLine +
                        "Is what you saw even real or did someone else find it first?" + Environment.NewLine +
                    "Well whatever happened nothing was gained from this odd episode.";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 5)
            {
                if (pathMind > 4)
                {
                    playerSpeed = playerSpeed + 1;
                    lblStoryText.Text = "You try to fight off the shadow mentally." + Environment.NewLine +
                        "Shortly you notice the shadow quickly leave your body." + Environment.NewLine +
                        "It was no match for you" + Environment.NewLine +
                        "You gain 1 Mind!";
                    System.Threading.Thread.Sleep(1000);
                }
                else if (pathMind == 4)
                {
                    lblStoryText.Text = "You try to fight off the shadow mentally." + Environment.NewLine +
                        "Shortly you notice the shadow slowly leave your body." + Environment.NewLine +
                        "That was a close one";
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    playerMind = playerMind - 1;
                    lblStoryText.Text = "You try to fight off the shadow mentally." + Environment.NewLine +
                        "Try as you might you feel no control over you own mind." + Environment.NewLine +
                        "You wake up with blood stained hands, what did it make you do?" + Environment.NewLine +
                        "You lose 1 Mind!";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 6)
            {
                if (pathMind >= 4)
                {
                    playerMind = playerMind + 1;
                    lblStoryText.Text = "Well what do you know they are real, but not how you thought.." + Environment.NewLine +
                        "There both spirits and tell you the secrets of the crypt." + Environment.NewLine +
                        "You gain 1 Mind!";
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    lblStoryText.Text = "You close you eyes and count to 3." + Environment.NewLine +
                        "1........2........3." + Environment.NewLine +
                        "They are gone. This crypt is getting to you.";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 7)
            {
                if (pathMind >= 3)
                {
                    playerMind = playerMind + 1;
                    lblStoryText.Text = "You hold perfectly still as the spider crawls on you." + Environment.NewLine +
                        "Eventually it crawls back on the ground and wanders into the crypt." + Environment.NewLine +
                        "You gain 1 Mind!";
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    damage = (eventPath.Next(2)) + 1;
                    if (item2 == 0)
                    {
                        playerHP = playerHP - damage;
                    }

                    if (item2 == 1)
                    {
                        playerHP = (playerHP - (damage - 1));
                    }
                    lblStoryText.Text = "You attempt to hold still until you sneeze." + Environment.NewLine +
                        "The spider panics and bites you arm!" + Environment.NewLine +
                        "Hope it wasnt poisoneous." + Environment.NewLine +
                        "You take damage!";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 9)
            {
                lblStoryText.Text = "You turn around slowly to reveal.... Nothing.";
            }
            if (currentEvent == 12)
            {
                if (pathMind >= 4)
                {
                    lblStoryText.Text = "As enticing as that sounds I'll pass." + Environment.NewLine +
                        "You carry on as if you heard nothing";
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    playerMind = playerMind - 1;
                    lblStoryText.Text = "You are lured into the coffin next to this mummified corpse." + Environment.NewLine +
                        "Why would you climb in, you need to get out now." + Environment.NewLine +
                        "As you climb out the corpse begins to cry loudly." + Environment.NewLine +
                        "You run as fast as you can, but with new mental scars." + Environment.NewLine +
                        "You lose 1 mind!";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 13)
            {
                if (pathMind >= 4)
                {
                    lblStoryText.Text = "You go through the new path. Along the path you spot an urn." + Environment.NewLine +
                        "Inside you find an item that could be of some use to you." + Environment.NewLine +
                        "You exit into a whole new area as the exit closes behind you.";
                    itemRoullette();
                    height = eventPath.Next(1, 4);
                    width = eventPath.Next(6);
                    heightDisplay = 9 - height;
                    lblRoomNumberDisplay.Text = Convert.ToString("X:" + width + " " + "Y:" + heightDisplay);
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    lblStoryText.Text = "You go through the new path." + Environment.NewLine +
                        "You exit into a whole new area as the exit closes behind you.";
                    height = eventPath.Next(1, 4);
                    width = eventPath.Next(6);
                    heightDisplay = 9 - height;
                    lblRoomNumberDisplay.Text = Convert.ToString("X:" + width + " " + "Y:" + heightDisplay);
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 14)
            {
                if (pathMind >= 3)
                {
                    lblStoryText.Text = "You can't believe what happened." + Environment.NewLine +
                        "What is with this place messing with your mind" + Environment.NewLine +
                        "You dust yourself off and march foward";
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    playerMind = playerMind - 1;
                    lblStoryText.Text = "You frantically try to put the woman back together." + Environment.NewLine +
                        "Your mind is shattered as your hands are covered in her dust" + Environment.NewLine +
                        "You lose 1 Mind";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 16)
            {
                if (pathMind > 6)
                {
                    playerMind = playerMind + 1;
                    lblStoryText.Text = "You attempt to give the child something to calm him down." + Environment.NewLine +
                        "'Let me get you out here, take this for now' you tell him." + Environment.NewLine +
                        "Before you give him your item he looks up and smiles." + Environment.NewLine +
                        "'All I wanted to know is that you cared' he says as he vanishes from this existance." + Environment.NewLine +
                        "You gain 1 mind!";
                    System.Threading.Thread.Sleep(1000);
                }
                else if (pathMind == 4 || pathMind == 5)
                {
                    playerMind = playerMind + 1;
                    lblStoryText.Text = "You attempt to give the child something to calm him down." + Environment.NewLine +
                        "'Let me get you out here, take this for now' you tell him." + Environment.NewLine +
                        "The child takes your item as he smiles." + Environment.NewLine +
                        "'All I wanted to know is that you cared' he says as he vanishes from this existance." + Environment.NewLine +
                        "You lost an item, but gained 1 mind!";

                    itemLoss();
                    //lose item
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    playerMind = playerMind - 1;
                    damage =  (eventPath.Next(3)) + 1;
                    playerHP = playerHP - damage;
                    lblStoryText.Text = "You attempt to give the child something to calm him down." + Environment.NewLine +
                        "Before you can even say anything the child screams. " + Environment.NewLine +
                        "'I DON'T WANT THAT!'" + Environment.NewLine +
                        "The child's scream leaves you deafen, you think your eardrums are ruptured." + Environment.NewLine +
                        "You lose 1 mind and take damage!";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 17)
            {
                if (pathMind > 6)
                {
                    playerMind = playerMind + 1;
                    lblStoryText.Text = "You win, you feel your mind become clear." + Environment.NewLine +
                        "You gain 1 mind!";
                    System.Threading.Thread.Sleep(1000);
                }
                else if (pathMind == 4 || pathMind == 5)
                {
                    lblStoryText.Text = "You win but, the ghost vanishes before you can claim your prize." + Environment.NewLine +
                        "What a rip off.";
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    playerMind = playerMind - 1;
                    lblStoryText.Text = "You Lose, you feel some of your mind slip away." + Environment.NewLine +
                        "You lose 1 mind!";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 18)
            {
                if (pathMind >= 4)
                {
                    playerMind = playerMind - 1;
                    lblStoryText.Text = "You greedily take the necklace off the skeletons neck." + Environment.NewLine +
                        "How could you!?" + Environment.NewLine +
                        "You gain an item, but lose 1 mind.";
                    itemRoullette();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    lblStoryText.Text = "You pull yourself together." + Environment.NewLine +
                        "Why would you even think of doing that?!";
                    System.Threading.Thread.Sleep(1000);
                }
            }
            if (currentEvent == 20)
            {
                if (pathMind >= 3)
                {
                    playerMind = playerMind + 1;
                    lblStoryText.Text = "You keep calm and take the debris apart until you can escape." + Environment.NewLine +
                        "There is no way the debris is perfectly sealing in the water" + Environment.NewLine +
                        "You were right, and slowly take the debris apart." + Environment.NewLine +
                        "You gain 1 mind!";
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    damage = (eventPath.Next(2)) + 1;
                    if (item2 == 0)
                    {
                        playerHP = playerHP - damage;
                    }

                    if (item2 == 1)
                    {
                        playerHP = (playerHP - (damage - 1));
                    }
                    lblStoryText.Text = "You keep calm and take the debris apart until you can escape." + Environment.NewLine +
                        "There is no way the debris is perfectly sealing in the water" + Environment.NewLine +
                        "You were wrong, and rush to take the debris apart." + Environment.NewLine +
                        "In your rush you didn't notice that you broke several nails down the middle." + Environment.NewLine +
                        "You take damage!";
                    System.Threading.Thread.Sleep(1000);
                }
            }

            if (currentEvent == 0)
            {
                if (playerMind < 3)
                {
                    playerMind = playerMind + 1;
                    lblStoryText.Text = "You sigh, and begin to remember the reasons why you must go on." + Environment.NewLine +
                        "You gain 1 Mind!";
                    System.Threading.Thread.Sleep(1000);

                }
                else
                {
                    lblStoryText.Text = "You sigh, and begin to remember the reasons why you must go on.";
                    System.Threading.Thread.Sleep(1000);
                }
            }

            if (mainEvent == 1)
            {
                mainEvent = 0;
                playerHP = playerHP + 5;

                lblStoryText.Text = "As you walk into the chapterhouse you hear what sounds like a meeting happening." + Environment.NewLine +
                        "'Now if we just...' 'But I think we need to...' 'Shh an outsiders here.' 'Someone's here'" + Environment.NewLine +
                        "A dark silence falls over the room." + Environment.NewLine +
                        "'He's here.' 'Oh, he's here.' 'Give it to him'" + Environment.NewLine +
                        "An item appears out of thin air and falls onto the ground echoing throughout the chapter house." + Environment.NewLine +
                        "The room is now empty. You got an item and gained 5 hp!";
                itemRoullette();
                System.Threading.Thread.Sleep(1000);
                //item obtained

            }


            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            btnMap.Enabled = true;

            lblSpeedStatDisplay.Text = Convert.ToString(playerSpeed);
            lblStengthStatDisplay.Text = Convert.ToString(playerStrength);
            lblMindStatDisplay.Text = Convert.ToString(playerMind);
            lblPlayerHP.Text = Convert.ToString(playerHP);


            if (playerStrength <= 0)
            {
                playerStrength = 1;
                lblStoryText.Text = "You can't have less than 1 Strength. You take 1 damage.";
                playerHP = playerHP - 1;
                System.Threading.Thread.Sleep(1000);
            }

            if (playerSpeed <= 0)
            {
                playerSpeed = 1;
                lblStoryText.Text = "You can't have less than 1 Speed. You take 1 damage.";
                playerHP = playerHP - 1;
                System.Threading.Thread.Sleep(1000);
            }

            if (playerMind <= 0)
            {
                playerMind = 1;
                lblStoryText.Text = "You can't have less than 1 Mind. You take 1 damage.";
                playerHP = playerHP - 1;
                System.Threading.Thread.Sleep(1000);
            }

            if (mainEvent == 4)
            {
                if (pathMind >= 6)
                {
                    gameOver = 3;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnAttack.Enabled = false;
                    btnStrength.Enabled = true;
                    btnStrength.BackColor = Color.Red;
                    btnMind.Enabled = true;
                    btnMind.BackColor = Color.RoyalBlue;
                    lblStoryText.Text = "YOU ACHIEVED NOTHING" + Environment.NewLine +
                        Environment.NewLine + "The horrors of the Crypt are too much for you. " + Environment.NewLine +
                        "Hey, at least you are still alive" + Environment.NewLine +
                        Environment.NewLine + "Press Strength to play again or Press Mind to Quit.";
                }
                else
                {
                    mainEvent = 0;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    btnMap.Enabled = true;
                    lblStoryText.Text = "You failed , how much time has passed?";
                    System.Threading.Thread.Sleep(1000);
                }
            }

            if (playerHP <= 0)
            {
                if (item10 == 1)
                {
                    playerHP = 1;
                    lblStoryText.Text = "Your charm broke!";
                    item10 = 0;
                }
                else
                {


                    if (item10used == 1 || item10 == 0)
                    {

                        if (item4 == 1)
                        {
                            playerHP = 10;
                        }
                        else
                        {
                            //game over
                            gameOver = 1;
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = false;
                            button4.Enabled = false;
                            btnMap.Enabled = false;
                            btnInventory.Enabled = false;
                            btnAttack.Enabled = false;
                            btnStrength.Enabled = true;
                            btnStrength.BackColor = Color.Red;
                            btnMind.Enabled = true;
                            btnMind.BackColor = Color.RoyalBlue;
                            lblStoryText.Text = "YOU LOSE" + Environment.NewLine +
                            Environment.NewLine + "You die here and nobody ever found the body." + Environment.NewLine +
                            Environment.NewLine + "Press Strength to play again or Press Mind to Quit.";
                        }
                    }
                }
            }

        }


        //This is the button for attacking the Wraith
        //The button will become purple when active
        private void btnAttack_Click(object sender, EventArgs e)
        {
            Random fight = new Random();
            attackAbility = 1;
            if (monsterHeight == height && monsterWidth == width)
            {

                int monsterAttack = fight.Next(1, (monsterStrength * 2));
                int playerAttack = fight.Next(1, (playerStrength * 2));

                if (item1 == 1)
                {
                    playerAttack = playerAttack + 2;
                }

                if (item5 == 1)
                {
                    playerAttack = playerAttack + (playerMind/2);
                }
                if (item6 == 1)
                {
                    playerAttack = playerAttack + (playerSpeed/2);
                }


                if (monsterAttack > playerAttack)
                {
                    if (item2 == 0)
                    {
                        playerHP = playerHP - (monsterAttack - playerAttack);
                    }
 
                    if (item2 == 1)
                    {
                        playerHP = playerHP - ((monsterAttack - playerAttack )- 1);
                    }
                    lblStoryText.Text = "You attack the monster" + Environment.NewLine +
                        "It counterattacks you for " + Convert.ToString(monsterAttack - playerAttack) + " damage!";
                    lblPlayerHP.Text = Convert.ToString(playerHP);
                    System.Threading.Thread.Sleep(1000);
                }
                else if (monsterAttack < playerAttack)
                {
                    monsterHP = monsterHP - (playerAttack - monsterAttack);
                    lblStoryText.Text = "You attack the monster!" + Environment.NewLine +
                        "You attack for " + Convert.ToString(playerAttack - monsterAttack) + " damage!";
                    monsterHeight = fight.Next(10);
                    monsterWidth = fight.Next(10);
                    pictureBox2.Visible = false;
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    lblStoryText.Text = "You attack the monster" + Environment.NewLine +
                        "The monster deflects the attack! " + Environment.NewLine +
                        "No damage taken or given!";
                    System.Threading.Thread.Sleep(1000);
                }
                btnAttack.Enabled = false;
                btnAttack.BackColor = Color.Transparent;

                if (playerHP <= 0)
                {
                    if (item10 == 1)
                    {
                        playerHP = 1;
                        lblStoryText.Text = "Your charm broke!";
                        item10 = 0;
                    }
                    else
                    {

                        if (item10used == 1 || item10 == 0)
                        {

                            if (item4 == 1)
                            {
                                playerHP = 10;
                            }
                            else
                            {
                                //game over
                                gameOver = 1;
                                button1.Enabled = false;
                                button2.Enabled = false;
                                button3.Enabled = false;
                                button4.Enabled = false;
                                btnMap.Enabled = false;
                                btnInventory.Enabled = false;
                                btnAttack.Enabled = false;
                                btnStrength.Enabled = true;
                                btnStrength.BackColor = Color.Red;
                                btnMind.Enabled = true;
                                btnMind.BackColor = Color.RoyalBlue;
                                lblStoryText.Text = "YOU LOSE" + Environment.NewLine +
                            Environment.NewLine + "You die here and nobody ever found the body." + Environment.NewLine +
                            Environment.NewLine + "Press Strength to play again or Press Mind to Quit.";
                            }
                        }
                    }
                }

                if (monsterHP <= 0)
                {
                    //you win
                    gameOver = 2;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    btnMap.Enabled = false;
                    btnInventory.Enabled = false;
                    btnAttack.Enabled = false;
                    btnStrength.Enabled = true;
                    btnStrength.BackColor = Color.Red;
                    btnMind.Enabled = true;
                    btnMind.BackColor = Color.RoyalBlue;
                    lblStoryText.Text = "YOU WIN" + Environment.NewLine +
                        Environment.NewLine + "Before you struck the final blow you took a picture of the Wraith. " +
                        "Proving to the world that the Paranormal are real." + Environment.NewLine +
                        "Unless they think you used photshop, they never said it would be easy to prove with proof." + Environment.NewLine +
                        Environment.NewLine + "Press Strength to play again or Press Mind to Quit.";
                }

            } 
        }

        //This is the button for Recieving an item
        //The button will become yellow when active
        private void btnInventory_Click(object sender, EventArgs e)
        {
            itemSelecter = 0;

            Random itemChooser = new Random();

            itemSelecter = itemChooser.Next((itemPicker.Count));
            itemPicker.Remove(itemPicker[itemSelecter]);

            if (itemSelecter == 1)
            {
                item1 = 1;
                lblStoryText.Text = "This blade should help with physical attack!";
                //Sword
            }

            if (itemSelecter == 2)
            {
                item2 = 1;
                lblStoryText.Text = "This armor should help soak some Damage!";
                //Armor
            }

            if (itemSelecter == 3)
            {
                item3 = 1;
                lblStoryText.Text = "You find a green salve, you drink it without a second thought.";
                playerHP = playerHP + 5;
                lblPlayerHP.Text = Convert.ToString(playerHP);
                //Healing Salve
            }

            if (itemSelecter == 4)
            {
                item4 = 1;
                lblStoryText.Text = "You find a red and orange birds feather, its hot to the touch.";
                //Pheonix Feather
            }

            if (itemSelecter == 5)
            {
                item5 = 1;
                lblStoryText.Text = "This contraption makes it feel as if your attacks are more strategic and precise!";
                //Gadget mind helps with attack
            }

            if (itemSelecter == 6)
            {
                item6 = 1;
                lblStoryText.Text = "This gun will be handy, I've always had an itchy trigger finger!";
                //Pisol with blessed bullets speed helps with attacks
            }

            if (itemSelecter == 7)
            {
                item7 = 1;
                lblStoryText.Text = "You find a stone that glows a green hue, it makes you feel faster!";
                playerSpeed = playerSpeed + 1;
                lblSpeedStatDisplay.Text = Convert.ToString(playerSpeed);
                //Strange Green Stone
            }

            if (itemSelecter == 8)
            {
                item8 = 1;
                lblStoryText.Text = "You find a stone that glows a red hue, it makes you feel stronger!";
                playerStrength = playerStrength + 1;
                lblStengthStatDisplay.Text = Convert.ToString(playerStrength);
                //Strange Red Stone
            }

            if (itemSelecter == 9)
            {
                item9 = 1;
                lblStoryText.Text = "You find a stone that glows a blue hue, it makes you feel smarter and saner!";
                playerMind = playerMind + 1;
                lblMindStatDisplay.Text = Convert.ToString(playerMind);
                //Strange Blue Stone
            }

            if (itemSelecter == 10)
            {
                item10 = 1;
                lblStoryText.Text = "You feel safe when you wear this charm.";
                //Necklace with crystal
            }

            if (itemSelecter == 11)
            {

                Random statChooser = new Random();
                int statChoosen = statChooser.Next(1,3);
                int statLost = statChooser.Next(1, 2);
                item11 = 1;
                lblStoryText.Text = "You find a Syringe that marks 'Exprimental', you need all the help you can get.";
                if(statChoosen == 1){
                    playerStrength = playerStrength + 1;
                    if (statLost == 1){
                        playerMind = playerMind - 1;
                    }
                    if (statLost == 2)
                    {
                        playerSpeed = playerSpeed - 1;
                    }
                }

                if (statChoosen == 2)
                {
                    playerSpeed = playerSpeed + 1;
                    if (statLost == 1)
                    {
                        playerStrength = playerStrength - 1;
                    }
                    if (statLost == 2)
                    {
                        playerMind = playerMind - 1;
                    }
                }

                if (statChoosen == 3)
                {
                    playerMind = playerMind + 1;
                    if (statLost == 1)
                    {
                        playerStrength = playerStrength - 1;
                    }
                    if (statLost == 2)
                    {
                        playerSpeed = playerSpeed - 1;
                    }
                }
                lblSpeedStatDisplay.Text = Convert.ToString(playerSpeed);
                lblStengthStatDisplay.Text = Convert.ToString(playerStrength);
                lblMindStatDisplay.Text = Convert.ToString(playerMind);


                //Gives random stat
                //Loses random stat
            }

            btnInventory.BackColor = Color.Transparent;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            btnMap.Enabled = true;
            btnInventory.Enabled = false;
            lblSpeedStatDisplay.Text = Convert.ToString(playerSpeed);
            lblStengthStatDisplay.Text = Convert.ToString(playerStrength);
            lblMindStatDisplay.Text = Convert.ToString(playerMind);
            lblPlayerHP.Text = Convert.ToString(playerHP);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
