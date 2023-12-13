using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int speed = 10;
            pictureBoxRoad.Top += speed;
            pictureBoxRoad2.Top += speed;

            int cone_speed = 10;
            pictureBox1.Top += cone_speed;
            pictureBox2.Top += cone_speed;

            if (pictureBoxRoad.Top >= 1024)
            {
                pictureBoxRoad.Top = 0;
                pictureBoxRoad2.Top = -1024;
            }

            if (pictureBox1.Top >= 1024)
            {
                pictureBox1.Top = -100;
                pictureBox1.Left = 45 + random.Next(450);
            }

            if (pictureBox2.Top >= 1024)
            {
                pictureBox2.Top = -100;
                pictureBox2.Left = 511 + random.Next(400);
            }

            if (Lamborghini1.Bounds.IntersectsWith(pictureBox1.Bounds) || Lamborghini1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                timer.Enabled= false;
                lose loseMenu = new lose();
                loseMenu.ShowDialog();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 10;
            if((e.KeyCode== Keys.Left || e.KeyCode == Keys.A) && Lamborghini1.Left > 10)
            {
                Lamborghini1.Left -= speed;
            }
            else if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.D) && Lamborghini1.Right < 1014)
            {
                Lamborghini1.Left += speed;
            }
        }
    }
}
