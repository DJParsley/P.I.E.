namespace Skeleton
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.lblRoomNumberDisplay = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblDirectionDisplay = new System.Windows.Forms.Label();
            this.lblRoomNumberTitle = new System.Windows.Forms.Label();
            this.lblDirectionTitle = new System.Windows.Forms.Label();
            this.btnMusic = new System.Windows.Forms.Button();
            this.lblStoryText = new System.Windows.Forms.Label();
            this.btnMap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStatTitle = new System.Windows.Forms.Label();
            this.btnStrength = new System.Windows.Forms.Button();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.btnMind = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblMindStatDisplay = new System.Windows.Forms.Label();
            this.lblSpeedStatDisplay = new System.Windows.Forms.Label();
            this.lblStengthStatDisplay = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPlayerHPTitle = new System.Windows.Forms.Label();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.songPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Move Foward";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRoomNumberDisplay
            // 
            this.lblRoomNumberDisplay.AutoSize = true;
            this.lblRoomNumberDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumberDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRoomNumberDisplay.Location = new System.Drawing.Point(516, 43);
            this.lblRoomNumberDisplay.Name = "lblRoomNumberDisplay";
            this.lblRoomNumberDisplay.Size = new System.Drawing.Size(70, 25);
            this.lblRoomNumberDisplay.TabIndex = 3;
            this.lblRoomNumberDisplay.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(523, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Turn Left";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(603, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Turn Around";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(691, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Turn Right";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblDirectionDisplay
            // 
            this.lblDirectionDisplay.AutoSize = true;
            this.lblDirectionDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectionDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDirectionDisplay.Location = new System.Drawing.Point(664, 38);
            this.lblDirectionDisplay.Name = "lblDirectionDisplay";
            this.lblDirectionDisplay.Size = new System.Drawing.Size(102, 37);
            this.lblDirectionDisplay.TabIndex = 7;
            this.lblDirectionDisplay.Text = "label2";
            // 
            // lblRoomNumberTitle
            // 
            this.lblRoomNumberTitle.AutoSize = true;
            this.lblRoomNumberTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumberTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRoomNumberTitle.Location = new System.Drawing.Point(517, 13);
            this.lblRoomNumberTitle.Name = "lblRoomNumberTitle";
            this.lblRoomNumberTitle.Size = new System.Drawing.Size(120, 25);
            this.lblRoomNumberTitle.TabIndex = 9;
            this.lblRoomNumberTitle.Text = "Room Cord";
            // 
            // lblDirectionTitle
            // 
            this.lblDirectionTitle.AutoSize = true;
            this.lblDirectionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectionTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDirectionTitle.Location = new System.Drawing.Point(664, 13);
            this.lblDirectionTitle.Name = "lblDirectionTitle";
            this.lblDirectionTitle.Size = new System.Drawing.Size(102, 25);
            this.lblDirectionTitle.TabIndex = 10;
            this.lblDirectionTitle.Text = "Compass";
            // 
            // btnMusic
            // 
            this.btnMusic.Location = new System.Drawing.Point(595, 87);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(99, 23);
            this.btnMusic.TabIndex = 11;
            this.btnMusic.Text = "Music Playing";
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.Music_Click);
            // 
            // lblStoryText
            // 
            this.lblStoryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoryText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStoryText.Location = new System.Drawing.Point(12, 390);
            this.lblStoryText.Name = "lblStoryText";
            this.lblStoryText.Size = new System.Drawing.Size(754, 163);
            this.lblStoryText.TabIndex = 12;
            this.lblStoryText.Text = "You Entered the Crypt";
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.BurlyWood;
            this.btnMap.Location = new System.Drawing.Point(527, 274);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(99, 23);
            this.btnMap.TabIndex = 13;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 354);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblStatTitle
            // 
            this.lblStatTitle.AutoSize = true;
            this.lblStatTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatTitle.Location = new System.Drawing.Point(579, 122);
            this.lblStatTitle.Name = "lblStatTitle";
            this.lblStatTitle.Size = new System.Drawing.Size(47, 20);
            this.lblStatTitle.TabIndex = 16;
            this.lblStatTitle.Text = "Stats";
            // 
            // btnStrength
            // 
            this.btnStrength.BackColor = System.Drawing.Color.Transparent;
            this.btnStrength.Enabled = false;
            this.btnStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrength.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStrength.Location = new System.Drawing.Point(595, 145);
            this.btnStrength.Name = "btnStrength";
            this.btnStrength.Size = new System.Drawing.Size(75, 23);
            this.btnStrength.TabIndex = 17;
            this.btnStrength.Text = "Strength";
            this.btnStrength.UseVisualStyleBackColor = false;
            this.btnStrength.Click += new System.EventHandler(this.btnStrength_Click);
            // 
            // btnSpeed
            // 
            this.btnSpeed.BackColor = System.Drawing.Color.Transparent;
            this.btnSpeed.Enabled = false;
            this.btnSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeed.Location = new System.Drawing.Point(595, 174);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(75, 23);
            this.btnSpeed.TabIndex = 18;
            this.btnSpeed.Text = "Speed";
            this.btnSpeed.UseVisualStyleBackColor = false;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // btnMind
            // 
            this.btnMind.BackColor = System.Drawing.Color.Transparent;
            this.btnMind.Enabled = false;
            this.btnMind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMind.Location = new System.Drawing.Point(595, 203);
            this.btnMind.Name = "btnMind";
            this.btnMind.Size = new System.Drawing.Size(75, 23);
            this.btnMind.TabIndex = 19;
            this.btnMind.Text = "Mind";
            this.btnMind.UseVisualStyleBackColor = false;
            this.btnMind.Click += new System.EventHandler(this.btnMind_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Enabled = false;
            this.btnInventory.Location = new System.Drawing.Point(662, 274);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(99, 23);
            this.btnInventory.TabIndex = 24;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAttack.Enabled = false;
            this.btnAttack.Location = new System.Drawing.Point(595, 232);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(99, 23);
            this.btnAttack.TabIndex = 25;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblMindStatDisplay
            // 
            this.lblMindStatDisplay.AutoSize = true;
            this.lblMindStatDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMindStatDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMindStatDisplay.Location = new System.Drawing.Point(676, 203);
            this.lblMindStatDisplay.Name = "lblMindStatDisplay";
            this.lblMindStatDisplay.Size = new System.Drawing.Size(22, 20);
            this.lblMindStatDisplay.TabIndex = 26;
            this.lblMindStatDisplay.Text = "M";
            // 
            // lblSpeedStatDisplay
            // 
            this.lblSpeedStatDisplay.AutoSize = true;
            this.lblSpeedStatDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedStatDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSpeedStatDisplay.Location = new System.Drawing.Point(676, 174);
            this.lblSpeedStatDisplay.Name = "lblSpeedStatDisplay";
            this.lblSpeedStatDisplay.Size = new System.Drawing.Size(20, 20);
            this.lblSpeedStatDisplay.TabIndex = 27;
            this.lblSpeedStatDisplay.Text = "S";
            // 
            // lblStengthStatDisplay
            // 
            this.lblStengthStatDisplay.AutoSize = true;
            this.lblStengthStatDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStengthStatDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStengthStatDisplay.Location = new System.Drawing.Point(676, 145);
            this.lblStengthStatDisplay.Name = "lblStengthStatDisplay";
            this.lblStengthStatDisplay.Size = new System.Drawing.Size(30, 20);
            this.lblStengthStatDisplay.TabIndex = 28;
            this.lblStengthStatDisplay.Text = "Str";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(165, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 209);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // lblPlayerHPTitle
            // 
            this.lblPlayerHPTitle.AutoSize = true;
            this.lblPlayerHPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHPTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayerHPTitle.Location = new System.Drawing.Point(648, 122);
            this.lblPlayerHPTitle.Name = "lblPlayerHPTitle";
            this.lblPlayerHPTitle.Size = new System.Drawing.Size(36, 20);
            this.lblPlayerHPTitle.TabIndex = 32;
            this.lblPlayerHPTitle.Text = "HP-";
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayerHP.Location = new System.Drawing.Point(683, 122);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(27, 20);
            this.lblPlayerHP.TabIndex = 33;
            this.lblPlayerHP.Text = "20";
            // 
            // songPlayer
            // 
            this.songPlayer.Enabled = true;
            this.songPlayer.Location = new System.Drawing.Point(18, 52);
            this.songPlayer.Name = "songPlayer";
            this.songPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("songPlayer.OcxState")));
            this.songPlayer.Size = new System.Drawing.Size(141, 113);
            this.songPlayer.TabIndex = 34;
            this.songPlayer.Visible = false;
            this.songPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(773, 562);
            this.Controls.Add(this.songPlayer);
            this.Controls.Add(this.lblPlayerHP);
            this.Controls.Add(this.lblPlayerHPTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblStengthStatDisplay);
            this.Controls.Add(this.lblSpeedStatDisplay);
            this.Controls.Add(this.lblMindStatDisplay);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnMind);
            this.Controls.Add(this.btnSpeed);
            this.Controls.Add(this.btnStrength);
            this.Controls.Add(this.lblStatTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.lblStoryText);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.lblDirectionTitle);
            this.Controls.Add(this.lblRoomNumberTitle);
            this.Controls.Add(this.lblDirectionDisplay);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblRoomNumberDisplay);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "P.I.E. Demo";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRoomNumberDisplay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblDirectionDisplay;
        private System.Windows.Forms.Label lblRoomNumberTitle;
        private System.Windows.Forms.Label lblDirectionTitle;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Label lblStoryText;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStatTitle;
        private System.Windows.Forms.Button btnStrength;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.Button btnMind;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblMindStatDisplay;
        private System.Windows.Forms.Label lblSpeedStatDisplay;
        private System.Windows.Forms.Label lblStengthStatDisplay;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPlayerHPTitle;
        private System.Windows.Forms.Label lblPlayerHP;
        private AxWMPLib.AxWindowsMediaPlayer songPlayer;
    }
}