namespace Skeleton
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBegin = new System.Windows.Forms.Button();
            this.splashScreen = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splashScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(388, 213);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(103, 42);
            this.btnBegin.TabIndex = 6;
            this.btnBegin.Text = "Play";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // splashScreen
            // 
            this.splashScreen.Enabled = true;
            this.splashScreen.Location = new System.Drawing.Point(0, 1);
            this.splashScreen.Name = "splashScreen";
            this.splashScreen.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("splashScreen.OcxState")));
            this.splashScreen.Size = new System.Drawing.Size(877, 512);
            this.splashScreen.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(388, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "P.I.E.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(855, 76);
            this.label2.TabIndex = 9;
            this.label2.Text = "Paranormal Investigations Established";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Haettenschweiler", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(198, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nothing Scares the Paranormal more than P.I.E. !";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(382, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Credits\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(12, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(773, 200);
            this.label5.TabIndex = 12;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(879, 511);
            this.Controls.Add(this.splashScreen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBegin);
            this.Name = "Form1";
            this.Text = "P.I.E Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splashScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBegin;
        private AxWMPLib.AxWindowsMediaPlayer splashScreen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

