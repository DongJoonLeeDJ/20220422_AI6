using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpStudy04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "안녕";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mbox tab tab
            MessageBox.Show("Test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
