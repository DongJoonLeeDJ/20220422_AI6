using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpStudy07_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.name = textBox1.Text;
            int.TryParse(textBox2.Text, out int age);
            c.age = age;

            c.meow();
            string message = c.eat();
            MessageBox.Show(message);

            Cat.jump();
        }
    }
}
