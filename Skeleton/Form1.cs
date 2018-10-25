using System;
using System.Windows.Forms;

namespace Skeleton
{    

public partial class Form1 : Form



    {
        Form2 gamePlay = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }



        private void btnBegin_Click(object sender, EventArgs e)
        {
            gamePlay.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            splashScreen.Visible = false;
            timer1.Enabled = false;
        }
    }
}
