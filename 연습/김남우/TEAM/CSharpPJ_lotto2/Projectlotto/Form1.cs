using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectlotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            userControl_Home1.BringToFront();
        }

        private Point mousePoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(Left - (mousePoint.X - e.X), Top - (mousePoint.Y - e.Y));
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Game_Click(object sender, EventArgs e)
        {
            game1.BringToFront();

            panelLeft.Height = Game.Height;
            panelLeft.Top = Game.Top;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            userControl_Home1.BringToFront();

            panelLeft.Height = Home.Height;
            panelLeft.Top = Home.Top;
        }

        private void Record_Click(object sender, EventArgs e)
        {
            userControl_Record1.BringToFront();

            panelLeft.Height = Record.Height;
            panelLeft.Top = Record.Top;
        }
    }
}
